namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartLegend : Sample.API.Models.IMicrosoftGraphWorkbookChartLegend, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartLegend" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartLegend" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartLegendFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Format = value;
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
                return _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Overlay;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Overlay = value;
            }
        }
        public string Position
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Position;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Position = value;
            }
        }
        public bool? Visible
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Visible;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 .Visible = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartLegend" /> instance.</summary>
        public MicrosoftGraphWorkbookChartLegend()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartLegend : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 {

    }
}