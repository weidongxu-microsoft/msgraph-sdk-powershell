namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphUsedInsight : Sample.API.Models.IMicrosoftGraphUsedInsight, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphUsedInsight" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphUsedinsightAllof1 _componentsSchemasMicrosoftGraphUsedinsightAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphUsedinsightAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphUsedInsight" /></summary>
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
        /// <summary>usageDetails</summary>
        public Sample.API.Models.IMicrosoftGraphUsageDetails LastUsed
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .LastUsed;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .LastUsed = value;
            }
        }
        public System.DateTime? LastUsedLastAccessedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .LastUsedLastAccessedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .LastUsedLastAccessedDateTime = value;
            }
        }
        public System.DateTime? LastUsedLastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .LastUsedLastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .LastUsedLastModifiedDateTime = value;
            }
        }
        /// <summary>entity</summary>
        public Sample.API.Models.IMicrosoftGraphEntity Resource
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .Resource;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .Resource = value;
            }
        }
        public string ResourceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceId = value;
            }
        }
        /// <summary>resourceReference</summary>
        public Sample.API.Models.IMicrosoftGraphResourceReference ResourceReference
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReference;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReference = value;
            }
        }
        public string ResourceReferenceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReferenceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReferenceId = value;
            }
        }
        public string ResourceReferenceType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReferenceType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReferenceType = value;
            }
        }
        public string ResourceReferenceWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReferenceWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceReferenceWebUrl = value;
            }
        }
        /// <summary>resourceVisualization</summary>
        public Sample.API.Models.IMicrosoftGraphResourceVisualization ResourceVisualization
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualization;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualization = value;
            }
        }
        public string ResourceVisualizationContainerDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationContainerDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationContainerDisplayName = value;
            }
        }
        public string ResourceVisualizationContainerType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationContainerType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationContainerType = value;
            }
        }
        public string ResourceVisualizationContainerWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationContainerWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationContainerWebUrl = value;
            }
        }
        public string ResourceVisualizationMediaType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationMediaType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationMediaType = value;
            }
        }
        public string ResourceVisualizationPreviewImageUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationPreviewImageUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationPreviewImageUrl = value;
            }
        }
        public string ResourceVisualizationPreviewText
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationPreviewText;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationPreviewText = value;
            }
        }
        public string ResourceVisualizationTitle
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationTitle;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationTitle = value;
            }
        }
        public string ResourceVisualizationType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsedinsightAllof1 .ResourceVisualizationType = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphUsedInsight" /> instance.</summary>
        public MicrosoftGraphUsedInsight()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphUsedinsightAllof1 ), _componentsSchemasMicrosoftGraphUsedinsightAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphUsedinsightAllof1 ), _componentsSchemasMicrosoftGraphUsedinsightAllof1 );
        }
    }
    public partial interface IMicrosoftGraphUsedInsight : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphUsedinsightAllof1 {

    }
}