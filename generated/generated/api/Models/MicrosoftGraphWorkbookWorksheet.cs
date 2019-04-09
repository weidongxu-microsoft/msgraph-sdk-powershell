namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookWorksheet : Sample.API.Models.IMicrosoftGraphWorkbookWorksheet, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookWorksheet" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1 _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookWorksheet" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookChart[] Charts
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Charts;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Charts = value;
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
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Name = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] Names
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Names;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Names = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookPivotTable[] PivotTables
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .PivotTables;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .PivotTables = value;
            }
        }
        public int? Position
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Position;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Position = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtection Protection
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Protection;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Protection = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookTable[] Tables
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Tables;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Tables = value;
            }
        }
        public string Visibility
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Visibility;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 .Visibility = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookWorksheet" /> instance.</summary>
        public MicrosoftGraphWorkbookWorksheet()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 ), _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 ), _componentsSchemasMicrosoftGraphWorkbookworksheetAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookWorksheet : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1 {

    }
}