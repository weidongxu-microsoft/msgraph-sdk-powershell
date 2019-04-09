namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartAxisFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartAxisFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxisFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxisFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 .Font;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 .Font = value;
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
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 .Line;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 .Line = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartAxisFormat" /> instance.</summary>
        public MicrosoftGraphWorkbookChartAxisFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartAxisFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxisformatAllof1 {

    }
}