namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>licenseDetails</summary>
    public partial class ComponentsSchemasMicrosoftGraphLicensedetailsAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphLicensedetailsAllof1
    {
        /// <summary>Backing field for <see cref="ServicePlans" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphServicePlanInfo[] _servicePlans;

        public Sample.API.Models.IMicrosoftGraphServicePlanInfo[] ServicePlans
        {
            get
            {
                return this._servicePlans;
            }
            set
            {
                this._servicePlans = value;
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
        /// <summary>Backing field for <see cref="SkuPartNumber" /> property.</summary>
        private string _skuPartNumber;

        public string SkuPartNumber
        {
            get
            {
                return this._skuPartNumber;
            }
            set
            {
                this._skuPartNumber = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphLicensedetailsAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphLicensedetailsAllof1()
        {
        }
    }
    /// licenseDetails
    public partial interface IComponentsSchemasMicrosoftGraphLicensedetailsAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphServicePlanInfo[] ServicePlans { get; set; }
        string SkuId { get; set; }
        string SkuPartNumber { get; set; }
    }
}