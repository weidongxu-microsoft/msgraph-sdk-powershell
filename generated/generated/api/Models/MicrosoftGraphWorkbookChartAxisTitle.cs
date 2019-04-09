namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartAxisTitle : Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitle, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxisTitle" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxisTitle" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitleFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 .Format = value;
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
        public string Text
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 .Text;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 .Text = value;
            }
        }
        public bool? Visible
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 .Visible;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 .Visible = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartAxisTitle" /> instance.</summary>
        public MicrosoftGraphWorkbookChartAxisTitle()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartAxisTitle : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 {

    }
}