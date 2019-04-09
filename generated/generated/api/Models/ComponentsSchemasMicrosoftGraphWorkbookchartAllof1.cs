namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChart</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartAllof1
    {
        /// <summary>Backing field for <see cref="Axes" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAxes _axes;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxes Axes
        {
            get
            {
                return this._axes;
            }
            set
            {
                this._axes = value;
            }
        }
        /// <summary>Backing field for <see cref="DataLabels" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabels _dataLabels;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabels DataLabels
        {
            get
            {
                return this._dataLabels;
            }
            set
            {
                this._dataLabels = value;
            }
        }
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAreaFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAreaFormat Format
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
        /// <summary>Backing field for <see cref="Height" /> property.</summary>
        private double? _height;

        public double? Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        /// <summary>Backing field for <see cref="Left" /> property.</summary>
        private double? _left;

        public double? Left
        {
            get
            {
                return this._left;
            }
            set
            {
                this._left = value;
            }
        }
        /// <summary>Backing field for <see cref="Legend" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartLegend _legend;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartLegend Legend
        {
            get
            {
                return this._legend;
            }
            set
            {
                this._legend = value;
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
        /// <summary>Backing field for <see cref="Series" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartSeries[] _series;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartSeries[] Series
        {
            get
            {
                return this._series;
            }
            set
            {
                this._series = value;
            }
        }
        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartTitle _title;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartTitle Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        /// <summary>Backing field for <see cref="Top" /> property.</summary>
        private double? _top;

        public double? Top
        {
            get
            {
                return this._top;
            }
            set
            {
                this._top = value;
            }
        }
        /// <summary>Backing field for <see cref="Width" /> property.</summary>
        private double? _width;

        public double? Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        /// <summary>Backing field for <see cref="Worksheet" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookWorksheet _worksheet;

        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet
        {
            get
            {
                return this._worksheet;
            }
            set
            {
                this._worksheet = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartAllof1()
        {
        }
    }
    /// workbookChart
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartAxes Axes { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabels DataLabels { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartAreaFormat Format { get; set; }
        double? Height { get; set; }
        double? Left { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartLegend Legend { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartSeries[] Series { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartTitle Title { get; set; }
        double? Top { get; set; }
        double? Width { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet { get; set; }
    }
}