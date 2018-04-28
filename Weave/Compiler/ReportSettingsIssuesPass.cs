﻿// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace Weave.Compiler
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Weave.Expressions;
    using Weave.Properties;

    internal class ReportSettingsIssuesPass : CompilePass
    {
        private static readonly Dictionary<string, bool> KnownSettings = new Dictionary<string, bool>
        {
            { "accessibility", true },
            { "classname", true },
            { "encode", true },
            { "methodname", true },
            { "model", true },
            { "namespace", true },
            { "static", true },
            { "using", false },
        };

        private static readonly Dictionary<string, string> ValuePatterns = new Dictionary<string, string>
        {
            { "accessibility", @"^\s*(public|protected\s+internal|internal|protected|private)\s*$" },
            { "static", @"^\s*([Tt][Rr][Uu][Ee]|[Ff][Aa][Ll][Ss][Ee])\s*$" },
        };

        /// <inheritdoc/>
        public override IList<string> BlockedByErrors => System.Array.Empty<string>();

        /// <inheritdoc/>
        public override IList<string> ErrorsProduced => new[] { "WEAVE0001", "WEAVE0002", "WEAVE0003", "WEAVE0004" };

        /// <inheritdoc/>
        public override void Run(Template template, CompileResult result)
        {
            var topLevelTemplate = template;
            var allSettings = new HashSet<string>();

            while (template != null)
            {
                var seenSettings = new HashSet<string>();

                foreach (var setting in template.Settings)
                {
                    var settingName = setting.Key.Value;
                    var cursor = setting.Key.Start;

                    if (KnownSettings.TryGetValue(settingName, out var singleAllowed))
                    {
                        if (singleAllowed && !seenSettings.Add(settingName))
                        {
                            result.AddError(cursor, () => Resources.WEAVE0001_SETTING_ALREADY_SPECIFIED, settingName);
                        }
                    }
                    else
                    {
                        result.AddWarning(cursor, () => Resources.WEAVE0002_SETTING_UNKNOWN, settingName);
                    }

                    if (ValuePatterns.TryGetValue(settingName, out var pattern))
                    {
                        if (!Regex.IsMatch(setting.Value.Value, pattern))
                        {
                            result.AddError(cursor, () => Resources.WEAVE0003_SETTING_VALUE_INVALID, setting.Value.Value, settingName);
                        }
                    }
                }

                allSettings.UnionWith(seenSettings);
                template = template.Config;
            }

            if (!allSettings.Contains("namespace"))
            {
                result.AddError(topLevelTemplate.SettingsEnd, () => Resources.WEAVE0004_NAMESPACE_NOT_SPECIFIED);
            }
        }
    }
}
