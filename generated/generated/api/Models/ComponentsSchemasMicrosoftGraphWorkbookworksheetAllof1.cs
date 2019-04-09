namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookWorksheet</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1
    {
        /// <summary>Backing field for <see cref="Charts" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChart[] _charts;

        public Sample.API.Models.IMicrosoftGraphWorkbookChart[] Charts
        {
            get
            {
                return this._charts;
            }
            set
            {
                this._charts = value;
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
        /// <summary>Backing field for <see cref="Names" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] _names;

        public Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] Names
        {
            get
            {
                return this._names;
            }
            set
            {
                this._names = value;
            }
        }
        /// <summary>Backing field for <see cref="PivotTables" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookPivotTable[] _pivotTables;

        public Sample.API.Models.IMicrosoftGraphWorkbookPivotTable[] PivotTables
        {
            get
            {
                return this._pivotTables;
            }
            set
            {
                this._pivotTables = value;
            }
        }
        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private int? _position;

        public int? Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        /// <summary>Backing field for <see cref="Protection" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtection _protection;

        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtection Protection
        {
            get
            {
                return this._protection;
            }
            set
            {
                this._protection = value;
            }
        }
        /// <summary>Backing field for <see cref="Tables" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookTable[] _tables;

        public Sample.API.Models.IMicrosoftGraphWorkbookTable[] Tables
        {
            get
            {
                return this._tables;
            }
            set
            {
                this._tables = value;
            }
        }
        /// <summary>Backing field for <see cref="Visibility" /> property.</summary>
        private string _visibility;

        public string Visibility
        {
            get
            {
                return this._visibility;
            }
            set
            {
                this._visibility = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1()
        {
        }
    }
    /// workbookWorksheet
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChart[] Charts { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] Names { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookPivotTable[] PivotTables { get; set; }
        int? Position { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtection Protection { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookTable[] Tables { get; set; }
        string Visibility { get; set; }
    }
}