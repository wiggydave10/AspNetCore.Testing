using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Web.Testing.TagHelpers
{
    [HtmlTargetElement("input", Attributes = DateAttribute)]
    [HtmlTargetElement("input", Attributes = DateAttribute + "," + DateValueAttribute)]
    public class DateTagHelper : TagHelper
    {
        public const string DateAttribute = "datepicker";
        public const string DateValueAttribute = "date";

        [HtmlAttributeName(DateAttribute)]
        public bool IsDate { get; set; }

        [HtmlAttributeName(DateValueAttribute)]
        public DateTime Date { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (IsDate)
            {
                output.TagMode = TagMode.StartTagAndEndTag;
                output.PreContent.SetHtmlContent("<div class='input-group date' data-provide='datepicker'>");
                output.Attributes.Add("class", "form-control");
                output.Attributes.Add("type", "text");
                output.Attributes.Add("datetime", Date.ToString("yyyy-MM-dd'T'HH:mm:ss"));
                output.Attributes.Add("title", Date.ToString("dddd, MMMM d, yyyy"));
                output.Content.SetContent(Date.ToString("d"));
                output.PostContent.SetHtmlContent("<div class='input-group-addon'><span class='glyphicon glyphicon-th'></span></div></div>");
            }
        }
    }
}