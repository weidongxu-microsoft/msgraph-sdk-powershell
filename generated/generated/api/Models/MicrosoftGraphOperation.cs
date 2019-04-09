namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOperation : Sample.API.Models.IMicrosoftGraphOperation, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOperation" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOperationAllof1 _componentsSchemasMicrosoftGraphOperationAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOperationAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOperation" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOperationAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOperationAllof1 .CreatedDateTime = value;
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
        public System.DateTime? LastActionDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOperationAllof1 .LastActionDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOperationAllof1 .LastActionDateTime = value;
            }
        }
        /// <summary>operationStatus</summary>
        public string Status
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOperationAllof1 .Status;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOperationAllof1 .Status = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOperation" /> instance.</summary>
        public MicrosoftGraphOperation()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOperationAllof1 ), _componentsSchemasMicrosoftGraphOperationAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOperationAllof1 ), _componentsSchemasMicrosoftGraphOperationAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOperation : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphOperationAllof1 {

    }
}