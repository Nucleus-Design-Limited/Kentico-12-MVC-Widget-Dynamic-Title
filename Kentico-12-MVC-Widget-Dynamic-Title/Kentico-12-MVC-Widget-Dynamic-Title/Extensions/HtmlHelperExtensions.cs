using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kentico_12_MVC_Widget_Dynamic_Title
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString RenderTitle(this DynamicTitleWidgetViewModel item)
        {
            if (item != null && !string.IsNullOrEmpty(item.TitleText))
            {
                var classNamePart = !string.IsNullOrEmpty(item.ClassName) ? $" class=\"{item.ClassName} \"" : "";
                if (!string.IsNullOrEmpty(item.Hx) && item.Hx.ToLower() == "header")
                {
                    var hTagHeader = $"<div {classNamePart}>{item.TitleText}</div>";
                    return new MvcHtmlString(hTagHeader);
                }
  
                var hTag = $"<{item.Hx}{classNamePart}>{item.TitleText}</{item.Hx}>";
                return new MvcHtmlString(hTag);
            }
            else
            {
                return new MvcHtmlString("");
            }
        }
    }
}