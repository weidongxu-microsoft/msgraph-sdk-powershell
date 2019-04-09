namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartPoint : Sample.API.Models.IMicrosoftGraphWorkbookChartPoint, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartPoint" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1 _componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartPoint" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartPointFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 .Format = value;
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
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Value
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 .Value;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 .Value = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartPoint" /> instance.</summary>
        public MicrosoftGraphWorkbookChartPoint()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartpointAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartPoint : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1 {

    }
}