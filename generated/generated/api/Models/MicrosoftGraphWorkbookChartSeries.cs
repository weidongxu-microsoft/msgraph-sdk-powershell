namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookChartSeries : Sample.API.Models.IMicrosoftGraphWorkbookChartSeries, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartSeries" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookChartSeries" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChartSeriesFormat Format
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 .Format;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 .Format = value;
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
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 .Name = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookChartPoint[] Points
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 .Points;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 .Points = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookChartSeries" /> instance.</summary>
        public MicrosoftGraphWorkbookChartSeries()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 ), _componentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookChartSeries : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartseriesAllof1 {

    }
}