namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenoteOperation : Sample.API.Models.IMicrosoftGraphOnenoteOperation, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteOperation" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteoperationAllof1 _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenoteoperationAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteOperation" /></summary>
        private Sample.API.Models.IMicrosoftGraphOperation _microsoftGraphOperation = new Sample.API.Models.MicrosoftGraphOperation ();
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphOperation .CreatedDateTime;
            }
            set
            {
                _microsoftGraphOperation .CreatedDateTime = value;
            }
        }
        /// <summary>onenoteOperationError</summary>
        public Sample.API.Models.IMicrosoftGraphOnenoteOperationError Error
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .Error;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .Error = value;
            }
        }
        public string ErrorCode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ErrorCode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ErrorCode = value;
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ErrorMessage;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ErrorMessage = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOperation .Id;
            }
            set
            {
                _microsoftGraphOperation .Id = value;
            }
        }
        public System.DateTime? LastActionDateTime
        {
            get
            {
                return _microsoftGraphOperation .LastActionDateTime;
            }
            set
            {
                _microsoftGraphOperation .LastActionDateTime = value;
            }
        }
        public string PercentComplete
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .PercentComplete;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .PercentComplete = value;
            }
        }
        public string ResourceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ResourceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ResourceId = value;
            }
        }
        public string ResourceLocation
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ResourceLocation;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 .ResourceLocation = value;
            }
        }
        /// <summary>operationStatus</summary>
        public string Status
        {
            get
            {
                return _microsoftGraphOperation .Status;
            }
            set
            {
                _microsoftGraphOperation .Status = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOnenoteOperation" /> instance.</summary>
        public MicrosoftGraphOnenoteOperation()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOperation ), _microsoftGraphOperation );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOperation ), _microsoftGraphOperation );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenoteoperationAllof1 ), _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenoteoperationAllof1 ), _componentsSchemasMicrosoftGraphOnenoteoperationAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenoteOperation : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOperation, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteoperationAllof1 {

    }
}