namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartAxisTitleFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitleFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxisTitleFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxisTitleFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 .Font;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 .Font = value;
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
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphWorkbookChartAxisTitleFormat" /> instance.
        /// </summary>
        public MicrosoftGraphWorkbookChartAxisTitleFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartAxisTitleFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleformatAllof1 {

    }
}