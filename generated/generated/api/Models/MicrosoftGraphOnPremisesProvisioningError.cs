namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onPremisesProvisioningError</summary>
    public partial class MicrosoftGraphOnPremisesProvisioningError : Sample.API.Models.IMicrosoftGraphOnPremisesProvisioningError
    {
        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
        /// <summary>Backing field for <see cref="OccurredDateTime" /> property.</summary>
        private System.DateTime? _occurredDateTime;

        public System.DateTime? OccurredDateTime
        {
            get
            {
                return this._occurredDateTime;
            }
            set
            {
                this._occurredDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="PropertyCausingError" /> property.</summary>
        private string _propertyCausingError;

        public string PropertyCausingError
        {
            get
            {
                return this._propertyCausingError;
            }
            set
            {
                this._propertyCausingError = value;
            }
        }
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphOnPremisesProvisioningError" /> instance.
        /// </summary>
        public MicrosoftGraphOnPremisesProvisioningError()
        {
        }
    }
    /// onPremisesProvisioningError
    public partial interface IMicrosoftGraphOnPremisesProvisioningError : Sample.API.Runtime.IJsonSerializable {
        string Category { get; set; }
        System.DateTime? OccurredDateTime { get; set; }
        string PropertyCausingError { get; set; }
        string Value { get; set; }
    }
}