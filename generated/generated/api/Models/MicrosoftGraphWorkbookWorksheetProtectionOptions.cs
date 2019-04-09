namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookWorksheetProtectionOptions</summary>
    public partial class MicrosoftGraphWorkbookWorksheetProtectionOptions : Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions
    {
        /// <summary>Backing field for <see cref="AllowAutoFilter" /> property.</summary>
        private bool? _allowAutoFilter;

        public bool? AllowAutoFilter
        {
            get
            {
                return this._allowAutoFilter;
            }
            set
            {
                this._allowAutoFilter = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowDeleteColumns" /> property.</summary>
        private bool? _allowDeleteColumns;

        public bool? AllowDeleteColumns
        {
            get
            {
                return this._allowDeleteColumns;
            }
            set
            {
                this._allowDeleteColumns = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowDeleteRows" /> property.</summary>
        private bool? _allowDeleteRows;

        public bool? AllowDeleteRows
        {
            get
            {
                return this._allowDeleteRows;
            }
            set
            {
                this._allowDeleteRows = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowFormatCells" /> property.</summary>
        private bool? _allowFormatCells;

        public bool? AllowFormatCells
        {
            get
            {
                return this._allowFormatCells;
            }
            set
            {
                this._allowFormatCells = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowFormatColumns" /> property.</summary>
        private bool? _allowFormatColumns;

        public bool? AllowFormatColumns
        {
            get
            {
                return this._allowFormatColumns;
            }
            set
            {
                this._allowFormatColumns = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowFormatRows" /> property.</summary>
        private bool? _allowFormatRows;

        public bool? AllowFormatRows
        {
            get
            {
                return this._allowFormatRows;
            }
            set
            {
                this._allowFormatRows = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowInsertColumns" /> property.</summary>
        private bool? _allowInsertColumns;

        public bool? AllowInsertColumns
        {
            get
            {
                return this._allowInsertColumns;
            }
            set
            {
                this._allowInsertColumns = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowInsertHyperlinks" /> property.</summary>
        private bool? _allowInsertHyperlinks;

        public bool? AllowInsertHyperlinks
        {
            get
            {
                return this._allowInsertHyperlinks;
            }
            set
            {
                this._allowInsertHyperlinks = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowInsertRows" /> property.</summary>
        private bool? _allowInsertRows;

        public bool? AllowInsertRows
        {
            get
            {
                return this._allowInsertRows;
            }
            set
            {
                this._allowInsertRows = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowPivotTables" /> property.</summary>
        private bool? _allowPivotTables;

        public bool? AllowPivotTables
        {
            get
            {
                return this._allowPivotTables;
            }
            set
            {
                this._allowPivotTables = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowSort" /> property.</summary>
        private bool? _allowSort;

        public bool? AllowSort
        {
            get
            {
                return this._allowSort;
            }
            set
            {
                this._allowSort = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphWorkbookWorksheetProtectionOptions" /> instance.
        /// </summary>
        public MicrosoftGraphWorkbookWorksheetProtectionOptions()
        {
        }
    }
    /// workbookWorksheetProtectionOptions
    public partial interface IMicrosoftGraphWorkbookWorksheetProtectionOptions : Sample.API.Runtime.IJsonSerializable {
        bool? AllowAutoFilter { get; set; }
        bool? AllowDeleteColumns { get; set; }
        bool? AllowDeleteRows { get; set; }
        bool? AllowFormatCells { get; set; }
        bool? AllowFormatColumns { get; set; }
        bool? AllowFormatRows { get; set; }
        bool? AllowInsertColumns { get; set; }
        bool? AllowInsertHyperlinks { get; set; }
        bool? AllowInsertRows { get; set; }
        bool? AllowPivotTables { get; set; }
        bool? AllowSort { get; set; }
    }
}