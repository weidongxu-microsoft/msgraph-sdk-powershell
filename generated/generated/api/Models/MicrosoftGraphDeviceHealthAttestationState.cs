namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>deviceHealthAttestationState</summary>
    public partial class MicrosoftGraphDeviceHealthAttestationState : Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState
    {
        /// <summary>Backing field for <see cref="AttestationIdentityKey" /> property.</summary>
        private string _attestationIdentityKey;

        /// <summary>
        /// TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK)
        /// certificate.
        /// </summary>
        public string AttestationIdentityKey
        {
            get
            {
                return this._attestationIdentityKey;
            }
            set
            {
                this._attestationIdentityKey = value;
            }
        }
        /// <summary>Backing field for <see cref="BitLockerStatus" /> property.</summary>
        private string _bitLockerStatus;

        /// <summary>On or Off of BitLocker Drive Encryption</summary>
        public string BitLockerStatus
        {
            get
            {
                return this._bitLockerStatus;
            }
            set
            {
                this._bitLockerStatus = value;
            }
        }
        /// <summary>Backing field for <see cref="BootAppSecurityVersion" /> property.</summary>
        private string _bootAppSecurityVersion;

        /// <summary>The security version number of the Boot Application</summary>
        public string BootAppSecurityVersion
        {
            get
            {
                return this._bootAppSecurityVersion;
            }
            set
            {
                this._bootAppSecurityVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="BootDebugging" /> property.</summary>
        private string _bootDebugging;

        /// <summary>When bootDebugging is enabled, the device is used in development and testing</summary>
        public string BootDebugging
        {
            get
            {
                return this._bootDebugging;
            }
            set
            {
                this._bootDebugging = value;
            }
        }
        /// <summary>Backing field for <see cref="BootManagerSecurityVersion" /> property.</summary>
        private string _bootManagerSecurityVersion;

        /// <summary>The security version number of the Boot Application</summary>
        public string BootManagerSecurityVersion
        {
            get
            {
                return this._bootManagerSecurityVersion;
            }
            set
            {
                this._bootManagerSecurityVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="BootManagerVersion" /> property.</summary>
        private string _bootManagerVersion;

        /// <summary>The version of the Boot Manager</summary>
        public string BootManagerVersion
        {
            get
            {
                return this._bootManagerVersion;
            }
            set
            {
                this._bootManagerVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="BootRevisionListInfo" /> property.</summary>
        private string _bootRevisionListInfo;

        /// <summary>
        /// The Boot Revision List that was loaded during initial boot on the attested device
        /// </summary>
        public string BootRevisionListInfo
        {
            get
            {
                return this._bootRevisionListInfo;
            }
            set
            {
                this._bootRevisionListInfo = value;
            }
        }
        /// <summary>Backing field for <see cref="CodeIntegrity" /> property.</summary>
        private string _codeIntegrity;

        /// <summary>
        /// When code integrity is enabled, code execution is restricted to integrity verified code
        /// </summary>
        public string CodeIntegrity
        {
            get
            {
                return this._codeIntegrity;
            }
            set
            {
                this._codeIntegrity = value;
            }
        }
        /// <summary>Backing field for <see cref="CodeIntegrityCheckVersion" /> property.</summary>
        private string _codeIntegrityCheckVersion;

        /// <summary>The version of the Boot Manager</summary>
        public string CodeIntegrityCheckVersion
        {
            get
            {
                return this._codeIntegrityCheckVersion;
            }
            set
            {
                this._codeIntegrityCheckVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="CodeIntegrityPolicy" /> property.</summary>
        private string _codeIntegrityPolicy;

        /// <summary>
        /// The Code Integrity policy that is controlling the security of the boot environment
        /// </summary>
        public string CodeIntegrityPolicy
        {
            get
            {
                return this._codeIntegrityPolicy;
            }
            set
            {
                this._codeIntegrityPolicy = value;
            }
        }
        /// <summary>Backing field for <see cref="ContentNamespaceUrl" /> property.</summary>
        private string _contentNamespaceUrl;

        /// <summary>The DHA report version. (Namespace version)</summary>
        public string ContentNamespaceUrl
        {
            get
            {
                return this._contentNamespaceUrl;
            }
            set
            {
                this._contentNamespaceUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="ContentVersion" /> property.</summary>
        private string _contentVersion;

        /// <summary>The HealthAttestation state schema version</summary>
        public string ContentVersion
        {
            get
            {
                return this._contentVersion;
            }
            set
            {
                this._contentVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="DataExcutionPolicy" /> property.</summary>
        private string _dataExcutionPolicy;

        /// <summary>
        /// DEP Policy defines a set of hardware and software technologies that perform additional checks on memory
        /// </summary>
        public string DataExcutionPolicy
        {
            get
            {
                return this._dataExcutionPolicy;
            }
            set
            {
                this._dataExcutionPolicy = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceHealthAttestationStatus" /> property.</summary>
        private string _deviceHealthAttestationStatus;

        /// <summary>The DHA report version. (Namespace version)</summary>
        public string DeviceHealthAttestationStatus
        {
            get
            {
                return this._deviceHealthAttestationStatus;
            }
            set
            {
                this._deviceHealthAttestationStatus = value;
            }
        }
        /// <summary>
        /// Backing field for <see cref="EarlyLaunchAntiMalwareDriverProtection" /> property.
        /// </summary>
        private string _earlyLaunchAntiMalwareDriverProtection;

        /// <summary>ELAM provides protection for the computers in your network when they start up</summary>
        public string EarlyLaunchAntiMalwareDriverProtection
        {
            get
            {
                return this._earlyLaunchAntiMalwareDriverProtection;
            }
            set
            {
                this._earlyLaunchAntiMalwareDriverProtection = value;
            }
        }
        /// <summary>Backing field for <see cref="HealthAttestationSupportedStatus" /> property.</summary>
        private string _healthAttestationSupportedStatus;

        /// <summary>This attribute indicates if DHA is supported for the device</summary>
        public string HealthAttestationSupportedStatus
        {
            get
            {
                return this._healthAttestationSupportedStatus;
            }
            set
            {
                this._healthAttestationSupportedStatus = value;
            }
        }
        /// <summary>Backing field for <see cref="HealthStatusMismatchInfo" /> property.</summary>
        private string _healthStatusMismatchInfo;

        /// <summary>This attribute appears if DHA-Service detects an integrity issue</summary>
        public string HealthStatusMismatchInfo
        {
            get
            {
                return this._healthStatusMismatchInfo;
            }
            set
            {
                this._healthStatusMismatchInfo = value;
            }
        }
        /// <summary>Backing field for <see cref="IssuedDateTime" /> property.</summary>
        private System.DateTime? _issuedDateTime;

        /// <summary>The DateTime when device was evaluated or issued to MDM</summary>
        public System.DateTime? IssuedDateTime
        {
            get
            {
                return this._issuedDateTime;
            }
            set
            {
                this._issuedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="LastUpdateDateTime" /> property.</summary>
        private string _lastUpdateDateTime;

        /// <summary>The Timestamp of the last update.</summary>
        public string LastUpdateDateTime
        {
            get
            {
                return this._lastUpdateDateTime;
            }
            set
            {
                this._lastUpdateDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="OperatingSystemKernelDebugging" /> property.</summary>
        private string _operatingSystemKernelDebugging;

        /// <summary>
        /// When operatingSystemKernelDebugging is enabled, the device is used in development and testing
        /// </summary>
        public string OperatingSystemKernelDebugging
        {
            get
            {
                return this._operatingSystemKernelDebugging;
            }
            set
            {
                this._operatingSystemKernelDebugging = value;
            }
        }
        /// <summary>Backing field for <see cref="OperatingSystemRevListInfo" /> property.</summary>
        private string _operatingSystemRevListInfo;

        /// <summary>
        /// The Operating System Revision List that was loaded during initial boot on the attested device
        /// </summary>
        public string OperatingSystemRevListInfo
        {
            get
            {
                return this._operatingSystemRevListInfo;
            }
            set
            {
                this._operatingSystemRevListInfo = value;
            }
        }
        /// <summary>Backing field for <see cref="Pcr0" /> property.</summary>
        private string _pcr0;

        /// <summary>The measurement that is captured in PCR[0]</summary>
        public string Pcr0
        {
            get
            {
                return this._pcr0;
            }
            set
            {
                this._pcr0 = value;
            }
        }
        /// <summary>Backing field for <see cref="PcrHashAlgorithm" /> property.</summary>
        private string _pcrHashAlgorithm;

        /// <summary>Informational attribute that identifies the HASH algorithm that was used by TPM</summary>
        public string PcrHashAlgorithm
        {
            get
            {
                return this._pcrHashAlgorithm;
            }
            set
            {
                this._pcrHashAlgorithm = value;
            }
        }
        /// <summary>Backing field for <see cref="ResetCount" /> property.</summary>
        private long? _resetCount;

        /// <summary>The number of times a PC device has hibernated or resumed</summary>
        public long? ResetCount
        {
            get
            {
                return this._resetCount;
            }
            set
            {
                this._resetCount = value;
            }
        }
        /// <summary>Backing field for <see cref="RestartCount" /> property.</summary>
        private long? _restartCount;

        /// <summary>The number of times a PC device has rebooted</summary>
        public long? RestartCount
        {
            get
            {
                return this._restartCount;
            }
            set
            {
                this._restartCount = value;
            }
        }
        /// <summary>Backing field for <see cref="SafeMode" /> property.</summary>
        private string _safeMode;

        /// <summary>
        /// Safe mode is a troubleshooting option for Windows that starts your computer in a limited state
        /// </summary>
        public string SafeMode
        {
            get
            {
                return this._safeMode;
            }
            set
            {
                this._safeMode = value;
            }
        }
        /// <summary>Backing field for <see cref="SecureBoot" /> property.</summary>
        private string _secureBoot;

        /// <summary>
        /// When Secure Boot is enabled, the core components must have the correct cryptographic signatures
        /// </summary>
        public string SecureBoot
        {
            get
            {
                return this._secureBoot;
            }
            set
            {
                this._secureBoot = value;
            }
        }
        /// <summary>
        /// Backing field for <see cref="SecureBootConfigurationPolicyFingerPrint" /> property.
        /// </summary>
        private string _secureBootConfigurationPolicyFingerPrint;

        /// <summary>Fingerprint of the Custom Secure Boot Configuration Policy</summary>
        public string SecureBootConfigurationPolicyFingerPrint
        {
            get
            {
                return this._secureBootConfigurationPolicyFingerPrint;
            }
            set
            {
                this._secureBootConfigurationPolicyFingerPrint = value;
            }
        }
        /// <summary>Backing field for <see cref="TestSigning" /> property.</summary>
        private string _testSigning;

        /// <summary>
        /// When test signing is allowed, the device does not enforce signature validation during boot
        /// </summary>
        public string TestSigning
        {
            get
            {
                return this._testSigning;
            }
            set
            {
                this._testSigning = value;
            }
        }
        /// <summary>Backing field for <see cref="TpmVersion" /> property.</summary>
        private string _tpmVersion;

        /// <summary>The security version number of the Boot Application</summary>
        public string TpmVersion
        {
            get
            {
                return this._tpmVersion;
            }
            set
            {
                this._tpmVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="VirtualSecureMode" /> property.</summary>
        private string _virtualSecureMode;

        /// <summary>VSM is a container that protects high value assets from a compromised kernel</summary>
        public string VirtualSecureMode
        {
            get
            {
                return this._virtualSecureMode;
            }
            set
            {
                this._virtualSecureMode = value;
            }
        }
        /// <summary>Backing field for <see cref="WindowsPE" /> property.</summary>
        private string _windowsPE;

        /// <summary>
        /// Operating system running with limited services that is used to prepare a computer for Windows
        /// </summary>
        public string WindowsPE
        {
            get
            {
                return this._windowsPE;
            }
            set
            {
                this._windowsPE = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphDeviceHealthAttestationState" /> instance.
        /// </summary>
        public MicrosoftGraphDeviceHealthAttestationState()
        {
        }
    }
    /// deviceHealthAttestationState
    public partial interface IMicrosoftGraphDeviceHealthAttestationState : Sample.API.Runtime.IJsonSerializable {
        string AttestationIdentityKey { get; set; }
        string BitLockerStatus { get; set; }
        string BootAppSecurityVersion { get; set; }
        string BootDebugging { get; set; }
        string BootManagerSecurityVersion { get; set; }
        string BootManagerVersion { get; set; }
        string BootRevisionListInfo { get; set; }
        string CodeIntegrity { get; set; }
        string CodeIntegrityCheckVersion { get; set; }
        string CodeIntegrityPolicy { get; set; }
        string ContentNamespaceUrl { get; set; }
        string ContentVersion { get; set; }
        string DataExcutionPolicy { get; set; }
        string DeviceHealthAttestationStatus { get; set; }
        string EarlyLaunchAntiMalwareDriverProtection { get; set; }
        string HealthAttestationSupportedStatus { get; set; }
        string HealthStatusMismatchInfo { get; set; }
        System.DateTime? IssuedDateTime { get; set; }
        string LastUpdateDateTime { get; set; }
        string OperatingSystemKernelDebugging { get; set; }
        string OperatingSystemRevListInfo { get; set; }
        string Pcr0 { get; set; }
        string PcrHashAlgorithm { get; set; }
        long? ResetCount { get; set; }
        long? RestartCount { get; set; }
        string SafeMode { get; set; }
        string SecureBoot { get; set; }
        string SecureBootConfigurationPolicyFingerPrint { get; set; }
        string TestSigning { get; set; }
        string TpmVersion { get; set; }
        string VirtualSecureMode { get; set; }
        string WindowsPE { get; set; }
    }
}