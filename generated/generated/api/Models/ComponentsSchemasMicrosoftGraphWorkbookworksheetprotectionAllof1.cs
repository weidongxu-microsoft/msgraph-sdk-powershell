namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookWorksheetProtection</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1
    {
        /// <summary>Backing field for <see cref="Options" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions _options;

        /// <summary>workbookWorksheetProtectionOptions</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions Options
        {
            get
            {
                return this._options;
            }
            set
            {
                this._options = value;
            }
        }
        public bool? OptionsAllowAutoFilter
        {
            get
            {
                return /*1*/Options/*4*/.AllowAutoFilter/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowAutoFilter/*3*/ = value;
            }
        }
        public bool? OptionsAllowDeleteColumns
        {
            get
            {
                return /*1*/Options/*4*/.AllowDeleteColumns/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowDeleteColumns/*3*/ = value;
            }
        }
        public bool? OptionsAllowDeleteRows
        {
            get
            {
                return /*1*/Options/*4*/.AllowDeleteRows/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowDeleteRows/*3*/ = value;
            }
        }
        public bool? OptionsAllowFormatCells
        {
            get
            {
                return /*1*/Options/*4*/.AllowFormatCells/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowFormatCells/*3*/ = value;
            }
        }
        public bool? OptionsAllowFormatColumns
        {
            get
            {
                return /*1*/Options/*4*/.AllowFormatColumns/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowFormatColumns/*3*/ = value;
            }
        }
        public bool? OptionsAllowFormatRows
        {
            get
            {
                return /*1*/Options/*4*/.AllowFormatRows/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowFormatRows/*3*/ = value;
            }
        }
        public bool? OptionsAllowInsertColumns
        {
            get
            {
                return /*1*/Options/*4*/.AllowInsertColumns/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowInsertColumns/*3*/ = value;
            }
        }
        public bool? OptionsAllowInsertHyperlinks
        {
            get
            {
                return /*1*/Options/*4*/.AllowInsertHyperlinks/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowInsertHyperlinks/*3*/ = value;
            }
        }
        public bool? OptionsAllowInsertRows
        {
            get
            {
                return /*1*/Options/*4*/.AllowInsertRows/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowInsertRows/*3*/ = value;
            }
        }
        public bool? OptionsAllowPivotTables
        {
            get
            {
                return /*1*/Options/*4*/.AllowPivotTables/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowPivotTables/*3*/ = value;
            }
        }
        public bool? OptionsAllowSort
        {
            get
            {
                return /*1*/Options/*4*/.AllowSort/*3*/;
            }
            set
            {
                /*1*/Options/*4*/.AllowSort/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Protected" /> property.</summary>
        private bool? _protected;

        public bool? Protected
        {
            get
            {
                return this._protected;
            }
            set
            {
                this._protected = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1()
        {
        }
    }
    /// workbookWorksheetProtection
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookworksheetprotectionAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions Options { get; set; }
        bool? OptionsAllowAutoFilter { get; set; }
        bool? OptionsAllowDeleteColumns { get; set; }
        bool? OptionsAllowDeleteRows { get; set; }
        bool? OptionsAllowFormatCells { get; set; }
        bool? OptionsAllowFormatColumns { get; set; }
        bool? OptionsAllowFormatRows { get; set; }
        bool? OptionsAllowInsertColumns { get; set; }
        bool? OptionsAllowInsertHyperlinks { get; set; }
        bool? OptionsAllowInsertRows { get; set; }
        bool? OptionsAllowPivotTables { get; set; }
        bool? OptionsAllowSort { get; set; }
        bool? Protected { get; set; }
    }
}