namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>lookupColumn</summary>
    public partial class MicrosoftGraphLookupColumn : Sample.API.Models.IMicrosoftGraphLookupColumn
    {
        /// <summary>Backing field for <see cref="AllowMultipleValues" /> property.</summary>
        private bool? _allowMultipleValues;

        public bool? AllowMultipleValues
        {
            get
            {
                return this._allowMultipleValues;
            }
            set
            {
                this._allowMultipleValues = value;
            }
        }
        /// <summary>Backing field for <see cref="AllowUnlimitedLength" /> property.</summary>
        private bool? _allowUnlimitedLength;

        public bool? AllowUnlimitedLength
        {
            get
            {
                return this._allowUnlimitedLength;
            }
            set
            {
                this._allowUnlimitedLength = value;
            }
        }
        /// <summary>Backing field for <see cref="ColumnName" /> property.</summary>
        private string _columnName;

        public string ColumnName
        {
            get
            {
                return this._columnName;
            }
            set
            {
                this._columnName = value;
            }
        }
        /// <summary>Backing field for <see cref="ListId" /> property.</summary>
        private string _listId;

        public string ListId
        {
            get
            {
                return this._listId;
            }
            set
            {
                this._listId = value;
            }
        }
        /// <summary>Backing field for <see cref="PrimaryLookupColumnId" /> property.</summary>
        private string _primaryLookupColumnId;

        public string PrimaryLookupColumnId
        {
            get
            {
                return this._primaryLookupColumnId;
            }
            set
            {
                this._primaryLookupColumnId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphLookupColumn" /> instance.</summary>
        public MicrosoftGraphLookupColumn()
        {
        }
    }
    /// lookupColumn
    public partial interface IMicrosoftGraphLookupColumn : Sample.API.Runtime.IJsonSerializable {
        bool? AllowMultipleValues { get; set; }
        bool? AllowUnlimitedLength { get; set; }
        string ColumnName { get; set; }
        string ListId { get; set; }
        string PrimaryLookupColumnId { get; set; }
    }
}