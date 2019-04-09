namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDriveItemVersion : Sample.API.Models.IMicrosoftGraphDriveItemVersion, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphDriveItemVersion" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemversionAllof1 _componentsSchemasMicrosoftGraphDriveitemversionAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDriveitemversionAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphDriveItemVersion" /></summary>
        private Sample.API.Models.IMicrosoftGraphBaseItemVersion _microsoftGraphBaseItemVersion = new Sample.API.Models.MicrosoftGraphBaseItemVersion ();
        public string ApplicationDisplayName
        {
            get
            {
                return _microsoftGraphBaseItemVersion .ApplicationDisplayName;
            }
            set
            {
                _microsoftGraphBaseItemVersion .ApplicationDisplayName = value;
            }
        }
        public string ApplicationId
        {
            get
            {
                return _microsoftGraphBaseItemVersion .ApplicationId;
            }
            set
            {
                _microsoftGraphBaseItemVersion .ApplicationId = value;
            }
        }
        public byte[] Content
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemversionAllof1 .Content;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemversionAllof1 .Content = value;
            }
        }
        public string DeviceDisplayName
        {
            get
            {
                return _microsoftGraphBaseItemVersion .DeviceDisplayName;
            }
            set
            {
                _microsoftGraphBaseItemVersion .DeviceDisplayName = value;
            }
        }
        public string DeviceId
        {
            get
            {
                return _microsoftGraphBaseItemVersion .DeviceId;
            }
            set
            {
                _microsoftGraphBaseItemVersion .DeviceId = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphBaseItemVersion .Id;
            }
            set
            {
                _microsoftGraphBaseItemVersion .Id = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return _microsoftGraphBaseItemVersion .LastModifiedBy;
            }
            set
            {
                _microsoftGraphBaseItemVersion .LastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return _microsoftGraphBaseItemVersion .LastModifiedByApplication;
            }
            set
            {
                _microsoftGraphBaseItemVersion .LastModifiedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return _microsoftGraphBaseItemVersion .LastModifiedByDevice;
            }
            set
            {
                _microsoftGraphBaseItemVersion .LastModifiedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser
        {
            get
            {
                return _microsoftGraphBaseItemVersion .LastModifiedByUser;
            }
            set
            {
                _microsoftGraphBaseItemVersion .LastModifiedByUser = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _microsoftGraphBaseItemVersion .LastModifiedDateTime;
            }
            set
            {
                _microsoftGraphBaseItemVersion .LastModifiedDateTime = value;
            }
        }
        /// <summary>publicationFacet</summary>
        public Sample.API.Models.IMicrosoftGraphPublicationFacet Publication
        {
            get
            {
                return _microsoftGraphBaseItemVersion .Publication;
            }
            set
            {
                _microsoftGraphBaseItemVersion .Publication = value;
            }
        }
        public string PublicationLevel
        {
            get
            {
                return _microsoftGraphBaseItemVersion .PublicationLevel;
            }
            set
            {
                _microsoftGraphBaseItemVersion .PublicationLevel = value;
            }
        }
        public string PublicationVersionId
        {
            get
            {
                return _microsoftGraphBaseItemVersion .PublicationVersionId;
            }
            set
            {
                _microsoftGraphBaseItemVersion .PublicationVersionId = value;
            }
        }
        public long? Size
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemversionAllof1 .Size;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemversionAllof1 .Size = value;
            }
        }
        public string UserDisplayName
        {
            get
            {
                return _microsoftGraphBaseItemVersion .UserDisplayName;
            }
            set
            {
                _microsoftGraphBaseItemVersion .UserDisplayName = value;
            }
        }
        public string UserId
        {
            get
            {
                return _microsoftGraphBaseItemVersion .UserId;
            }
            set
            {
                _microsoftGraphBaseItemVersion .UserId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDriveItemVersion" /> instance.</summary>
        public MicrosoftGraphDriveItemVersion()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphBaseItemVersion ), _microsoftGraphBaseItemVersion );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphBaseItemVersion ), _microsoftGraphBaseItemVersion );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDriveitemversionAllof1 ), _componentsSchemasMicrosoftGraphDriveitemversionAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDriveitemversionAllof1 ), _componentsSchemasMicrosoftGraphDriveitemversionAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDriveItemVersion : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphBaseItemVersion, Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemversionAllof1 {

    }
}