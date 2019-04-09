namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>provisionedPlan</summary>
    public partial class MicrosoftGraphProvisionedPlan : Sample.API.Models.IMicrosoftGraphProvisionedPlan
    {
        /// <summary>Backing field for <see cref="CapabilityStatus" /> property.</summary>
        private string _capabilityStatus;

        public string CapabilityStatus
        {
            get
            {
                return this._capabilityStatus;
            }
            set
            {
                this._capabilityStatus = value;
            }
        }
        /// <summary>Backing field for <see cref="ProvisioningStatus" /> property.</summary>
        private string _provisioningStatus;

        public string ProvisioningStatus
        {
            get
            {
                return this._provisioningStatus;
            }
            set
            {
                this._provisioningStatus = value;
            }
        }
        /// <summary>Backing field for <see cref="Service" /> property.</summary>
        private string _service;

        public string Service
        {
            get
            {
                return this._service;
            }
            set
            {
                this._service = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphProvisionedPlan" /> instance.</summary>
        public MicrosoftGraphProvisionedPlan()
        {
        }
    }
    /// provisionedPlan
    public partial interface IMicrosoftGraphProvisionedPlan : Sample.API.Runtime.IJsonSerializable {
        string CapabilityStatus { get; set; }
        string ProvisioningStatus { get; set; }
        string Service { get; set; }
    }
}