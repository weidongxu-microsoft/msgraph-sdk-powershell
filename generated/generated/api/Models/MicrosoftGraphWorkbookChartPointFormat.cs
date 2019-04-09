namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartPointFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartPointFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartPointFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartPointFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 .Fill;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 .Fill = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartPointFormat" /> instance.</summary>
        public MicrosoftGraphWorkbookChartPointFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartPointFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 {

    }
}