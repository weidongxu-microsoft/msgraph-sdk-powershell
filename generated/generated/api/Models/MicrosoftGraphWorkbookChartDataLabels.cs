namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartDataLabels : Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabels, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartDataLabels" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartDataLabels" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabelFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .Format = value;
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
        public string Position
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .Position;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .Position = value;
            }
        }
        public string Separator
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .Separator;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .Separator = value;
            }
        }
        public bool? ShowBubbleSize
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowBubbleSize;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowBubbleSize = value;
            }
        }
        public bool? ShowCategoryName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowCategoryName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowCategoryName = value;
            }
        }
        public bool? ShowLegendKey
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowLegendKey;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowLegendKey = value;
            }
        }
        public bool? ShowPercentage
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowPercentage;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowPercentage = value;
            }
        }
        public bool? ShowSeriesName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowSeriesName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowSeriesName = value;
            }
        }
        public bool? ShowValue
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowValue;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 .ShowValue = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartDataLabels" /> instance.</summary>
        public MicrosoftGraphWorkbookChartDataLabels()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartDataLabels : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 {

    }
}