namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphSharedInsight : Sample.API.Models.IMicrosoftGraphSharedInsight, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphSharedInsight" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphSharedinsightAllof1 _componentsSchemasMicrosoftGraphSharedinsightAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphSharedinsightAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphSharedInsight" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
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
        /// <summary>sharingDetail</summary>
        public Sample.API.Models.IMicrosoftGraphSharingDetail LastShared
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastShared;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastShared = value;
            }
        }
        /// <summary>insightIdentity</summary>
        public Sample.API.Models.IMicrosoftGraphInsightIdentity LastSharedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedBy = value;
            }
        }
        public System.DateTime? LastSharedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedDateTime = value;
            }
        }
        /// <summary>entity</summary>
        public Sample.API.Models.IMicrosoftGraphEntity LastSharedMethod
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedMethod;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedMethod = value;
            }
        }
        public string LastSharedMethodId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedMethodId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedMethodId = value;
            }
        }
        /// <summary>resourceReference</summary>
        public Sample.API.Models.IMicrosoftGraphResourceReference LastSharedSharingReference
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedSharingReference;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedSharingReference = value;
            }
        }
        public string LastSharedSharingSubject
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedSharingSubject;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedSharingSubject = value;
            }
        }
        public string LastSharedSharingType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedSharingType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .LastSharedSharingType = value;
            }
        }
        /// <summary>entity</summary>
        public Sample.API.Models.IMicrosoftGraphEntity Resource
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .Resource;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .Resource = value;
            }
        }
        public string ResourceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceId = value;
            }
        }
        /// <summary>resourceReference</summary>
        public Sample.API.Models.IMicrosoftGraphResourceReference ResourceReference
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReference;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReference = value;
            }
        }
        public string ResourceReferenceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReferenceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReferenceId = value;
            }
        }
        public string ResourceReferenceType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReferenceType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReferenceType = value;
            }
        }
        public string ResourceReferenceWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReferenceWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceReferenceWebUrl = value;
            }
        }
        /// <summary>resourceVisualization</summary>
        public Sample.API.Models.IMicrosoftGraphResourceVisualization ResourceVisualization
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualization;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualization = value;
            }
        }
        public string ResourceVisualizationContainerDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationContainerDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationContainerDisplayName = value;
            }
        }
        public string ResourceVisualizationContainerType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationContainerType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationContainerType = value;
            }
        }
        public string ResourceVisualizationContainerWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationContainerWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationContainerWebUrl = value;
            }
        }
        public string ResourceVisualizationMediaType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationMediaType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationMediaType = value;
            }
        }
        public string ResourceVisualizationPreviewImageUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationPreviewImageUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationPreviewImageUrl = value;
            }
        }
        public string ResourceVisualizationPreviewText
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationPreviewText;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationPreviewText = value;
            }
        }
        public string ResourceVisualizationTitle
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationTitle;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationTitle = value;
            }
        }
        public string ResourceVisualizationType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .ResourceVisualizationType = value;
            }
        }
        public string SharedByAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharedByAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharedByAddress = value;
            }
        }
        public string SharedByDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharedByDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharedByDisplayName = value;
            }
        }
        public string SharedById
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharedById;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharedById = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSharingDetail[] SharingHistory
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingHistory;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingHistory = value;
            }
        }
        public string SharingReferenceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingReferenceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingReferenceId = value;
            }
        }
        public string SharingReferenceType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingReferenceType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingReferenceType = value;
            }
        }
        public string SharingReferenceWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingReferenceWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSharedinsightAllof1 .SharingReferenceWebUrl = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSharedInsight" /> instance.</summary>
        public MicrosoftGraphSharedInsight()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphSharedinsightAllof1 ), _componentsSchemasMicrosoftGraphSharedinsightAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphSharedinsightAllof1 ), _componentsSchemasMicrosoftGraphSharedinsightAllof1 );
        }
    }
    public partial interface IMicrosoftGraphSharedInsight : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphSharedinsightAllof1 {

    }
}