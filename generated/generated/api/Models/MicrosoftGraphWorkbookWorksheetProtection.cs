namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookWorksheetProtection : Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtection, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookWorksheetProtection" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookWorksheetProtection" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
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
        /// <summary>workbookWorksheetProtectionOptions</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions Options
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .Options;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .Options = value;
            }
        }
        public bool? OptionsAllowAutoFilter
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowAutoFilter;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowAutoFilter = value;
            }
        }
        public bool? OptionsAllowDeleteColumns
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowDeleteColumns;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowDeleteColumns = value;
            }
        }
        public bool? OptionsAllowDeleteRows
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowDeleteRows;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowDeleteRows = value;
            }
        }
        public bool? OptionsAllowFormatCells
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowFormatCells;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowFormatCells = value;
            }
        }
        public bool? OptionsAllowFormatColumns
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowFormatColumns;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowFormatColumns = value;
            }
        }
        public bool? OptionsAllowFormatRows
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowFormatRows;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowFormatRows = value;
            }
        }
        public bool? OptionsAllowInsertColumns
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowInsertColumns;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowInsertColumns = value;
            }
        }
        public bool? OptionsAllowInsertHyperlinks
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowInsertHyperlinks;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowInsertHyperlinks = value;
            }
        }
        public bool? OptionsAllowInsertRows
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowInsertRows;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowInsertRows = value;
            }
        }
        public bool? OptionsAllowPivotTables
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowPivotTables;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowPivotTables = value;
            }
        }
        public bool? OptionsAllowSort
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowSort;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .OptionsAllowSort = value;
            }
        }
        public bool? Protected
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .Protected;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 .Protected = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphWorkbookWorksheetProtection" /> instance.
        /// </summary>
        public MicrosoftGraphWorkbookWorksheetProtection()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 ), _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 ), _componentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookWorksheetProtection : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 {

    }
}