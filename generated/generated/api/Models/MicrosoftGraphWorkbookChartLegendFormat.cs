namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartLegendFormat : Sample.API.Models.IMicrosoftGraphWorkbookChartLegendFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartLegendFormat" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 _componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartLegendFormat" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 .Fill;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 .Fill = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 .Font;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 .Font = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartLegendFormat" /> instance.</summary>
        public MicrosoftGraphWorkbookChartLegendFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartLegendFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlegendformatAllof1 {

    }
}