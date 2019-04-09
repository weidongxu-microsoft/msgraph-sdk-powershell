namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartAxes : Sample.API.Models.IMicrosoftGraphWorkbookChartAxes, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxes" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxes" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxis CategoryAxis
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 .CategoryAxis;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 .CategoryAxis = value;
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
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxis SeriesAxis
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 .SeriesAxis;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 .SeriesAxis = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxis ValueAxis
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 .ValueAxis;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 .ValueAxis = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartAxes" /> instance.</summary>
        public MicrosoftGraphWorkbookChartAxes()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartAxes : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxesAllof1 {

    }
}