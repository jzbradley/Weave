// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace
    #line 1 "_config.weave"
           Weave.Compiler
    #line default
{
    using System;
    using System.IO;
    using
        #line 2 "_config.weave"
       Weave.Expressions
        #line default
        ;

    partial class
    Templates
    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public
        void
        RenderBranch
            (
            #line 1 "Branch.weave"
       Branch
            #line default
            model, TextWriter writer, string indentation = null)
        {
            var __encode = new Func<object, string>(
                #line 4 "_config.weave"
        ToLiteral
                #line default
                );
            var __originalIndentation = indentation = indentation ?? string.Empty;
            if (
                #line 3 "Branch.weave"
     model.Expression != null
                #line default
                )
            {
                writer.Write(indentation);
                writer.Write("if (");
                writer.WriteLine();
                indentation = __originalIndentation + "    ";
                var __model0 =
                    #line 5 "Branch.weave"
                      model.Expression
                    #line default
                    ;
                RenderCode(__model0, writer, indentation);
                writer.Write(indentation);
                writer.Write(")");
                writer.WriteLine();
            }
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            var __model1 =
                #line 9 "Branch.weave"
                    model.Body
                #line default
                ;
            WalkElements(__model1, writer, indentation);
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
        }
    }
}