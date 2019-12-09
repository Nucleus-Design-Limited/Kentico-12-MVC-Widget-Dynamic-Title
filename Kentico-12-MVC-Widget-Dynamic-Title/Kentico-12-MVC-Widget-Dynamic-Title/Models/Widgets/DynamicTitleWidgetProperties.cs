using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace Kentico_12_MVC_Widget_Dynamic_Title
{
    public class DynamicTitleWidgetProperties : IWidgetProperties
    {
        const string HX_OPTIONS = @"
            h1;H1
            h2;H2
            h3;H3
            h4;H4
            h5;H5
            header;Header";

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title text")]
        public string TitleText { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Hx", Order = 2)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), HX_OPTIONS)]
        public string Hx { get; set; } = "h1";

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Optional class")]
        public string OptionalClass { get; set; }
    }
}