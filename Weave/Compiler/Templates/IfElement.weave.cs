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
        RenderIfElement
            (
            #line 1 "IfElement.weave"
       IfElement
            #line default
            model, TextWriter writer, string indentation = null)
        {
            var __encode = new Func<object, string>(
                #line 4 "_config.weave"
        ToLiteral
                #line default
                );
            var __originalIndentation = indentation = indentation ?? string.Empty;
            var __temp0 = indentation;
            #line 3 "IfElement.weave"
   var first = true; 
            #line default
            indentation = __temp0;
            foreach (var
                #line 4 "IfElement.weave"
       branch in model.Branches
                #line default
                )
            {
                if (
                    #line 5 "IfElement.weave"
         !first
                    #line default
                    )
                {
                    writer.Write(indentation);
                    writer.Write("else");
                    writer.WriteLine();
                }
                var __model0 =
                    #line 8 "IfElement.weave"
                  branch
                    #line default
                    ;
                WalkBranch(__model0, writer, indentation);
                var __temp1 = indentation;
                #line 9 "IfElement.weave"
       first = false; 
                #line default
                indentation = __temp1;
            }

        }
    }
}