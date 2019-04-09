namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>listItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphListitemAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemAllof1
    {
        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphContentTypeInfo _contentType;

        /// <summary>contentTypeInfo</summary>
        public Sample.API.Models.IMicrosoftGraphContentTypeInfo ContentType
        {
            get
            {
                return this._contentType;
            }
            set
            {
                this._contentType = value;
            }
        }
        public string ContentTypeId
        {
            get
            {
                return /*1*/ContentType/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/ContentType/*4*/.Id/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="DriveItem" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDriveItem _driveItem;

        public Sample.API.Models.IMicrosoftGraphDriveItem DriveItem
        {
            get
            {
                return this._driveItem;
            }
            set
            {
                this._driveItem = value;
            }
        }
        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphFieldValueSet _fields;

        public Sample.API.Models.IMicrosoftGraphFieldValueSet Fields
        {
            get
            {
                return this._fields;
            }
            set
            {
                this._fields = value;
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
        /// <summary>Backing field for <see cref="Versions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphListItemVersion[] _versions;

        public Sample.API.Models.IMicrosoftGraphListItemVersion[] Versions
        {
            get
            {
                return this._versions;
            }
            set
            {
                this._versions = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphListitemAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphListitemAllof1()
        {
        }
    }
    /// listItem
    public partial interface IComponentsSchemasMicrosoftGraphListitemAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphContentTypeInfo ContentType { get; set; }
        string ContentTypeId { get; set; }
        Sample.API.Models.IMicrosoftGraphDriveItem DriveItem { get; set; }
        Sample.API.Models.IMicrosoftGraphFieldValueSet Fields { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds { get; set; }
        string SharepointIdsListId { get; set; }
        string SharepointIdsListItemId { get; set; }
        string SharepointIdsListItemUniqueId { get; set; }
        string SharepointIdsSiteId { get; set; }
        string SharepointIdsSiteUrl { get; set; }
        string SharepointIdsWebId { get; set; }
        Sample.API.Models.IMicrosoftGraphListItemVersion[] Versions { get; set; }
    }
}