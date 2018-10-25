using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.Testing.TagHelpers
{
    [HtmlTargetElement("input", Attributes = IsDisabledAttribute)]
    public class InputDisabledTagHelper : TagHelper
    {
        public const string IsDisabledAttribute = "is-disabled";

        [HtmlAttributeName(IsDisabledAttribute)]
        public bool IsDisabled { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (IsDisabled)
                output.Attributes.Add("disabled", "disabled");
        }
    }
}