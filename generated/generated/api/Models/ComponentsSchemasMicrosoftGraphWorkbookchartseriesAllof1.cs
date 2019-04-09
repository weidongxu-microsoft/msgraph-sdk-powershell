namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartSeries</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartSeriesFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartSeriesFormat Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Points" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartPoint[] _points;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartPoint[] Points
        {
            get
            {
                return this._points;
            }
            set
            {
                this._points = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1()
        {
        }
    }
    /// workbookChartSeries
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartSeriesFormat Format { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartPoint[] Points { get; set; }
    }
}