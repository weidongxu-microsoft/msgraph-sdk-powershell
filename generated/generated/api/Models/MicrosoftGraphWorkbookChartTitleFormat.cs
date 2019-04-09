namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartTitleFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartTitleFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartTitleFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 _componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartTitleFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 .Fill;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 .Fill = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 .Font;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 .Font = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartTitleFormat" /> instance.</summary>
        public MicrosoftGraphWorkbookChartTitleFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartTitleFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookcharttitleformatAllof1 {

    }
}