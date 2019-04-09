namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartAxis : Sample.API.Models.IMicrosoftGraphWorkbookChartAxis, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxis" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartAxis" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxisFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Format = value;
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
        public Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines MajorGridlines
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MajorGridlines;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MajorGridlines = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson MajorUnit
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MajorUnit;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MajorUnit = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Maximum
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Maximum;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Maximum = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Minimum
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Minimum;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Minimum = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartGridlines MinorGridlines
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MinorGridlines;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MinorGridlines = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson MinorUnit
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MinorUnit;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .MinorUnit = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitle Title
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Title;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 .Title = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartAxis" /> instance.</summary>
        public MicrosoftGraphWorkbookChartAxis()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartAxis : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxisAllof1 {

    }
}