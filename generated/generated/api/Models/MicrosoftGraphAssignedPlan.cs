namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>assignedPlan</summary>
    public partial class MicrosoftGraphAssignedPlan : Sample.API.Models.IMicrosoftGraphAssignedPlan
    {
        /// <summary>Backing field for <see cref="AssignedDateTime" /> property.</summary>
        private System.DateTime? _assignedDateTime;

        public System.DateTime? AssignedDateTime
        {
            get
            {
                return this._assignedDateTime;
            }
            set
            {
                this._assignedDateTime = value;
            }
        }
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
        /// <summary>Backing field for <see cref="ServicePlanId" /> property.</summary>
        private string _servicePlanId;

        public string ServicePlanId
        {
            get
            {
                return this._servicePlanId;
            }
            set
            {
                this._servicePlanId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphAssignedPlan" /> instance.</summary>
        public MicrosoftGraphAssignedPlan()
        {
        }
    }
    /// assignedPlan
    public partial interface IMicrosoftGraphAssignedPlan : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? AssignedDateTime { get; set; }
        string CapabilityStatus { get; set; }
        string Service { get; set; }
        string ServicePlanId { get; set; }
    }
}