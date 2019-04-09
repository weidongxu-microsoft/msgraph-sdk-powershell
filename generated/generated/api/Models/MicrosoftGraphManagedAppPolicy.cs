namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphManagedAppPolicy : Sample.API.Models.IMicrosoftGraphManagedAppPolicy, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedAppPolicy" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedapppolicyAllof1 _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphManagedapppolicyAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedAppPolicy" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>The date and time the policy was created.</summary>
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .CreatedDateTime = value;
            }
        }
        /// <summary>The policy's description.</summary>
        public string Description
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .Description;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .Description = value;
            }
        }
        /// <summary>Policy display name.</summary>
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .DisplayName = value;
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
        /// <summary>Last time the policy was modified.</summary>
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .LastModifiedDateTime = value;
            }
        }
        /// <summary>Version of the entity.</summary>
        public string Version
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .Version;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 .Version = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphManagedAppPolicy" /> instance.</summary>
        public MicrosoftGraphManagedAppPolicy()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphManagedapppolicyAllof1 ), _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphManagedapppolicyAllof1 ), _componentsSchemasMicrosoftGraphManagedapppolicyAllof1 );
        }
    }
    public partial interface IMicrosoftGraphManagedAppPolicy : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedapppolicyAllof1 {

    }
}