namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>servicePlanInfo</summary>
    public partial class MicrosoftGraphServicePlanInfo : Sample.API.Models.IMicrosoftGraphServicePlanInfo
    {
        /// <summary>Backing field for <see cref="AppliesTo" /> property.</summary>
        private string _appliesTo;

        public string AppliesTo
        {
            get
            {
                return this._appliesTo;
            }
            set
            {
                this._appliesTo = value;
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
        /// <summary>Backing field for <see cref="ServicePlanName" /> property.</summary>
        private string _servicePlanName;

        public string ServicePlanName
        {
            get
            {
                return this._servicePlanName;
            }
            set
            {
                this._servicePlanName = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphServicePlanInfo" /> instance.</summary>
        public MicrosoftGraphServicePlanInfo()
        {
        }
    }
    /// servicePlanInfo
    public partial interface IMicrosoftGraphServicePlanInfo : Sample.API.Runtime.IJsonSerializable {
        string AppliesTo { get; set; }
        string ProvisioningStatus { get; set; }
        string ServicePlanId { get; set; }
        string ServicePlanName { get; set; }
    }
}