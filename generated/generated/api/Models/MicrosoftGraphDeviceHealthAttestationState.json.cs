namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>deviceHealthAttestationState</summary>
    public partial class MicrosoftGraphDeviceHealthAttestationState
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Sample.API.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Sample.API.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Sample.API.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Sample.API.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Sample.API.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState.</returns>
        public static Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphDeviceHealthAttestationState(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphDeviceHealthAttestationState" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphDeviceHealthAttestationState(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_attestationIdentityKey = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("attestationIdentityKey"), out var __jsonAttestationIdentityKey) ? (string)__jsonAttestationIdentityKey : (string)AttestationIdentityKey;}
            {_bitLockerStatus = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bitLockerStatus"), out var __jsonBitLockerStatus) ? (string)__jsonBitLockerStatus : (string)BitLockerStatus;}
            {_bootAppSecurityVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bootAppSecurityVersion"), out var __jsonBootAppSecurityVersion) ? (string)__jsonBootAppSecurityVersion : (string)BootAppSecurityVersion;}
            {_bootDebugging = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bootDebugging"), out var __jsonBootDebugging) ? (string)__jsonBootDebugging : (string)BootDebugging;}
            {_bootManagerSecurityVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bootManagerSecurityVersion"), out var __jsonBootManagerSecurityVersion) ? (string)__jsonBootManagerSecurityVersion : (string)BootManagerSecurityVersion;}
            {_bootManagerVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bootManagerVersion"), out var __jsonBootManagerVersion) ? (string)__jsonBootManagerVersion : (string)BootManagerVersion;}
            {_bootRevisionListInfo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bootRevisionListInfo"), out var __jsonBootRevisionListInfo) ? (string)__jsonBootRevisionListInfo : (string)BootRevisionListInfo;}
            {_codeIntegrity = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("codeIntegrity"), out var __jsonCodeIntegrity) ? (string)__jsonCodeIntegrity : (string)CodeIntegrity;}
            {_codeIntegrityCheckVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("codeIntegrityCheckVersion"), out var __jsonCodeIntegrityCheckVersion) ? (string)__jsonCodeIntegrityCheckVersion : (string)CodeIntegrityCheckVersion;}
            {_codeIntegrityPolicy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("codeIntegrityPolicy"), out var __jsonCodeIntegrityPolicy) ? (string)__jsonCodeIntegrityPolicy : (string)CodeIntegrityPolicy;}
            {_contentNamespaceUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("contentNamespaceUrl"), out var __jsonContentNamespaceUrl) ? (string)__jsonContentNamespaceUrl : (string)ContentNamespaceUrl;}
            {_contentVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("contentVersion"), out var __jsonContentVersion) ? (string)__jsonContentVersion : (string)ContentVersion;}
            {_dataExcutionPolicy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("dataExcutionPolicy"), out var __jsonDataExcutionPolicy) ? (string)__jsonDataExcutionPolicy : (string)DataExcutionPolicy;}
            {_deviceHealthAttestationStatus = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceHealthAttestationStatus"), out var __jsonDeviceHealthAttestationStatus) ? (string)__jsonDeviceHealthAttestationStatus : (string)DeviceHealthAttestationStatus;}
            {_earlyLaunchAntiMalwareDriverProtection = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("earlyLaunchAntiMalwareDriverProtection"), out var __jsonEarlyLaunchAntiMalwareDriverProtection) ? (string)__jsonEarlyLaunchAntiMalwareDriverProtection : (string)EarlyLaunchAntiMalwareDriverProtection;}
            {_healthAttestationSupportedStatus = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("healthAttestationSupportedStatus"), out var __jsonHealthAttestationSupportedStatus) ? (string)__jsonHealthAttestationSupportedStatus : (string)HealthAttestationSupportedStatus;}
            {_healthStatusMismatchInfo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("healthStatusMismatchInfo"), out var __jsonHealthStatusMismatchInfo) ? (string)__jsonHealthStatusMismatchInfo : (string)HealthStatusMismatchInfo;}
            {_issuedDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("issuedDateTime"), out var __jsonIssuedDateTime) ? System.DateTime.TryParse((string)__jsonIssuedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonIssuedDateTimeValue) ? __jsonIssuedDateTimeValue : IssuedDateTime : IssuedDateTime;}
            {_lastUpdateDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("lastUpdateDateTime"), out var __jsonLastUpdateDateTime) ? (string)__jsonLastUpdateDateTime : (string)LastUpdateDateTime;}
            {_operatingSystemKernelDebugging = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("operatingSystemKernelDebugging"), out var __jsonOperatingSystemKernelDebugging) ? (string)__jsonOperatingSystemKernelDebugging : (string)OperatingSystemKernelDebugging;}
            {_operatingSystemRevListInfo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("operatingSystemRevListInfo"), out var __jsonOperatingSystemRevListInfo) ? (string)__jsonOperatingSystemRevListInfo : (string)OperatingSystemRevListInfo;}
            {_pcr0 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("pcr0"), out var __jsonPcr0) ? (string)__jsonPcr0 : (string)Pcr0;}
            {_pcrHashAlgorithm = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("pcrHashAlgorithm"), out var __jsonPcrHashAlgorithm) ? (string)__jsonPcrHashAlgorithm : (string)PcrHashAlgorithm;}
            {_resetCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("resetCount"), out var __jsonResetCount) ? (long?)__jsonResetCount : ResetCount;}
            {_restartCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("restartCount"), out var __jsonRestartCount) ? (long?)__jsonRestartCount : RestartCount;}
            {_safeMode = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("safeMode"), out var __jsonSafeMode) ? (string)__jsonSafeMode : (string)SafeMode;}
            {_secureBoot = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("secureBoot"), out var __jsonSecureBoot) ? (string)__jsonSecureBoot : (string)SecureBoot;}
            {_secureBootConfigurationPolicyFingerPrint = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("secureBootConfigurationPolicyFingerPrint"), out var __jsonSecureBootConfigurationPolicyFingerPrint) ? (string)__jsonSecureBootConfigurationPolicyFingerPrint : (string)SecureBootConfigurationPolicyFingerPrint;}
            {_testSigning = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("testSigning"), out var __jsonTestSigning) ? (string)__jsonTestSigning : (string)TestSigning;}
            {_tpmVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("tpmVersion"), out var __jsonTpmVersion) ? (string)__jsonTpmVersion : (string)TpmVersion;}
            {_virtualSecureMode = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("virtualSecureMode"), out var __jsonVirtualSecureMode) ? (string)__jsonVirtualSecureMode : (string)VirtualSecureMode;}
            {_windowsPE = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("windowsPE"), out var __jsonWindowsPE) ? (string)__jsonWindowsPE : (string)WindowsPE;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphDeviceHealthAttestationState" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphDeviceHealthAttestationState" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Sample.API.Runtime.Json.JsonNode ToJson(Sample.API.Runtime.Json.JsonObject container, Sample.API.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Sample.API.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)AttestationIdentityKey)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AttestationIdentityKey.ToString()) : null, "attestationIdentityKey" ,container.Add );
            AddIf( null != (((object)BitLockerStatus)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BitLockerStatus.ToString()) : null, "bitLockerStatus" ,container.Add );
            AddIf( null != (((object)BootAppSecurityVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BootAppSecurityVersion.ToString()) : null, "bootAppSecurityVersion" ,container.Add );
            AddIf( null != (((object)BootDebugging)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BootDebugging.ToString()) : null, "bootDebugging" ,container.Add );
            AddIf( null != (((object)BootManagerSecurityVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BootManagerSecurityVersion.ToString()) : null, "bootManagerSecurityVersion" ,container.Add );
            AddIf( null != (((object)BootManagerVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BootManagerVersion.ToString()) : null, "bootManagerVersion" ,container.Add );
            AddIf( null != (((object)BootRevisionListInfo)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BootRevisionListInfo.ToString()) : null, "bootRevisionListInfo" ,container.Add );
            AddIf( null != (((object)CodeIntegrity)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CodeIntegrity.ToString()) : null, "codeIntegrity" ,container.Add );
            AddIf( null != (((object)CodeIntegrityCheckVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CodeIntegrityCheckVersion.ToString()) : null, "codeIntegrityCheckVersion" ,container.Add );
            AddIf( null != (((object)CodeIntegrityPolicy)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CodeIntegrityPolicy.ToString()) : null, "codeIntegrityPolicy" ,container.Add );
            AddIf( null != (((object)ContentNamespaceUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ContentNamespaceUrl.ToString()) : null, "contentNamespaceUrl" ,container.Add );
            AddIf( null != (((object)ContentVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ContentVersion.ToString()) : null, "contentVersion" ,container.Add );
            AddIf( null != (((object)DataExcutionPolicy)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DataExcutionPolicy.ToString()) : null, "dataExcutionPolicy" ,container.Add );
            AddIf( null != (((object)DeviceHealthAttestationStatus)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceHealthAttestationStatus.ToString()) : null, "deviceHealthAttestationStatus" ,container.Add );
            AddIf( null != (((object)EarlyLaunchAntiMalwareDriverProtection)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(EarlyLaunchAntiMalwareDriverProtection.ToString()) : null, "earlyLaunchAntiMalwareDriverProtection" ,container.Add );
            AddIf( null != (((object)HealthAttestationSupportedStatus)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(HealthAttestationSupportedStatus.ToString()) : null, "healthAttestationSupportedStatus" ,container.Add );
            AddIf( null != (((object)HealthStatusMismatchInfo)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(HealthStatusMismatchInfo.ToString()) : null, "healthStatusMismatchInfo" ,container.Add );
            AddIf( null != IssuedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(IssuedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "issuedDateTime" ,container.Add );
            AddIf( null != (((object)LastUpdateDateTime)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LastUpdateDateTime.ToString()) : null, "lastUpdateDateTime" ,container.Add );
            AddIf( null != (((object)OperatingSystemKernelDebugging)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OperatingSystemKernelDebugging.ToString()) : null, "operatingSystemKernelDebugging" ,container.Add );
            AddIf( null != (((object)OperatingSystemRevListInfo)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OperatingSystemRevListInfo.ToString()) : null, "operatingSystemRevListInfo" ,container.Add );
            AddIf( null != (((object)Pcr0)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Pcr0.ToString()) : null, "pcr0" ,container.Add );
            AddIf( null != (((object)PcrHashAlgorithm)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PcrHashAlgorithm.ToString()) : null, "pcrHashAlgorithm" ,container.Add );
            AddIf( null != ResetCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)ResetCount) : null, "resetCount" ,container.Add );
            AddIf( null != RestartCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)RestartCount) : null, "restartCount" ,container.Add );
            AddIf( null != (((object)SafeMode)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SafeMode.ToString()) : null, "safeMode" ,container.Add );
            AddIf( null != (((object)SecureBoot)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SecureBoot.ToString()) : null, "secureBoot" ,container.Add );
            AddIf( null != (((object)SecureBootConfigurationPolicyFingerPrint)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SecureBootConfigurationPolicyFingerPrint.ToString()) : null, "secureBootConfigurationPolicyFingerPrint" ,container.Add );
            AddIf( null != (((object)TestSigning)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(TestSigning.ToString()) : null, "testSigning" ,container.Add );
            AddIf( null != (((object)TpmVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(TpmVersion.ToString()) : null, "tpmVersion" ,container.Add );
            AddIf( null != (((object)VirtualSecureMode)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(VirtualSecureMode.ToString()) : null, "virtualSecureMode" ,container.Add );
            AddIf( null != (((object)WindowsPE)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(WindowsPE.ToString()) : null, "windowsPE" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}