namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDeviceCompliancePolicyState : Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicyState, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphDeviceCompliancePolicyState" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphDeviceCompliancePolicyState" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>The name of the policy for this policyBase</summary>
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .DisplayName = value;
            }
        }
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
        /// <summary>policyPlatformType</summary>
        public string PlatformType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .PlatformType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .PlatformType = value;
            }
        }
        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .SettingCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .SettingCount = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState[] SettingStates
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .SettingStates;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .SettingStates = value;
            }
        }
        /// <summary>complianceStatus</summary>
        public string State
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .State;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .State = value;
            }
        }
        /// <summary>The version of the policy</summary>
        public int? Version
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .Version;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 .Version = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphDeviceCompliancePolicyState" /> instance.
        /// </summary>
        public MicrosoftGraphDeviceCompliancePolicyState()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 ), _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 ), _componentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDeviceCompliancePolicyState : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 {

    }
}