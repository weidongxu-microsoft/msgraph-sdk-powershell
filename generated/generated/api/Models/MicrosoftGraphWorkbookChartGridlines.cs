namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartGridlines : Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartGridlines" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 _componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartGridlines" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartGridlinesFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 .Format = value;
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
        public bool? Visible
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 .Visible;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 .Visible = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartGridlines" /> instance.</summary>
        public MicrosoftGraphWorkbookChartGridlines()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartGridlines : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 {

    }
}