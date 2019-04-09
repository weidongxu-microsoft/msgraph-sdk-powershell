namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartAxisFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1()
        {
        }
    }
    /// workbookChartAxisFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartLineFormat Line { get; set; }
    }
}