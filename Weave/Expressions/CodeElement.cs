﻿// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace Weave.Expressions
{
    using System;

    /// <summary>
    /// Represents an executed section of a <see cref="Template"/>.
    /// </summary>
    public class CodeElement : Element
    {
        private readonly SourceSpan expression;
        private readonly string indentation;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeElement"/> class.
        /// </summary>
        /// <param name="expression">The code expression that will be executed.</param>
        /// <param name="indentation">The indentation of this <see cref="CodeElement"/>.</param>
        public CodeElement(SourceSpan expression, string indentation = null)
        {
            this.expression = expression ?? throw new ArgumentNullException(nameof(expression));
            this.indentation = indentation;
        }

        /// <summary>
        /// Gets the code expression that will be executed.
        /// </summary>
        public SourceSpan Expression => this.expression;

        /// <summary>
        /// Gets the indentation of this <see cref="CodeElement"/>.
        /// </summary>
        public string Indentation => this.indentation;
    }
}
