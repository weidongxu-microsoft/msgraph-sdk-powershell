namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookSortField</summary>
    public partial class MicrosoftGraphWorkbookSortField : Sample.API.Models.IMicrosoftGraphWorkbookSortField
    {
        /// <summary>Backing field for <see cref="Ascending" /> property.</summary>
        private bool? _ascending;

        public bool? Ascending
        {
            get
            {
                return this._ascending;
            }
            set
            {
                this._ascending = value;
            }
        }
        /// <summary>Backing field for <see cref="Color" /> property.</summary>
        private string _color;

        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        /// <summary>Backing field for <see cref="DataOption" /> property.</summary>
        private string _dataOption;

        public string DataOption
        {
            get
            {
                return this._dataOption;
            }
            set
            {
                this._dataOption = value;
            }
        }
        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookIcon _icon;

        /// <summary>workbookIcon</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookIcon Icon
        {
            get
            {
                return this._icon;
            }
            set
            {
                this._icon = value;
            }
        }
        public int? IconIndex
        {
            get
            {
                return /*1*/Icon/*4*/.Index/*3*/;
            }
            set
            {
                /*1*/Icon/*4*/.Index/*3*/ = value;
            }
        }
        public string IconSet
        {
            get
            {
                return /*1*/Icon/*4*/.Set/*3*/;
            }
            set
            {
                /*1*/Icon/*4*/.Set/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private int? _key;

        public int? Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
        /// <summary>Backing field for <see cref="SortOn" /> property.</summary>
        private string _sortOn;

        public string SortOn
        {
            get
            {
                return this._sortOn;
            }
            set
            {
                this._sortOn = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookSortField" /> instance.</summary>
        public MicrosoftGraphWorkbookSortField()
        {
        }
    }
    /// workbookSortField
    public partial interface IMicrosoftGraphWorkbookSortField : Sample.API.Runtime.IJsonSerializable {
        bool? Ascending { get; set; }
        string Color { get; set; }
        string DataOption { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookIcon Icon { get; set; }
        int? IconIndex { get; set; }
        string IconSet { get; set; }
        int? Key { get; set; }
        string SortOn { get; set; }
    }
}