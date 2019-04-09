namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDeviceConfigurationState : Sample.API.Models.IMicrosoftGraphDeviceConfigurationState, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphDeviceConfigurationState" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphDeviceConfigurationState" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>The name of the policy for this policyBase</summary>
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .DisplayName = value;
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
                return _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .PlatformType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .PlatformType = value;
            }
        }
        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .SettingCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .SettingCount = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDeviceConfigurationSettingState[] SettingStates
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .SettingStates;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .SettingStates = value;
            }
        }
        /// <summary>complianceStatus</summary>
        public string State
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .State;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .State = value;
            }
        }
        /// <summary>The version of the policy</summary>
        public int? Version
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .Version;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 .Version = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDeviceConfigurationState" /> instance.</summary>
        public MicrosoftGraphDeviceConfigurationState()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 ), _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 ), _componentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDeviceConfigurationState : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 {

    }
}