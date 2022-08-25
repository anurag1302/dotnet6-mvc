using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FirstMVCProject.TagHelpers
{
    [HtmlTargetElement(tag: "profile-image")]
    public class ProfileImageTagHelper : TagHelper
    {
        public string ImageSrc { get; set; }
        public int ImageWidth { get; set; }
        public string ImageHeight { get; set; }
        public string Tooltip { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing;
            output.Attributes.Add("src", ImageSrc);
            output.Attributes.Add("height", ImageHeight);
            output.Attributes.Add("width", ImageWidth);
            output.Attributes.Add("style", "border-radius:50%");
            output.Attributes.Add("title", Tooltip);
        }
    }
}