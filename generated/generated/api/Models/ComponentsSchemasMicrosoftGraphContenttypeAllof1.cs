namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>contentType</summary>
    public partial class ComponentsSchemasMicrosoftGraphContenttypeAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphContenttypeAllof1
    {
        /// <summary>Backing field for <see cref="ColumnLinks" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphColumnLink[] _columnLinks;

        public Sample.API.Models.IMicrosoftGraphColumnLink[] ColumnLinks
        {
            get
            {
                return this._columnLinks;
            }
            set
            {
                this._columnLinks = value;
            }
        }
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private string _group;

        public string Group
        {
            get
            {
                return this._group;
            }
            set
            {
                this._group = value;
            }
        }
        /// <summary>Backing field for <see cref="Hidden" /> property.</summary>
        private bool? _hidden;

        public bool? Hidden
        {
            get
            {
                return this._hidden;
            }
            set
            {
                this._hidden = value;
            }
        }
        /// <summary>Backing field for <see cref="InheritedFrom" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphItemReference _inheritedFrom;

        /// <summary>itemReference</summary>
        public Sample.API.Models.IMicrosoftGraphItemReference InheritedFrom
        {
            get
            {
                return this._inheritedFrom;
            }
            set
            {
                this._inheritedFrom = value;
            }
        }
        public string InheritedFromDriveId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.DriveId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.DriveId/*3*/ = value;
            }
        }
        public string InheritedFromDriveType
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.DriveType/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.DriveType/*3*/ = value;
            }
        }
        public string InheritedFromId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.Id/*3*/ = value;
            }
        }
        public string InheritedFromName
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.Name/*3*/ = value;
            }
        }
        public string InheritedFromPath
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.Path/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.Path/*3*/ = value;
            }
        }
        public string InheritedFromShareId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.ShareId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.ShareId/*3*/ = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds InheritedFromSharepointIds
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIds/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIds/*3*/ = value;
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
        /// <summary>Backing field for <see cref="Order" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphContentTypeOrder _order;

        /// <summary>contentTypeOrder</summary>
        public Sample.API.Models.IMicrosoftGraphContentTypeOrder Order
        {
            get
            {
                return this._order;
            }
            set
            {
                this._order = value;
            }
        }
        public bool? OrderDefault
        {
            get
            {
                return /*1*/Order/*4*/.Default/*3*/;
            }
            set
            {
                /*1*/Order/*4*/.Default/*3*/ = value;
            }
        }
        public int? OrderPosition
        {
            get
            {
                return /*1*/Order/*4*/.Position/*3*/;
            }
            set
            {
                /*1*/Order/*4*/.Position/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentId" /> property.</summary>
        private string _parentId;

        public string ParentId
        {
            get
            {
                return this._parentId;
            }
            set
            {
                this._parentId = value;
            }
        }
        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        public bool? ReadOnly
        {
            get
            {
                return this._readOnly;
            }
            set
            {
                this._readOnly = value;
            }
        }
        /// <summary>Backing field for <see cref="Sealed" /> property.</summary>
        private bool? _sealed;

        public bool? Sealed
        {
            get
            {
                return this._sealed;
            }
            set
            {
                this._sealed = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsListId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsListId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsListItemId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsListItemId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsListItemUniqueId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsListItemUniqueId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsSiteId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsSiteId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsSiteUrl/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsSiteUrl/*3*/ = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsWebId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsWebId/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphContenttypeAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphContenttypeAllof1()
        {
        }
    }
    /// contentType
    public partial interface IComponentsSchemasMicrosoftGraphContenttypeAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphColumnLink[] ColumnLinks { get; set; }
        string Description { get; set; }
        string Group { get; set; }
        bool? Hidden { get; set; }
        Sample.API.Models.IMicrosoftGraphItemReference InheritedFrom { get; set; }
        string InheritedFromDriveId { get; set; }
        string InheritedFromDriveType { get; set; }
        string InheritedFromId { get; set; }
        string InheritedFromName { get; set; }
        string InheritedFromPath { get; set; }
        string InheritedFromShareId { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds InheritedFromSharepointIds { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphContentTypeOrder Order { get; set; }
        bool? OrderDefault { get; set; }
        int? OrderPosition { get; set; }
        string ParentId { get; set; }
        bool? ReadOnly { get; set; }
        bool? Sealed { get; set; }
        string SharepointIdsListId { get; set; }
        string SharepointIdsListItemId { get; set; }
        string SharepointIdsListItemUniqueId { get; set; }
        string SharepointIdsSiteId { get; set; }
        string SharepointIdsSiteUrl { get; set; }
        string SharepointIdsWebId { get; set; }
    }
}