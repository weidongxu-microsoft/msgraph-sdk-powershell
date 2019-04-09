namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphUserActivity : Sample.API.Models.IMicrosoftGraphUserActivity, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphUserActivity" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphUseractivityAllof1 _componentsSchemasMicrosoftGraphUseractivityAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphUseractivityAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphUserActivity" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string ActivationUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .ActivationUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .ActivationUrl = value;
            }
        }
        public string ActivitySourceHost
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .ActivitySourceHost;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .ActivitySourceHost = value;
            }
        }
        public string AppActivityId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .AppActivityId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .AppActivityId = value;
            }
        }
        public string AppDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .AppDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .AppDisplayName = value;
            }
        }
        public bool? AttributionAddImageQuery
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionAddImageQuery;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionAddImageQuery = value;
            }
        }
        public string AttributionAlternateText
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionAlternateText;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionAlternateText = value;
            }
        }
        public string AttributionAlternativeText
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionAlternativeText;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionAlternativeText = value;
            }
        }
        public string AttributionIconUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionIconUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .AttributionIconUrl = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson ContentInfo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .ContentInfo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .ContentInfo = value;
            }
        }
        public string ContentUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .ContentUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .ContentUrl = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .CreatedDateTime = value;
            }
        }
        public System.DateTime? ExpirationDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .ExpirationDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .ExpirationDateTime = value;
            }
        }
        public string FallbackUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .FallbackUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .FallbackUrl = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphActivityHistoryItem[] HistoryItems
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .HistoryItems;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .HistoryItems = value;
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
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .LastModifiedDateTime = value;
            }
        }
        /// <summary>status</summary>
        public string Status
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .Status;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .Status = value;
            }
        }
        public string UserTimezone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .UserTimezone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .UserTimezone = value;
            }
        }
        /// <summary>visualInfo</summary>
        public Sample.API.Models.IMicrosoftGraphVisualInfo VisualElements
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElements;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElements = value;
            }
        }
        /// <summary>imageInfo</summary>
        public Sample.API.Models.IMicrosoftGraphImageInfo VisualElementsAttribution
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsAttribution;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsAttribution = value;
            }
        }
        public string VisualElementsBackgroundColor
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsBackgroundColor;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsBackgroundColor = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson VisualElementsContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsContent = value;
            }
        }
        public string VisualElementsDescription
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsDescription;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsDescription = value;
            }
        }
        public string VisualElementsDisplayText
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsDisplayText;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUseractivityAllof1 .VisualElementsDisplayText = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphUserActivity" /> instance.</summary>
        public MicrosoftGraphUserActivity()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphUseractivityAllof1 ), _componentsSchemasMicrosoftGraphUseractivityAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphUseractivityAllof1 ), _componentsSchemasMicrosoftGraphUseractivityAllof1 );
        }
    }
    public partial interface IMicrosoftGraphUserActivity : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphUseractivityAllof1 {

    }
}