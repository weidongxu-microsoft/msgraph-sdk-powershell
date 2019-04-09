namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>deviceCompliancePolicySettingState</summary>
    public partial class MicrosoftGraphDeviceCompliancePolicySettingState : Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState
    {
        /// <summary>Backing field for <see cref="CurrentValue" /> property.</summary>
        private string _currentValue;

        /// <summary>Current value of setting on device</summary>
        public string CurrentValue
        {
            get
            {
                return this._currentValue;
            }
            set
            {
                this._currentValue = value;
            }
        }
        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private long? _errorCode;

        /// <summary>Error code for the setting</summary>
        public long? ErrorCode
        {
            get
            {
                return this._errorCode;
            }
            set
            {
                this._errorCode = value;
            }
        }
        /// <summary>Backing field for <see cref="ErrorDescription" /> property.</summary>
        private string _errorDescription;

        /// <summary>Error description</summary>
        public string ErrorDescription
        {
            get
            {
                return this._errorDescription;
            }
            set
            {
                this._errorDescription = value;
            }
        }
        /// <summary>Backing field for <see cref="InstanceDisplayName" /> property.</summary>
        private string _instanceDisplayName;

        /// <summary>Name of setting instance that is being reported.</summary>
        public string InstanceDisplayName
        {
            get
            {
                return this._instanceDisplayName;
            }
            set
            {
                this._instanceDisplayName = value;
            }
        }
        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private string _setting;

        /// <summary>The setting that is being reported</summary>
        public string Setting
        {
            get
            {
                return this._setting;
            }
            set
            {
                this._setting = value;
            }
        }
        /// <summary>Backing field for <see cref="SettingName" /> property.</summary>
        private string _settingName;

        /// <summary>Localized/user friendly setting name that is being reported</summary>
        public string SettingName
        {
            get
            {
                return this._settingName;
            }
            set
            {
                this._settingName = value;
            }
        }
        /// <summary>Backing field for <see cref="Sources" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSettingSource[] _sources;

        /// <summary>Contributing policies</summary>
        public Sample.API.Models.IMicrosoftGraphSettingSource[] Sources
        {
            get
            {
                return this._sources;
            }
            set
            {
                this._sources = value;
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
        /// <summary>Backing field for <see cref="UserEmail" /> property.</summary>
        private string _userEmail;

        /// <summary>UserEmail</summary>
        public string UserEmail
        {
            get
            {
                return this._userEmail;
            }
            set
            {
                this._userEmail = value;
            }
        }
        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>UserId</summary>
        public string UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this._userId = value;
            }
        }
        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>UserName</summary>
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }
        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName
        {
            get
            {
                return this._userPrincipalName;
            }
            set
            {
                this._userPrincipalName = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphDeviceCompliancePolicySettingState" /> instance.
        /// </summary>
        public MicrosoftGraphDeviceCompliancePolicySettingState()
        {
        }
    }
    /// deviceCompliancePolicySettingState
    public partial interface IMicrosoftGraphDeviceCompliancePolicySettingState : Sample.API.Runtime.IJsonSerializable {
        string CurrentValue { get; set; }
        long? ErrorCode { get; set; }
        string ErrorDescription { get; set; }
        string InstanceDisplayName { get; set; }
        string Setting { get; set; }
        string SettingName { get; set; }
        Sample.API.Models.IMicrosoftGraphSettingSource[] Sources { get; set; }
        string State { get; set; }
        string UserEmail { get; set; }
        string UserId { get; set; }
        string UserName { get; set; }
        string UserPrincipalName { get; set; }
    }
}