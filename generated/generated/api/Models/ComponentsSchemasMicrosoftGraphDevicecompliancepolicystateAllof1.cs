namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>Device Compliance Policy State for a given device.</summary>
    public partial class ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1
    {
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The name of the policy for this policyBase</summary>
        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="PlatformType" /> property.</summary>
        private string _platformType;

        /// <summary>policyPlatformType</summary>
        public string PlatformType
        {
            get
            {
                return this._platformType;
            }
            set
            {
                this._platformType = value;
            }
        }
        /// <summary>Backing field for <see cref="SettingCount" /> property.</summary>
        private int? _settingCount;

        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount
        {
            get
            {
                return this._settingCount;
            }
            set
            {
                this._settingCount = value;
            }
        }
        /// <summary>Backing field for <see cref="SettingStates" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState[] _settingStates;

        public Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState[] SettingStates
        {
            get
            {
                return this._settingStates;
            }
            set
            {
                this._settingStates = value;
            }
        }
        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>complianceStatus</summary>
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private int? _version;

        /// <summary>The version of the policy</summary>
        public int? Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1()
        {
        }
    }
    /// Device Compliance Policy State for a given device.
    public partial interface IComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 : Sample.API.Runtime.IJsonSerializable {
        string DisplayName { get; set; }
        string PlatformType { get; set; }
        int? SettingCount { get; set; }
        Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState[] SettingStates { get; set; }
        string State { get; set; }
        int? Version { get; set; }
    }
}