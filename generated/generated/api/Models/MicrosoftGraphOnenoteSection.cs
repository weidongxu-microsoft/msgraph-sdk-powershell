namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenoteSection : Sample.API.Models.IMicrosoftGraphOnenoteSection, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteSection" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotesectionAllof1 _componentsSchemasMicrosoftGraphOnenotesectionAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenotesectionAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteSection" /></summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteEntityHierarchyModel _microsoftGraphOnenoteEntityHierarchyModel = new Sample.API.Models.MicrosoftGraphOnenoteEntityHierarchyModel ();
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .ApplicationDisplayNameApplicationDisplayName;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .ApplicationDisplayNameApplicationDisplayName = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .ApplicationIdApplicationId;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .ApplicationIdApplicationId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .CreatedBy;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .CreatedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .CreatedByApplication;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .CreatedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .CreatedByDevice;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .CreatedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .CreatedByUser;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .CreatedByUser = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .CreatedDateTime;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .CreatedDateTime = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .DeviceDisplayNameDeviceDisplayName;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .DeviceDisplayNameDeviceDisplayName = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .DeviceIdDeviceId;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .DeviceIdDeviceId = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .DisplayName;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .DisplayName = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .DisplayNameApplicationDisplayName;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .DisplayNameApplicationDisplayName = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .DisplayNameDeviceDisplayName;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .DisplayNameDeviceDisplayName = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .DisplayNameUserDisplayName;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .DisplayNameUserDisplayName = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .Id;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .Id = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .IdApplicationId;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .IdApplicationId = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .IdDeviceId;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .IdDeviceId = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .IdUserId;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .IdUserId = value;
            }
        }
        public bool? IsDefault
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .IsDefault;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .IsDefault = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedBy;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedByApplication;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedByDevice;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedByUser;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedByUser = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedDateTime;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .LastModifiedDateTime = value;
            }
        }
        /// <summary>sectionLinks</summary>
        public Sample.API.Models.IMicrosoftGraphSectionLinks Links
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .Links;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .Links = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteClientUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .LinksOneNoteClientUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .LinksOneNoteClientUrl = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .LinksOneNoteWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .LinksOneNoteWebUrl = value;
            }
        }
        public string OneNoteClientUrlHref
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .OneNoteClientUrlHref;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .OneNoteClientUrlHref = value;
            }
        }
        public string OneNoteWebUrlHref
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .OneNoteWebUrlHref;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .OneNoteWebUrlHref = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenotePage[] Pages
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .Pages;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .Pages = value;
            }
        }
        public string PagesUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .PagesUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .PagesUrl = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphNotebook ParentNotebook
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .ParentNotebook;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .ParentNotebook = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSectionGroup ParentSectionGroup
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .ParentSectionGroup;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotesectionAllof1 .ParentSectionGroup = value;
            }
        }
        public string Self
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .Self;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .Self = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .UserDisplayNameUserDisplayName;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .UserDisplayNameUserDisplayName = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return _microsoftGraphOnenoteEntityHierarchyModel .UserIdUserId;
            }
            set
            {
                _microsoftGraphOnenoteEntityHierarchyModel .UserIdUserId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOnenoteSection" /> instance.</summary>
        public MicrosoftGraphOnenoteSection()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOnenoteEntityHierarchyModel ), _microsoftGraphOnenoteEntityHierarchyModel );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOnenoteEntityHierarchyModel ), _microsoftGraphOnenoteEntityHierarchyModel );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenotesectionAllof1 ), _componentsSchemasMicrosoftGraphOnenotesectionAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenotesectionAllof1 ), _componentsSchemasMicrosoftGraphOnenotesectionAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenoteSection : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOnenoteEntityHierarchyModel, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotesectionAllof1 {

    }
}