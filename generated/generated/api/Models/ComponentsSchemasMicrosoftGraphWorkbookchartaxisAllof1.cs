namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartAxis</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAxisFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxisFormat Format
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
        /// <summary>Backing field for <see cref="MajorGridlines" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines _majorGridlines;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines MajorGridlines
        {
            get
            {
                return this._majorGridlines;
            }
            set
            {
                this._majorGridlines = value;
            }
        }
        /// <summary>Backing field for <see cref="MajorUnit" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _majorUnit;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson MajorUnit
        {
            get
            {
                return this._majorUnit;
            }
            set
            {
                this._majorUnit = value;
            }
        }
        /// <summary>Backing field for <see cref="Maximum" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _maximum;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Maximum
        {
            get
            {
                return this._maximum;
            }
            set
            {
                this._maximum = value;
            }
        }
        /// <summary>Backing field for <see cref="Minimum" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _minimum;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Minimum
        {
            get
            {
                return this._minimum;
            }
            set
            {
                this._minimum = value;
            }
        }
        /// <summary>Backing field for <see cref="MinorGridlines" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines _minorGridlines;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines MinorGridlines
        {
            get
            {
                return this._minorGridlines;
            }
            set
            {
                this._minorGridlines = value;
            }
        }
        /// <summary>Backing field for <see cref="MinorUnit" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _minorUnit;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson MinorUnit
        {
            get
            {
                return this._minorUnit;
            }
            set
            {
                this._minorUnit = value;
            }
        }
        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitle _title;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitle Title
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1()
        {
        }
    }
    /// workbookChartAxis
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartAxisFormat Format { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines MajorGridlines { get; set; }
        Sample.API.Models.IMicrosoftGraphJson MajorUnit { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Maximum { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Minimum { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines MinorGridlines { get; set; }
        Sample.API.Models.IMicrosoftGraphJson MinorUnit { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitle Title { get; set; }
    }
}