namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphListItemVersion : Sample.API.Models.IMicrosoftGraphListItemVersion, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphListItemVersion" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemversionAllof1 _componentsSchemasMicrosoftGraphListitemversionAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphListitemversionAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphListItemVersion" /></summary>
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
        public Sample.API.Models.IMicrosoftGraphFieldValueSet Fields
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemversionAllof1 .Fields;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemversionAllof1 .Fields = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphListItemVersion" /> instance.</summary>
        public MicrosoftGraphListItemVersion()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphListitemversionAllof1 ), _componentsSchemasMicrosoftGraphListitemversionAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphListitemversionAllof1 ), _componentsSchemasMicrosoftGraphListitemversionAllof1 );
        }
    }
    public partial interface IMicrosoftGraphListItemVersion : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphBaseItemVersion, Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemversionAllof1 {

    }
}