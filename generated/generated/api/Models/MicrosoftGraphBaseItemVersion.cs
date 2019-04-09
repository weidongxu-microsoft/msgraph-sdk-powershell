namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphBaseItemVersion : Sample.API.Models.IMicrosoftGraphBaseItemVersion, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphBaseItemVersion" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphBaseitemversionAllof1 _componentsSchemasMicrosoftGraphBaseitemversionAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphBaseitemversionAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphBaseItemVersion" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string ApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .ApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .ApplicationDisplayName = value;
            }
        }
        public string ApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .ApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .ApplicationId = value;
            }
        }
        public string DeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .DeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .DeviceDisplayName = value;
            }
        }
        public string DeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .DeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .DeviceId = value;
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
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedByUser = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .LastModifiedDateTime = value;
            }
        }
        /// <summary>publicationFacet</summary>
        public Sample.API.Models.IMicrosoftGraphPublicationFacet Publication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .Publication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .Publication = value;
            }
        }
        public string PublicationLevel
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .PublicationLevel;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .PublicationLevel = value;
            }
        }
        public string PublicationVersionId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .PublicationVersionId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .PublicationVersionId = value;
            }
        }
        public string UserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .UserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .UserDisplayName = value;
            }
        }
        public string UserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .UserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemversionAllof1 .UserId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphBaseItemVersion" /> instance.</summary>
        public MicrosoftGraphBaseItemVersion()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphBaseitemversionAllof1 ), _componentsSchemasMicrosoftGraphBaseitemversionAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphBaseitemversionAllof1 ), _componentsSchemasMicrosoftGraphBaseitemversionAllof1 );
        }
    }
    public partial interface IMicrosoftGraphBaseItemVersion : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphBaseitemversionAllof1 {

    }
}