namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>assignedLicense</summary>
    public partial class MicrosoftGraphAssignedLicense : Sample.API.Models.IMicrosoftGraphAssignedLicense
    {
        /// <summary>Backing field for <see cref="DisabledPlans" /> property.</summary>
        private string[] _disabledPlans;

        public string[] DisabledPlans
        {
            get
            {
                return this._disabledPlans;
            }
            set
            {
                this._disabledPlans = value;
            }
        }
        /// <summary>Backing field for <see cref="SkuId" /> property.</summary>
        private string _skuId;

        public string SkuId
        {
            get
            {
                return this._skuId;
            }
            set
            {
                this._skuId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphAssignedLicense" /> instance.</summary>
        public MicrosoftGraphAssignedLicense()
        {
        }
    }
    /// assignedLicense
    public partial interface IMicrosoftGraphAssignedLicense : Sample.API.Runtime.IJsonSerializable {
        string[] DisabledPlans { get; set; }
        string SkuId { get; set; }
    }
}