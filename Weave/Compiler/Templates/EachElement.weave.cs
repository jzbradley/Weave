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
        RenderEachElement
            (
            #line 1 "EachElement.weave"
       EachElement
            #line default
            model, TextWriter writer, string indentation = null)
        {
            var __originalIndentation = indentation = indentation ?? string.Empty;
            var __temp0 = indentation;
            #line 3 "EachElement.weave"
  
    var flag = this.CreateVariable("_flag");

            #line default
            indentation = __temp0;
            if (
                #line 6 "EachElement.weave"
     model.NoneBody != null
                #line default
                )
            {
                writer.Write(indentation);
                writer.Write("bool ");
                writer.Write(
                    #line 7 "EachElement.weave"
             flag 
                    #line default
                    );
                writer.Write(";");
                writer.WriteLine();
                writer.WriteLine();
            }
            writer.Write(indentation);
            writer.Write("foreach (var");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            var __model0 =
                #line 11 "EachElement.weave"
                  model.EachBody.Expression
                #line default
                ;
            RenderCode(__model0, writer, indentation);
            writer.Write(indentation);
            writer.Write(")");
            writer.WriteLine();
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            if (
                #line 14 "EachElement.weave"
         model.NoneBody != null
                #line default
                )
            {
                indentation = __originalIndentation + "    ";
                writer.Write(indentation);
                writer.Write(
                    #line 15 "EachElement.weave"
            flag 
                    #line default
                    );
                writer.Write(" = true;");
                writer.WriteLine();
            }
            indentation = __originalIndentation + "    ";
            var __model1 =
                #line 17 "EachElement.weave"
                    model.EachBody.Body
                #line default
                ;
            WalkElements(__model1, writer, indentation);
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
            writer.WriteLine();
            if (
                #line 20 "EachElement.weave"
     model.NoneBody != null
                #line default
                )
            {
                writer.Write(indentation);
                writer.Write("if (!");
                writer.Write(
                    #line 21 "EachElement.weave"
             flag 
                    #line default
                    );
                writer.Write(")");
                writer.WriteLine();
                writer.Write(indentation);
                writer.Write("{");
                writer.WriteLine();
                indentation = __originalIndentation + "    ";
                var __model2 =
                    #line 23 "EachElement.weave"
                        model.NoneBody.Body
                    #line default
                    ;
                WalkElements(__model2, writer, indentation);
                indentation = __originalIndentation;
                writer.Write(indentation);
                writer.Write("}");
                writer.WriteLine();
                writer.WriteLine();
            }
        }
    }
}