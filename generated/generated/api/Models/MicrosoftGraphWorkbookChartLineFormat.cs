namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartLineFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartLineFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartLineFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartLineFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string Color
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 .Color;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 .Color = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartLineFormat" /> instance.</summary>
        public MicrosoftGraphWorkbookChartLineFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartLineFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 {

    }
}