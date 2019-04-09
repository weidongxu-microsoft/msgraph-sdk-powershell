namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartSeriesFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartSeriesFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartSeriesFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartSeriesFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 .Fill;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 .Fill = value;
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
        public Sample.API.Models.IMicrosoftGraphWorkbookChartLineFormat Line
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 .Line;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 .Line = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartSeriesFormat" /> instance.</summary>
        public MicrosoftGraphWorkbookChartSeriesFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartSeriesFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartseriesformatAllof1 {

    }
}