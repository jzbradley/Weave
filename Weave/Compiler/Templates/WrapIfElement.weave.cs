// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.1.3.0
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
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.1.3.0")]
        public
        void
        RenderWrapIfElement
            (
            #line 1 "WrapIfElement.weave"
       WrapIfElement
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
            #line 3 "WrapIfElement.weave"
  
    var flag = this.CreateVariable("flag");
    var newIndentationBase = this.CreateVariable("baseIndentation");

            #line default
            indentation = __temp0;
            writer.Write(indentation);
            writer.Write("var ");
            writer.Write(
                #line 7 "WrapIfElement.weave"
        flag 
                #line default
                );
            writer.Write(" =");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            var __model0 =
                #line 8 "WrapIfElement.weave"
                  model.Expression
                #line default
                ;
            RenderCode(__model0, writer, indentation);
            writer.Write(indentation);
            writer.Write(";");
            writer.WriteLine();
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("string ");
            writer.Write(
                #line 10 "WrapIfElement.weave"
           newIndentationBase 
                #line default
                );
            writer.Write(";");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("if (");
            writer.Write(
                #line 11 "WrapIfElement.weave"
        flag 
                #line default
                );
            writer.Write(")");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            var __model1 =
                #line 13 "WrapIfElement.weave"
                    model.Before
                #line default
                ;
            WalkElements(__model1, writer, indentation);
            writer.Write(indentation);
            writer.Write(
                #line 14 "WrapIfElement.weave"
        newIndentationBase 
                #line default
                );
            writer.Write(" = ");
            writer.Write(
                #line 14 "WrapIfElement.weave"
                                    this.indentationBase 
                #line default
                );
            writer.Write(" + ");
            writer.Write(__encode(
                #line 14 "WrapIfElement.weave"
                                                                  this.indentation[model.Body].Item2 
                #line default
                ));
            writer.Write(";");
            writer.WriteLine();
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("else");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            writer.Write(indentation);
            writer.Write(
                #line 18 "WrapIfElement.weave"
        newIndentationBase 
                #line default
                );
            writer.Write(" = ");
            writer.Write(
                #line 18 "WrapIfElement.weave"
                                    this.indentationBase 
                #line default
                );
            writer.Write(";");
            writer.WriteLine();
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
            writer.WriteLine();
            var __temp1 = indentation;
            #line 21 "WrapIfElement.weave"
  
    var oldIndentationBase = this.indentationBase;
    this.indentationBase = newIndentationBase;

            #line default
            indentation = __temp1;
            var __model2 =
                #line 25 "WrapIfElement.weave"
               model.Body
                #line default
                ;
            WalkElement(__model2, writer, indentation);
            var __temp2 = indentation;
            #line 26 "WrapIfElement.weave"
  
    this.indentationBase = oldIndentationBase;

            #line default
            indentation = __temp2;
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("if (");
            writer.Write(
                #line 30 "WrapIfElement.weave"
        flag 
                #line default
                );
            writer.Write(")");
            writer.WriteLine();
            writer.Write(indentation);
            writer.Write("{");
            writer.WriteLine();
            indentation = __originalIndentation + "    ";
            var __model3 =
                #line 32 "WrapIfElement.weave"
                    model.After
                #line default
                ;
            WalkElements(__model3, writer, indentation);
            indentation = __originalIndentation;
            writer.Write(indentation);
            writer.Write("}");
            writer.WriteLine();
        }
    }
}
