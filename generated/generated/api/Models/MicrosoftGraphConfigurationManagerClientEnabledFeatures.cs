namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>configurationManagerClientEnabledFeatures</summary>
    public partial class MicrosoftGraphConfigurationManagerClientEnabledFeatures : Sample.API.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures
    {
        /// <summary>Backing field for <see cref="CompliancePolicy" /> property.</summary>
        private bool? _compliancePolicy;

        /// <summary>Whether compliance policy is managed by Intune</summary>
        public bool? CompliancePolicy
        {
            get
            {
                return this._compliancePolicy;
            }
            set
            {
                this._compliancePolicy = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceConfiguration" /> property.</summary>
        private bool? _deviceConfiguration;

        /// <summary>Whether device configuration is managed by Intune</summary>
        public bool? DeviceConfiguration
        {
            get
            {
                return this._deviceConfiguration;
            }
            set
            {
                this._deviceConfiguration = value;
            }
        }
        /// <summary>Backing field for <see cref="Inventory" /> property.</summary>
        private bool? _inventory;

        /// <summary>Whether inventory is managed by Intune</summary>
        public bool? Inventory
        {
            get
            {
                return this._inventory;
            }
            set
            {
                this._inventory = value;
            }
        }
        /// <summary>Backing field for <see cref="ModernApps" /> property.</summary>
        private bool? _modernApps;

        /// <summary>Whether modern application is managed by Intune</summary>
        public bool? ModernApps
        {
            get
            {
                return this._modernApps;
            }
            set
            {
                this._modernApps = value;
            }
        }
        /// <summary>Backing field for <see cref="ResourceAccess" /> property.</summary>
        private bool? _resourceAccess;

        /// <summary>Whether resource access is managed by Intune</summary>
        public bool? ResourceAccess
        {
            get
            {
                return this._resourceAccess;
            }
            set
            {
                this._resourceAccess = value;
            }
        }
        /// <summary>Backing field for <see cref="WindowsUpdateForBusiness" /> property.</summary>
        private bool? _windowsUpdateForBusiness;

        /// <summary>Whether Windows Update for Business is managed by Intune</summary>
        public bool? WindowsUpdateForBusiness
        {
            get
            {
                return this._windowsUpdateForBusiness;
            }
            set
            {
                this._windowsUpdateForBusiness = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphConfigurationManagerClientEnabledFeatures" /> instance.
        /// </summary>
        public MicrosoftGraphConfigurationManagerClientEnabledFeatures()
        {
        }
    }
    /// configurationManagerClientEnabledFeatures
    public partial interface IMicrosoftGraphConfigurationManagerClientEnabledFeatures : Sample.API.Runtime.IJsonSerializable {
        bool? CompliancePolicy { get; set; }
        bool? DeviceConfiguration { get; set; }
        bool? Inventory { get; set; }
        bool? ModernApps { get; set; }
        bool? ResourceAccess { get; set; }
        bool? WindowsUpdateForBusiness { get; set; }
    }
}