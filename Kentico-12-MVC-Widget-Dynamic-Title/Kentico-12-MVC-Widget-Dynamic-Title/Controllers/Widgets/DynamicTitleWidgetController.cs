using Kentico.PageBuilder.Web.Mvc;
using Kentico_12_MVC_Widget_Dynamic_Title;
using System.Web.Mvc;

[assembly: RegisterWidget("Kentico_12_MVC_Widget_Dynamic_Title", typeof(DynamicTitleWidgetController), "Dynamic title widget", Description = "Add title to page, and chose the Hx", IconClass = "icon-w-link")]

namespace Kentico_12_MVC_Widget_Dynamic_Title
{
    public class DynamicTitleWidgetController : WidgetController<DynamicTitleWidgetProperties>
    {
        // GET: DynamicTitleWidget
        public ActionResult Index()
        {
            var properties = GetProperties();
            var dynamicTitleviewModel = new DynamicTitleWidgetViewModel
            {
               TitleText = properties.TitleText,
               Hx = properties.Hx,
               ClassName = properties.OptionalClass
            };

            return PartialView("Widgets/DynamicTitleWidget/_DynamicTitleWidget", dynamicTitleviewModel);
        }
    }
}