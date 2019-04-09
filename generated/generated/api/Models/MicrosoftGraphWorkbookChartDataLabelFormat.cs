namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartDataLabelFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartDataLabelFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartDataLabelFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartDataLabelFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 .Fill;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 .Fill = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 .Font;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 .Font = value;
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
        /// Creates an new <see cref="MicrosoftGraphWorkbookChartDataLabelFormat" /> instance.
        /// </summary>
        public MicrosoftGraphWorkbookChartDataLabelFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartDataLabelFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 {

    }
}