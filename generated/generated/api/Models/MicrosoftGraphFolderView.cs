namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>folderView</summary>
    public partial class MicrosoftGraphFolderView : Sample.API.Models.IMicrosoftGraphFolderView
    {
        /// <summary>Backing field for <see cref="SortBy" /> property.</summary>
        private string _sortBy;

        public string SortBy
        {
            get
            {
                return this._sortBy;
            }
            set
            {
                this._sortBy = value;
            }
        }
        /// <summary>Backing field for <see cref="SortOrder" /> property.</summary>
        private string _sortOrder;

        public string SortOrder
        {
            get
            {
                return this._sortOrder;
            }
            set
            {
                this._sortOrder = value;
            }
        }
        /// <summary>Backing field for <see cref="ViewType" /> property.</summary>
        private string _viewType;

        public string ViewType
        {
            get
            {
                return this._viewType;
            }
            set
            {
                this._viewType = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphFolderView" /> instance.</summary>
        public MicrosoftGraphFolderView()
        {
        }
    }
    /// folderView
    public partial interface IMicrosoftGraphFolderView : Sample.API.Runtime.IJsonSerializable {
        string SortBy { get; set; }
        string SortOrder { get; set; }
        string ViewType { get; set; }
    }
}