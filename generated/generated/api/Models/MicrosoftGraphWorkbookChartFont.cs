namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartFont : Sample.API.Models.IMicrosoftGraphWorkbookChartFont, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartFont" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1 _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartFont" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public bool? Bold
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Bold;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Bold = value;
            }
        }
        public string Color
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Color;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Color = value;
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
        public bool? Italic
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Italic;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Italic = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Name = value;
            }
        }
        public double? Size
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Size;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Size = value;
            }
        }
        public string Underline
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Underline;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 .Underline = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartFont" /> instance.</summary>
        public MicrosoftGraphWorkbookChartFont()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartfontAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartFont : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1 {

    }
}