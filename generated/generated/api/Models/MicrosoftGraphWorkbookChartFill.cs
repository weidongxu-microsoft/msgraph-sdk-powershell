namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartFill : Sample.API.Models.IMicrosoftGraphWorkbookChartFill, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartFill" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartfillAllof1 _componentsSchemasMicrosoftGraphWorkbookchartfillAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartfillAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartFill" /></summary>
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartFill" /> instance.</summary>
        public MicrosoftGraphWorkbookChartFill()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartfillAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartfillAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartfillAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartfillAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartFill : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartfillAllof1 {

    }
}