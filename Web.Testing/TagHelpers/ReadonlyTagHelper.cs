using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.Testing.TagHelpers
{
    [HtmlTargetElement("input", Attributes = IsReadonlyAttribute)]
    [HtmlTargetElement("select", Attributes = IsReadonlyAttribute)]
    public class ReadonlyTagHelper : TagHelper
    {
        public const string IsReadonlyAttribute = "is-readonly";

        [HtmlAttributeName(IsReadonlyAttribute)]
        public bool IsReadonly { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (IsReadonly)
                output.Attributes.Add("readonly", "readonly");
        }
    }
}