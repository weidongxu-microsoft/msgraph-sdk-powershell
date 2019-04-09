namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartSeriesFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1
    {
        /// <summary>Backing field for <see cref="Fill" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartFill _fill;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill
        {
            get
            {
                return this._fill;
            }
            set
            {
                this._fill = value;
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1()
        {
        }
    }
    /// workbookChartSeriesFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartLineFormat Line { get; set; }
    }
}