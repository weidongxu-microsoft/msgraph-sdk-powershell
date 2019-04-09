namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>list</summary>
    public partial class ComponentsSchemasMicrosoftGraphListAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphListAllof1
    {
        /// <summary>Backing field for <see cref="Columns" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphColumnDefinition[] _columns;

        public Sample.API.Models.IMicrosoftGraphColumnDefinition[] Columns
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
        /// <summary>Backing field for <see cref="ContentTypes" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphContentType[] _contentTypes;

        public Sample.API.Models.IMicrosoftGraphContentType[] ContentTypes
        {
            get
            {
                return this._contentTypes;
            }
            set
            {
                this._contentTypes = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="Drive" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDrive _drive;

        public Sample.API.Models.IMicrosoftGraphDrive Drive
        {
            get
            {
                return this._drive;
            }
            set
            {
                this._drive = value;
            }
        }
        /// <summary>Backing field for <see cref="Items" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphListItem[] _items;

        public Sample.API.Models.IMicrosoftGraphListItem[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        /// <summary>Backing field for <see cref="List" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphListInfo _list;

        /// <summary>listInfo</summary>
        public Sample.API.Models.IMicrosoftGraphListInfo List
        {
            get
            {
                return this._list;
            }
            set
            {
                this._list = value;
            }
        }
        public bool? ListContentTypesEnabled
        {
            get
            {
                return /*1*/List/*4*/.ContentTypesEnabled/*3*/;
            }
            set
            {
                /*1*/List/*4*/.ContentTypesEnabled/*3*/ = value;
            }
        }
        public bool? ListHidden
        {
            get
            {
                return /*1*/List/*4*/.Hidden/*3*/;
            }
            set
            {
                /*1*/List/*4*/.Hidden/*3*/ = value;
            }
        }
        public string ListTemplate
        {
            get
            {
                return /*1*/List/*4*/.Template/*3*/;
            }
            set
            {
                /*1*/List/*4*/.Template/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SharepointIds" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharepointIds _sharepointIds;

        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds
        {
            get
            {
                return this._sharepointIds;
            }
            set
            {
                this._sharepointIds = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.ListId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.ListId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.ListItemId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.ListItemId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.ListItemUniqueId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.ListItemUniqueId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.SiteId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.SiteId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return /*1*/SharepointIds/*4*/.SiteUrl/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.SiteUrl/*3*/ = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.WebId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.WebId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="System" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSystemFacet _system;

        /// <summary>systemFacet</summary>
        public Sample.API.Models.IMicrosoftGraphSystemFacet System
        {
            get
            {
                return this._system;
            }
            set
            {
                this._system = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphListAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphListAllof1()
        {
        }
    }
    /// list
    public partial interface IComponentsSchemasMicrosoftGraphListAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphColumnDefinition[] Columns { get; set; }
        Sample.API.Models.IMicrosoftGraphContentType[] ContentTypes { get; set; }
        string DisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphDrive Drive { get; set; }
        Sample.API.Models.IMicrosoftGraphListItem[] Items { get; set; }
        Sample.API.Models.IMicrosoftGraphListInfo List { get; set; }
        bool? ListContentTypesEnabled { get; set; }
        bool? ListHidden { get; set; }
        string ListTemplate { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds { get; set; }
        string SharepointIdsListId { get; set; }
        string SharepointIdsListItemId { get; set; }
        string SharepointIdsListItemUniqueId { get; set; }
        string SharepointIdsSiteId { get; set; }
        string SharepointIdsSiteUrl { get; set; }
        string SharepointIdsWebId { get; set; }
        Sample.API.Models.IMicrosoftGraphSystemFacet System { get; set; }
    }
}