namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphManagedAppOperation : Sample.API.Models.IMicrosoftGraphManagedAppOperation, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedAppOperation" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappoperationAllof1 _componentsSchemasMicrosoftGraphManagedappoperationAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphManagedappoperationAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedAppOperation" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>The operation name.</summary>
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .DisplayName = value;
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
        /// <summary>The last time the app operation was modified.</summary>
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .LastModifiedDateTime = value;
            }
        }
        /// <summary>The current state of the operation</summary>
        public string State
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .State;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .State = value;
            }
        }
        /// <summary>Version of the entity.</summary>
        public string Version
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .Version;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappoperationAllof1 .Version = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphManagedAppOperation" /> instance.</summary>
        public MicrosoftGraphManagedAppOperation()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphManagedappoperationAllof1 ), _componentsSchemasMicrosoftGraphManagedappoperationAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphManagedappoperationAllof1 ), _componentsSchemasMicrosoftGraphManagedappoperationAllof1 );
        }
    }
    public partial interface IMicrosoftGraphManagedAppOperation : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappoperationAllof1 {

    }
}