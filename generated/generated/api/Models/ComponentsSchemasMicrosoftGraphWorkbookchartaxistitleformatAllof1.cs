namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartAxisTitleFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1
    {
        /// <summary>Backing field for <see cref="Font" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartFont _font;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font
        {
            get
            {
                return this._font;
            }
            set
            {
                this._font = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1()
        {
        }
    }
    /// workbookChartAxisTitleFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font { get; set; }
    }
}