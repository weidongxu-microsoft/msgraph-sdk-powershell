namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharepointIds</summary>
    public partial class MicrosoftGraphSharepointIds : Sample.API.Models.IMicrosoftGraphSharepointIds
    {
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
        /// <summary>Backing field for <see cref="ListItemId" /> property.</summary>
        private string _listItemId;

        public string ListItemId
        {
            get
            {
                return this._listItemId;
            }
            set
            {
                this._listItemId = value;
            }
        }
        /// <summary>Backing field for <see cref="ListItemUniqueId" /> property.</summary>
        private string _listItemUniqueId;

        public string ListItemUniqueId
        {
            get
            {
                return this._listItemUniqueId;
            }
            set
            {
                this._listItemUniqueId = value;
            }
        }
        /// <summary>Backing field for <see cref="SiteId" /> property.</summary>
        private string _siteId;

        public string SiteId
        {
            get
            {
                return this._siteId;
            }
            set
            {
                this._siteId = value;
            }
        }
        /// <summary>Backing field for <see cref="SiteUrl" /> property.</summary>
        private string _siteUrl;

        public string SiteUrl
        {
            get
            {
                return this._siteUrl;
            }
            set
            {
                this._siteUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="WebId" /> property.</summary>
        private string _webId;

        public string WebId
        {
            get
            {
                return this._webId;
            }
            set
            {
                this._webId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSharepointIds" /> instance.</summary>
        public MicrosoftGraphSharepointIds()
        {
        }
    }
    /// sharepointIds
    public partial interface IMicrosoftGraphSharepointIds : Sample.API.Runtime.IJsonSerializable {
        string ListId { get; set; }
        string ListItemId { get; set; }
        string ListItemUniqueId { get; set; }
        string SiteId { get; set; }
        string SiteUrl { get; set; }
        string WebId { get; set; }
    }
}