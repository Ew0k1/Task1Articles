using System;
using System.Web.Mvc;

namespace BlogTask.Helpers
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayStringItems(this HtmlHelper html, string[] list, string type, string name)
        {
            TagBuilder tag = new TagBuilder("ul");
            foreach (string str in list)
            {
                TagBuilder listItemTag = new TagBuilder("li");
                TagBuilder inputItemTag = new TagBuilder("input");
                TagBuilder spanItemTag = new TagBuilder("span");
                spanItemTag.SetInnerText(str);
                inputItemTag.MergeAttribute("name", name);
                inputItemTag.MergeAttribute("type", type);
                inputItemTag.MergeAttribute("value", str);
                listItemTag.AddCssClass("marker");
                listItemTag.InnerHtml += inputItemTag.ToString();
                listItemTag.InnerHtml += spanItemTag.ToString();



                tag.InnerHtml += listItemTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }
    }
}