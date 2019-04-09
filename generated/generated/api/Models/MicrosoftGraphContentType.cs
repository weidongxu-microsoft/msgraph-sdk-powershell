namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphContentType : Sample.API.Models.IMicrosoftGraphContentType, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphContentType" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphContenttypeAllof1 _componentsSchemasMicrosoftGraphContenttypeAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphContenttypeAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphContentType" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphColumnLink[] ColumnLinks
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .ColumnLinks;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .ColumnLinks = value;
            }
        }
        public string Description
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .Description;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .Description = value;
            }
        }
        public string Group
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .Group;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .Group = value;
            }
        }
        public bool? Hidden
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .Hidden;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .Hidden = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        /// <summary>itemReference</summary>
        public Sample.API.Models.IMicrosoftGraphItemReference InheritedFrom
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFrom;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFrom = value;
            }
        }
        public string InheritedFromDriveId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromDriveId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromDriveId = value;
            }
        }
        public string InheritedFromDriveType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromDriveType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromDriveType = value;
            }
        }
        public string InheritedFromId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromId = value;
            }
        }
        public string InheritedFromName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromName = value;
            }
        }
        public string InheritedFromPath
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromPath;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromPath = value;
            }
        }
        public string InheritedFromShareId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromShareId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromShareId = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds InheritedFromSharepointIds
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromSharepointIds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .InheritedFromSharepointIds = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .Name = value;
            }
        }
        /// <summary>contentTypeOrder</summary>
        public Sample.API.Models.IMicrosoftGraphContentTypeOrder Order
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .Order;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .Order = value;
            }
        }
        public bool? OrderDefault
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .OrderDefault;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .OrderDefault = value;
            }
        }
        public int? OrderPosition
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .OrderPosition;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .OrderPosition = value;
            }
        }
        public string ParentId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .ParentId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .ParentId = value;
            }
        }
        public bool? ReadOnly
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .ReadOnly;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .ReadOnly = value;
            }
        }
        public bool? Sealed
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .Sealed;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .Sealed = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsListId = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsListItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsListItemId = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsListItemUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsListItemUniqueId = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsSiteId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsSiteId = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsSiteUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsSiteUrl = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsWebId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContenttypeAllof1 .SharepointIdsWebId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphContentType" /> instance.</summary>
        public MicrosoftGraphContentType()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphContenttypeAllof1 ), _componentsSchemasMicrosoftGraphContenttypeAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphContenttypeAllof1 ), _componentsSchemasMicrosoftGraphContenttypeAllof1 );
        }
    }
    public partial interface IMicrosoftGraphContentType : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphContenttypeAllof1 {

    }
}