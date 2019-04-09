namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>folder</summary>
    public partial class MicrosoftGraphFolder : Sample.API.Models.IMicrosoftGraphFolder
    {
        /// <summary>Backing field for <see cref="ChildCount" /> property.</summary>
        private int? _childCount;

        public int? ChildCount
        {
            get
            {
                return this._childCount;
            }
            set
            {
                this._childCount = value;
            }
        }
        /// <summary>Backing field for <see cref="View" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphFolderView _view;

        /// <summary>folderView</summary>
        public Sample.API.Models.IMicrosoftGraphFolderView View
        {
            get
            {
                return this._view;
            }
            set
            {
                this._view = value;
            }
        }
        public string ViewSortBy
        {
            get
            {
                return /*1*/View/*4*/.SortBy/*3*/;
            }
            set
            {
                /*1*/View/*4*/.SortBy/*3*/ = value;
            }
        }
        public string ViewSortOrder
        {
            get
            {
                return /*1*/View/*4*/.SortOrder/*3*/;
            }
            set
            {
                /*1*/View/*4*/.SortOrder/*3*/ = value;
            }
        }
        public string ViewType
        {
            get
            {
                return /*1*/View/*4*/.ViewType/*3*/;
            }
            set
            {
                /*1*/View/*4*/.ViewType/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphFolder" /> instance.</summary>
        public MicrosoftGraphFolder()
        {
        }
    }
    /// folder
    public partial interface IMicrosoftGraphFolder : Sample.API.Runtime.IJsonSerializable {
        int? ChildCount { get; set; }
        Sample.API.Models.IMicrosoftGraphFolderView View { get; set; }
        string ViewSortBy { get; set; }
        string ViewSortOrder { get; set; }
        string ViewType { get; set; }
    }
}