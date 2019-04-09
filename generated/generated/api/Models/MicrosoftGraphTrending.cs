namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphTrending : Sample.API.Models.IMicrosoftGraphTrending, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphTrending" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphTrendingAllof1 _componentsSchemasMicrosoftGraphTrendingAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphTrendingAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphTrending" /></summary>
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
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .LastModifiedDateTime = value;
            }
        }
        /// <summary>entity</summary>
        public Sample.API.Models.IMicrosoftGraphEntity Resource
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .Resource;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .Resource = value;
            }
        }
        public string ResourceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceId = value;
            }
        }
        /// <summary>resourceReference</summary>
        public Sample.API.Models.IMicrosoftGraphResourceReference ResourceReference
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReference;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReference = value;
            }
        }
        public string ResourceReferenceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReferenceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReferenceId = value;
            }
        }
        public string ResourceReferenceType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReferenceType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReferenceType = value;
            }
        }
        public string ResourceReferenceWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReferenceWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceReferenceWebUrl = value;
            }
        }
        /// <summary>resourceVisualization</summary>
        public Sample.API.Models.IMicrosoftGraphResourceVisualization ResourceVisualization
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualization;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualization = value;
            }
        }
        public string ResourceVisualizationContainerDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationContainerDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationContainerDisplayName = value;
            }
        }
        public string ResourceVisualizationContainerType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationContainerType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationContainerType = value;
            }
        }
        public string ResourceVisualizationContainerWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationContainerWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationContainerWebUrl = value;
            }
        }
        public string ResourceVisualizationMediaType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationMediaType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationMediaType = value;
            }
        }
        public string ResourceVisualizationPreviewImageUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationPreviewImageUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationPreviewImageUrl = value;
            }
        }
        public string ResourceVisualizationPreviewText
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationPreviewText;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationPreviewText = value;
            }
        }
        public string ResourceVisualizationTitle
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationTitle;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationTitle = value;
            }
        }
        public string ResourceVisualizationType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .ResourceVisualizationType = value;
            }
        }
        public double? Weight
        {
            get
            {
                return _componentsSchemasMicrosoftGraphTrendingAllof1 .Weight;
            }
            set
            {
                _componentsSchemasMicrosoftGraphTrendingAllof1 .Weight = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphTrending" /> instance.</summary>
        public MicrosoftGraphTrending()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphTrendingAllof1 ), _componentsSchemasMicrosoftGraphTrendingAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphTrendingAllof1 ), _componentsSchemasMicrosoftGraphTrendingAllof1 );
        }
    }
    public partial interface IMicrosoftGraphTrending : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphTrendingAllof1 {

    }
}