// -----------------------------------------------------------------------
// <auto-generated>
//   This code was generated by Weave 1.0.0.0
//
//   Changes to this file may cause incorrect behavior and will be lost if
//   the code is regenerated.
// </auto-generated>
// -----------------------------------------------------------------------

namespace 
#line 1 "IfElement.weave"
           Weave.Compiler
#line default


{
    using System.IO;
        using 
#line 4 "IfElement.weave"
       Weave.Expressions
#line default

;

        
 partial class     Templates

    {
        [System.CodeDom.Compiler.GeneratedCode("Weave", "1.0.0.0")]
        public void 
#line 2 "IfElement.weave"
            RenderIfElement
#line default

(
#line 3 "IfElement.weave"
       IfElement
#line default

 model, TextWriter writer, string indentation = null)
        {
            indentation = indentation ?? string.Empty;

#line 6 "IfElement.weave"
   var first = true; 
#line default



foreach (var 
#line 7 "IfElement.weave"
       branch in model.Branches
#line default

)
{

    if (
#line 8 "IfElement.weave"
         !first
#line default

)
{
    writer.Write("        ");
writer.Write("else");
writer.WriteLine();
}

#line 11 "IfElement.weave"
       this.WalkBranch(branch); 
#line default


#line 12 "IfElement.weave"
       first = false; 
#line default

}

        }
    }
}