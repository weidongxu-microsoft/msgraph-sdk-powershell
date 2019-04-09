namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookTable</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbooktableAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktableAllof1
    {
        /// <summary>Backing field for <see cref="Columns" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookTableColumn[] _columns;

        public Sample.API.Models.IMicrosoftGraphWorkbookTableColumn[] Columns
        {
            get
            {
                return this._columns;
            }
            set
            {
                this._columns = value;
            }
        }
        /// <summary>Backing field for <see cref="HighlightFirstColumn" /> property.</summary>
        private bool? _highlightFirstColumn;

        public bool? HighlightFirstColumn
        {
            get
            {
                return this._highlightFirstColumn;
            }
            set
            {
                this._highlightFirstColumn = value;
            }
        }
        /// <summary>Backing field for <see cref="HighlightLastColumn" /> property.</summary>
        private bool? _highlightLastColumn;

        public bool? HighlightLastColumn
        {
            get
            {
                return this._highlightLastColumn;
            }
            set
            {
                this._highlightLastColumn = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Rows" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookTableRow[] _rows;

        public Sample.API.Models.IMicrosoftGraphWorkbookTableRow[] Rows
        {
            get
            {
                return this._rows;
            }
            set
            {
                this._rows = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowBandedColumns" /> property.</summary>
        private bool? _showBandedColumns;

        public bool? ShowBandedColumns
        {
            get
            {
                return this._showBandedColumns;
            }
            set
            {
                this._showBandedColumns = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowBandedRows" /> property.</summary>
        private bool? _showBandedRows;

        public bool? ShowBandedRows
        {
            get
            {
                return this._showBandedRows;
            }
            set
            {
                this._showBandedRows = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowFilterButton" /> property.</summary>
        private bool? _showFilterButton;

        public bool? ShowFilterButton
        {
            get
            {
                return this._showFilterButton;
            }
            set
            {
                this._showFilterButton = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowHeaders" /> property.</summary>
        private bool? _showHeaders;

        public bool? ShowHeaders
        {
            get
            {
                return this._showHeaders;
            }
            set
            {
                this._showHeaders = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowTotals" /> property.</summary>
        private bool? _showTotals;

        public bool? ShowTotals
        {
            get
            {
                return this._showTotals;
            }
            set
            {
                this._showTotals = value;
            }
        }
        /// <summary>Backing field for <see cref="Sort" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookTableSort _sort;

        public Sample.API.Models.IMicrosoftGraphWorkbookTableSort Sort
        {
            get
            {
                return this._sort;
            }
            set
            {
                this._sort = value;
            }
        }
        /// <summary>Backing field for <see cref="Style" /> property.</summary>
        private string _style;

        public string Style
        {
            get
            {
                return this._style;
            }
            set
            {
                this._style = value;
            }
        }
        /// <summary>Backing field for <see cref="Worksheet" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookWorksheet _worksheet;

        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet
        {
            get
            {
                return this._worksheet;
            }
            set
            {
                this._worksheet = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbooktableAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbooktableAllof1()
        {
        }
    }
    /// workbookTable
    public partial interface IComponentsSchemasMicrosoftGraphWorkbooktableAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookTableColumn[] Columns { get; set; }
        bool? HighlightFirstColumn { get; set; }
        bool? HighlightLastColumn { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookTableRow[] Rows { get; set; }
        bool? ShowBandedColumns { get; set; }
        bool? ShowBandedRows { get; set; }
        bool? ShowFilterButton { get; set; }
        bool? ShowHeaders { get; set; }
        bool? ShowTotals { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookTableSort Sort { get; set; }
        string Style { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet { get; set; }
    }
}