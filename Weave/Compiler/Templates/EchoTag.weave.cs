
// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace Weave.Compiler
{
    using System.IO;
    
        using Weave.Expressions;
    

     partial class Templates
    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public void RenderEchoTag(EchoTag model, TextWriter writer)
        {
            writer.Write("writer.Write(");
writer.Write(model.Expression );
writer.Write(");\r\n");

        }
    }
}