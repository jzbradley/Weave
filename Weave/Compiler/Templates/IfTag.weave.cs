
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
        public void RenderIfTag(IfTag model, TextWriter writer)
        {
             var first = true; 
writer.Write("\r\n");




foreach (var  branch in model.Branches)
{
    

    writer.Write("\r\n    ");


    
    
    if ( !first)

{
    writer.Write("\r\n        else\r\n    ");

}
    
writer.Write("\r\n    ");
 this.WalkBranch(branch); 
writer.Write("\r\n    ");
 first = false; 
writer.Write("\r\n");

}


        }
    }
}