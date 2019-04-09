namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartDataLabels</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabelFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabelFormat Format
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
        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private string _position;

        public string Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        /// <summary>Backing field for <see cref="Separator" /> property.</summary>
        private string _separator;

        public string Separator
        {
            get
            {
                return this._separator;
            }
            set
            {
                this._separator = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowBubbleSize" /> property.</summary>
        private bool? _showBubbleSize;

        public bool? ShowBubbleSize
        {
            get
            {
                return this._showBubbleSize;
            }
            set
            {
                this._showBubbleSize = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowCategoryName" /> property.</summary>
        private bool? _showCategoryName;

        public bool? ShowCategoryName
        {
            get
            {
                return this._showCategoryName;
            }
            set
            {
                this._showCategoryName = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowLegendKey" /> property.</summary>
        private bool? _showLegendKey;

        public bool? ShowLegendKey
        {
            get
            {
                return this._showLegendKey;
            }
            set
            {
                this._showLegendKey = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowPercentage" /> property.</summary>
        private bool? _showPercentage;

        public bool? ShowPercentage
        {
            get
            {
                return this._showPercentage;
            }
            set
            {
                this._showPercentage = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowSeriesName" /> property.</summary>
        private bool? _showSeriesName;

        public bool? ShowSeriesName
        {
            get
            {
                return this._showSeriesName;
            }
            set
            {
                this._showSeriesName = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowValue" /> property.</summary>
        private bool? _showValue;

        public bool? ShowValue
        {
            get
            {
                return this._showValue;
            }
            set
            {
                this._showValue = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1()
        {
        }
    }
    /// workbookChartDataLabels
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabelFormat Format { get; set; }
        string Position { get; set; }
        string Separator { get; set; }
        bool? ShowBubbleSize { get; set; }
        bool? ShowCategoryName { get; set; }
        bool? ShowLegendKey { get; set; }
        bool? ShowPercentage { get; set; }
        bool? ShowSeriesName { get; set; }
        bool? ShowValue { get; set; }
    }
}