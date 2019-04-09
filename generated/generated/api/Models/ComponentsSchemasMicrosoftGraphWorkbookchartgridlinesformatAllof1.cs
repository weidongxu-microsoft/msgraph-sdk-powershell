namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartGridlinesFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1
    {
        /// <summary>Backing field for <see cref="Line" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartLineFormat _line;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartLineFormat Line
        {
            get
            {
                return this._line;
            }
            set
            {
                this._line = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1()
        {
        }
    }
    /// workbookChartGridlinesFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartLineFormat Line { get; set; }
    }
}