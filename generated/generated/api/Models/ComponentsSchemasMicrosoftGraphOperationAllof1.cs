namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>operation</summary>
    public partial class ComponentsSchemasMicrosoftGraphOperationAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOperationAllof1
    {
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="LastActionDateTime" /> property.</summary>
        private System.DateTime? _lastActionDateTime;

        public System.DateTime? LastActionDateTime
        {
            get
            {
                return this._lastActionDateTime;
            }
            set
            {
                this._lastActionDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>operationStatus</summary>
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOperationAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOperationAllof1()
        {
        }
    }
    /// operation
    public partial interface IComponentsSchemasMicrosoftGraphOperationAllof1 : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? CreatedDateTime { get; set; }
        System.DateTime? LastActionDateTime { get; set; }
        string Status { get; set; }
    }
}