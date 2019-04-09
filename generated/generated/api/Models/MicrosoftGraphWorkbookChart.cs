namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChart : Sample.API.Models.IMicrosoftGraphWorkbookChart, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChart" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartAllof1 _componentsSchemasMicrosoftGraphWorkbookchartAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChart" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxes Axes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Axes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Axes = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabels DataLabels
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .DataLabels;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .DataLabels = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAreaFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Format = value;
            }
        }
        public double? Height
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Height;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Height = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        public double? Left
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Left;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Left = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartLegend Legend
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Legend;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Legend = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Name = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartSeries[] Series
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Series;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Series = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartTitle Title
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Title;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Title = value;
            }
        }
        public double? Top
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Top;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Top = value;
            }
        }
        public double? Width
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Width;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Width = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Worksheet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartAllof1 .Worksheet = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChart" /> instance.</summary>
        public MicrosoftGraphWorkbookChart()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChart : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartAllof1 {

    }
}