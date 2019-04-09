namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartTitle : Sample.API.Models.IMicrosoftGraphWorkbookChartTitle, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartTitle" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartTitle" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartTitleFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Format = value;
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
        public bool? Overlay
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Overlay;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Overlay = value;
            }
        }
        public string Text
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Text;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Text = value;
            }
        }
        public bool? Visible
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Visible;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 .Visible = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartTitle" /> instance.</summary>
        public MicrosoftGraphWorkbookChartTitle()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 ), _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 ), _componentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartTitle : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 {

    }
}