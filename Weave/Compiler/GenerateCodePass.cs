﻿// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace Weave.Compiler
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using Weave.Expressions;

    internal class GenerateCodePass : CompilePass
    {
        /// <inheritdoc/>
        public override IList<string> BlockedByErrors => new[] { "WEAVE0001", "WEAVE0003", "WEAVE0004", "WEAVE0005", "WEAVE0006" };

        /// <inheritdoc/>
        public override IList<string> ErrorsProduced => System.Array.Empty<string>();

        /// <inheritdoc/>
        public override void Run(Template template, CompileResult result)
        {
            using (var stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                new Templates(stringWriter).WalkTemplate(template);
                result.Code = stringWriter.ToString();
            }
        }
    }
}
