namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartAxes</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1
    {
        /// <summary>Backing field for <see cref="CategoryAxis" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAxis _categoryAxis;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxis CategoryAxis
        {
            get
            {
                return this._categoryAxis;
            }
            set
            {
                this._categoryAxis = value;
            }
        }
        /// <summary>Backing field for <see cref="SeriesAxis" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAxis _seriesAxis;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxis SeriesAxis
        {
            get
            {
                return this._seriesAxis;
            }
            set
            {
                this._seriesAxis = value;
            }
        }
        /// <summary>Backing field for <see cref="ValueAxis" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAxis _valueAxis;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxis ValueAxis
        {
            get
            {
                return this._valueAxis;
            }
            set
            {
                this._valueAxis = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1()
        {
        }
    }
    /// workbookChartAxes
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartAxis CategoryAxis { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartAxis SeriesAxis { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartAxis ValueAxis { get; set; }
    }
}