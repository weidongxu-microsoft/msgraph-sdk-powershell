namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartGridlinesFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartGridlinesFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartGridlinesFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartGridlinesFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
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
                return _componentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 .Line;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 .Line = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphWorkbookChartGridlinesFormat" /> instance.
        /// </summary>
        public MicrosoftGraphWorkbookChartGridlinesFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartGridlinesFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesformatAllof1 {

    }
}