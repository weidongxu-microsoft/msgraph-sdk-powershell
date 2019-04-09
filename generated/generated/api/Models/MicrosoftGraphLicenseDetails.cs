namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphLicenseDetails : Sample.API.Models.IMicrosoftGraphLicenseDetails, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphLicenseDetails" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphLicensedetailsAllof1 _componentsSchemasMicrosoftGraphLicensedetailsAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphLicensedetailsAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphLicenseDetails" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
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
        public Sample.API.Models.IMicrosoftGraphServicePlanInfo[] ServicePlans
        {
            get
            {
                return _componentsSchemasMicrosoftGraphLicensedetailsAllof1 .ServicePlans;
            }
            set
            {
                _componentsSchemasMicrosoftGraphLicensedetailsAllof1 .ServicePlans = value;
            }
        }
        public string SkuId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphLicensedetailsAllof1 .SkuId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphLicensedetailsAllof1 .SkuId = value;
            }
        }
        public string SkuPartNumber
        {
            get
            {
                return _componentsSchemasMicrosoftGraphLicensedetailsAllof1 .SkuPartNumber;
            }
            set
            {
                _componentsSchemasMicrosoftGraphLicensedetailsAllof1 .SkuPartNumber = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphLicenseDetails" /> instance.</summary>
        public MicrosoftGraphLicenseDetails()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphLicensedetailsAllof1 ), _componentsSchemasMicrosoftGraphLicensedetailsAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphLicensedetailsAllof1 ), _componentsSchemasMicrosoftGraphLicensedetailsAllof1 );
        }
    }
    public partial interface IMicrosoftGraphLicenseDetails : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphLicensedetailsAllof1 {

    }
}