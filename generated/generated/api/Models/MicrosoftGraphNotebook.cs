namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphNotebook : Sample.API.Models.IMicrosoftGraphNotebook, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphNotebook" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphNotebookAllof1 _componentsSchemasMicrosoftGraphNotebookAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphNotebookAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphNotebook" /></summary>
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
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .IsDefault;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .IsDefault = value;
            }
        }
        public bool? IsShared
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .IsShared;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .IsShared = value;
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
        /// <summary>notebookLinks</summary>
        public Sample.API.Models.IMicrosoftGraphNotebookLinks Links
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .Links;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .Links = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteClientUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .LinksOneNoteClientUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .LinksOneNoteClientUrl = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .LinksOneNoteWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .LinksOneNoteWebUrl = value;
            }
        }
        public string OneNoteClientUrlHref
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .OneNoteClientUrlHref;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .OneNoteClientUrlHref = value;
            }
        }
        public string OneNoteWebUrlHref
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .OneNoteWebUrlHref;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .OneNoteWebUrlHref = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSectionGroup[] SectionGroups
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .SectionGroups;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .SectionGroups = value;
            }
        }
        public string SectionGroupsUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .SectionGroupsUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .SectionGroupsUrl = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenoteSection[] Sections
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .Sections;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .Sections = value;
            }
        }
        public string SectionsUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .SectionsUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .SectionsUrl = value;
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
        /// <summary>onenoteUserRole</summary>
        public string UserRole
        {
            get
            {
                return _componentsSchemasMicrosoftGraphNotebookAllof1 .UserRole;
            }
            set
            {
                _componentsSchemasMicrosoftGraphNotebookAllof1 .UserRole = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphNotebook" /> instance.</summary>
        public MicrosoftGraphNotebook()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphNotebookAllof1 ), _componentsSchemasMicrosoftGraphNotebookAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphNotebookAllof1 ), _componentsSchemasMicrosoftGraphNotebookAllof1 );
        }
    }
    public partial interface IMicrosoftGraphNotebook : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOnenoteEntityHierarchyModel, Sample.API.Models.IComponentsSchemasMicrosoftGraphNotebookAllof1 {

    }
}