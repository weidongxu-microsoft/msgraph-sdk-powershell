namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookTable : Sample.API.Models.IMicrosoftGraphWorkbookTable, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTable" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktableAllof1 _componentsSchemasMicrosoftGraphWorkbooktableAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbooktableAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTable" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookTableColumn[] Columns
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Columns;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Columns = value;
            }
        }
        public bool? HighlightFirstColumn
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .HighlightFirstColumn;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .HighlightFirstColumn = value;
            }
        }
        public bool? HighlightLastColumn
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .HighlightLastColumn;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .HighlightLastColumn = value;
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
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Name = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookTableRow[] Rows
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Rows;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Rows = value;
            }
        }
        public bool? ShowBandedColumns
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowBandedColumns;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowBandedColumns = value;
            }
        }
        public bool? ShowBandedRows
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowBandedRows;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowBandedRows = value;
            }
        }
        public bool? ShowFilterButton
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowFilterButton;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowFilterButton = value;
            }
        }
        public bool? ShowHeaders
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowHeaders;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowHeaders = value;
            }
        }
        public bool? ShowTotals
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowTotals;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .ShowTotals = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookTableSort Sort
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Sort;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Sort = value;
            }
        }
        public string Style
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Style;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Style = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Worksheet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktableAllof1 .Worksheet = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookTable" /> instance.</summary>
        public MicrosoftGraphWorkbookTable()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbooktableAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktableAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbooktableAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktableAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookTable : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktableAllof1 {

    }
}