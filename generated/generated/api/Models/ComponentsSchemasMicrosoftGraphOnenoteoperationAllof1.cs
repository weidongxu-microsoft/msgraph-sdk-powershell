namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenoteOperation</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenoteoperationAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteoperationAllof1
    {
        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteOperationError _error;

        /// <summary>onenoteOperationError</summary>
        public Sample.API.Models.IMicrosoftGraphOnenoteOperationError Error
        {
            get
            {
                return this._error;
            }
            set
            {
                this._error = value;
            }
        }
        public string ErrorCode
        {
            get
            {
                return /*1*/Error/*4*/.Code/*3*/;
            }
            set
            {
                /*1*/Error/*4*/.Code/*3*/ = value;
            }
        }
        public string ErrorMessage
        {
            get
            {
                return /*1*/Error/*4*/.Message/*3*/;
            }
            set
            {
                /*1*/Error/*4*/.Message/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="PercentComplete" /> property.</summary>
        private string _percentComplete;

        public string PercentComplete
        {
            get
            {
                return this._percentComplete;
            }
            set
            {
                this._percentComplete = value;
            }
        }
        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        public string ResourceId
        {
            get
            {
                return this._resourceId;
            }
            set
            {
                this._resourceId = value;
            }
        }
        /// <summary>Backing field for <see cref="ResourceLocation" /> property.</summary>
        private string _resourceLocation;

        public string ResourceLocation
        {
            get
            {
                return this._resourceLocation;
            }
            set
            {
                this._resourceLocation = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenoteoperationAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenoteoperationAllof1()
        {
        }
    }
    /// onenoteOperation
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteoperationAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphOnenoteOperationError Error { get; set; }
        string ErrorCode { get; set; }
        string ErrorMessage { get; set; }
        string PercentComplete { get; set; }
        string ResourceId { get; set; }
        string ResourceLocation { get; set; }
    }
}