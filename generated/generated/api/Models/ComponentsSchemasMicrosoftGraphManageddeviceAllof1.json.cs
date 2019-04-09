namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>Devices that are managed or pre-enrolled through Intune</summary>
    public partial class ComponentsSchemasMicrosoftGraphManageddeviceAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphManageddeviceAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphManageddeviceAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_configurationManagerClientEnabledFeatures = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("configurationManagerClientEnabledFeatures"), out var __jsonConfigurationManagerClientEnabledFeatures) ? Sample.API.Models.MicrosoftGraphConfigurationManagerClientEnabledFeatures.FromJson(__jsonConfigurationManagerClientEnabledFeatures) : ConfigurationManagerClientEnabledFeatures;}
            {_activationLockBypassCode = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("activationLockBypassCode"), out var __jsonActivationLockBypassCode) ? (string)__jsonActivationLockBypassCode : (string)ActivationLockBypassCode;}
            {_androidSecurityPatchLevel = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("androidSecurityPatchLevel"), out var __jsonAndroidSecurityPatchLevel) ? (string)__jsonAndroidSecurityPatchLevel : (string)AndroidSecurityPatchLevel;}
            {_azureADDeviceId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("azureADDeviceId"), out var __jsonAzureADDeviceId) ? (string)__jsonAzureADDeviceId : (string)AzureADDeviceId;}
            {_azureADRegistered = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("azureADRegistered"), out var __jsonAzureADRegistered) ? (bool?)__jsonAzureADRegistered : AzureADRegistered;}
            {_complianceGracePeriodExpirationDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("complianceGracePeriodExpirationDateTime"), out var __jsonComplianceGracePeriodExpirationDateTime) ? System.DateTime.TryParse((string)__jsonComplianceGracePeriodExpirationDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonComplianceGracePeriodExpirationDateTimeValue) ? __jsonComplianceGracePeriodExpirationDateTimeValue : ComplianceGracePeriodExpirationDateTime : ComplianceGracePeriodExpirationDateTime;}
            {_complianceState = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("complianceState"), out var __jsonComplianceState) ? (string)__jsonComplianceState : (string)ComplianceState;}
            {_deviceActionResults = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("deviceActionResults"), out var __jsonDeviceActionResults) ? If( __jsonDeviceActionResults as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDeviceActionResult[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphDeviceActionResult) (Sample.API.Models.MicrosoftGraphDeviceActionResult.FromJson(__u) )) ))() : null : DeviceActionResults;}
            {_deviceCategory = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("deviceCategory"), out var __jsonDeviceCategory) ? Sample.API.Models.MicrosoftGraphDeviceCategory.FromJson(__jsonDeviceCategory) : DeviceCategory;}
            {_deviceCategoryDisplayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceCategoryDisplayName"), out var __jsonDeviceCategoryDisplayName) ? (string)__jsonDeviceCategoryDisplayName : (string)DeviceCategoryDisplayName;}
            {_deviceCompliancePolicyStates = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("deviceCompliancePolicyStates"), out var __jsonDeviceCompliancePolicyStates) ? If( __jsonDeviceCompliancePolicyStates as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicyState[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicyState) (Sample.API.Models.MicrosoftGraphDeviceCompliancePolicyState.FromJson(__p) )) ))() : null : DeviceCompliancePolicyStates;}
            {_deviceConfigurationStates = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("deviceConfigurationStates"), out var __jsonDeviceConfigurationStates) ? If( __jsonDeviceConfigurationStates as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDeviceConfigurationState[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphDeviceConfigurationState) (Sample.API.Models.MicrosoftGraphDeviceConfigurationState.FromJson(__k) )) ))() : null : DeviceConfigurationStates;}
            {_deviceEnrollmentType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceEnrollmentType"), out var __jsonDeviceEnrollmentType) ? (string)__jsonDeviceEnrollmentType : (string)DeviceEnrollmentType;}
            {_deviceName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceName"), out var __jsonDeviceName) ? (string)__jsonDeviceName : (string)DeviceName;}
            {_deviceRegistrationState = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceRegistrationState"), out var __jsonDeviceRegistrationState) ? (string)__jsonDeviceRegistrationState : (string)DeviceRegistrationState;}
            {_easActivated = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("easActivated"), out var __jsonEasActivated) ? (bool?)__jsonEasActivated : EasActivated;}
            {_easActivationDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("easActivationDateTime"), out var __jsonEasActivationDateTime) ? System.DateTime.TryParse((string)__jsonEasActivationDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEasActivationDateTimeValue) ? __jsonEasActivationDateTimeValue : EasActivationDateTime : EasActivationDateTime;}
            {_easDeviceId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("easDeviceId"), out var __jsonEasDeviceId) ? (string)__jsonEasDeviceId : (string)EasDeviceId;}
            {_emailAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("emailAddress"), out var __jsonEmailAddress) ? (string)__jsonEmailAddress : (string)EmailAddress;}
            {_enrolledDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("enrolledDateTime"), out var __jsonEnrolledDateTime) ? System.DateTime.TryParse((string)__jsonEnrolledDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEnrolledDateTimeValue) ? __jsonEnrolledDateTimeValue : EnrolledDateTime : EnrolledDateTime;}
            {_exchangeAccessState = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("exchangeAccessState"), out var __jsonExchangeAccessState) ? (string)__jsonExchangeAccessState : (string)ExchangeAccessState;}
            {_exchangeAccessStateReason = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("exchangeAccessStateReason"), out var __jsonExchangeAccessStateReason) ? (string)__jsonExchangeAccessStateReason : (string)ExchangeAccessStateReason;}
            {_exchangeLastSuccessfulSyncDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("exchangeLastSuccessfulSyncDateTime"), out var __jsonExchangeLastSuccessfulSyncDateTime) ? System.DateTime.TryParse((string)__jsonExchangeLastSuccessfulSyncDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonExchangeLastSuccessfulSyncDateTimeValue) ? __jsonExchangeLastSuccessfulSyncDateTimeValue : ExchangeLastSuccessfulSyncDateTime : ExchangeLastSuccessfulSyncDateTime;}
            {_freeStorageSpaceInBytes = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("freeStorageSpaceInBytes"), out var __jsonFreeStorageSpaceInBytes) ? (long?)__jsonFreeStorageSpaceInBytes : FreeStorageSpaceInBytes;}
            {_imei = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("imei"), out var __jsonImei) ? (string)__jsonImei : (string)Imei;}
            {_isEncrypted = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isEncrypted"), out var __jsonIsEncrypted) ? (bool?)__jsonIsEncrypted : IsEncrypted;}
            {_isSupervised = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isSupervised"), out var __jsonIsSupervised) ? (bool?)__jsonIsSupervised : IsSupervised;}
            {_jailBroken = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("jailBroken"), out var __jsonJailBroken) ? (string)__jsonJailBroken : (string)JailBroken;}
            {_lastSyncDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("lastSyncDateTime"), out var __jsonLastSyncDateTime) ? System.DateTime.TryParse((string)__jsonLastSyncDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastSyncDateTimeValue) ? __jsonLastSyncDateTimeValue : LastSyncDateTime : LastSyncDateTime;}
            {_managedDeviceName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("managedDeviceName"), out var __jsonManagedDeviceName) ? (string)__jsonManagedDeviceName : (string)ManagedDeviceName;}
            {_managedDeviceOwnerType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("managedDeviceOwnerType"), out var __jsonManagedDeviceOwnerType) ? (string)__jsonManagedDeviceOwnerType : (string)ManagedDeviceOwnerType;}
            {_managementAgent = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("managementAgent"), out var __jsonManagementAgent) ? (string)__jsonManagementAgent : (string)ManagementAgent;}
            {_manufacturer = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("manufacturer"), out var __jsonManufacturer) ? (string)__jsonManufacturer : (string)Manufacturer;}
            {_meid = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("meid"), out var __jsonMeid) ? (string)__jsonMeid : (string)Meid;}
            {_model = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("model"), out var __jsonModel) ? (string)__jsonModel : (string)Model;}
            {_operatingSystem = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("operatingSystem"), out var __jsonOperatingSystem) ? (string)__jsonOperatingSystem : (string)OperatingSystem;}
            {_osVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("osVersion"), out var __jsonOsVersion) ? (string)__jsonOsVersion : (string)OsVersion;}
            {_partnerReportedThreatState = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("partnerReportedThreatState"), out var __jsonPartnerReportedThreatState) ? (string)__jsonPartnerReportedThreatState : (string)PartnerReportedThreatState;}
            {_phoneNumber = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("phoneNumber"), out var __jsonPhoneNumber) ? (string)__jsonPhoneNumber : (string)PhoneNumber;}
            {_remoteAssistanceSessionErrorDetails = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("remoteAssistanceSessionErrorDetails"), out var __jsonRemoteAssistanceSessionErrorDetails) ? (string)__jsonRemoteAssistanceSessionErrorDetails : (string)RemoteAssistanceSessionErrorDetails;}
            {_remoteAssistanceSessionUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("remoteAssistanceSessionUrl"), out var __jsonRemoteAssistanceSessionUrl) ? (string)__jsonRemoteAssistanceSessionUrl : (string)RemoteAssistanceSessionUrl;}
            {_serialNumber = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("serialNumber"), out var __jsonSerialNumber) ? (string)__jsonSerialNumber : (string)SerialNumber;}
            {_subscriberCarrier = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("subscriberCarrier"), out var __jsonSubscriberCarrier) ? (string)__jsonSubscriberCarrier : (string)SubscriberCarrier;}
            {_totalStorageSpaceInBytes = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("totalStorageSpaceInBytes"), out var __jsonTotalStorageSpaceInBytes) ? (long?)__jsonTotalStorageSpaceInBytes : TotalStorageSpaceInBytes;}
            {_userDisplayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userDisplayName"), out var __jsonUserDisplayName) ? (string)__jsonUserDisplayName : (string)UserDisplayName;}
            {_userId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userId"), out var __jsonUserId) ? (string)__jsonUserId : (string)UserId;}
            {_userPrincipalName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userPrincipalName"), out var __jsonUserPrincipalName) ? (string)__jsonUserPrincipalName : (string)UserPrincipalName;}
            {_wiFiMacAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("wiFiMacAddress"), out var __jsonWiFiMacAddress) ? (string)__jsonWiFiMacAddress : (string)WiFiMacAddress;}
            {_deviceHealthAttestationState = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("deviceHealthAttestationState"), out var __jsonDeviceHealthAttestationState) ? Sample.API.Models.MicrosoftGraphDeviceHealthAttestationState.FromJson(__jsonDeviceHealthAttestationState) : DeviceHealthAttestationState;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphManageddeviceAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphManageddeviceAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphManageddeviceAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphManageddeviceAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphManageddeviceAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphManageddeviceAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != ConfigurationManagerClientEnabledFeatures ? (Sample.API.Runtime.Json.JsonNode) ConfigurationManagerClientEnabledFeatures.ToJson(null,serializationMode) : null, "configurationManagerClientEnabledFeatures" ,container.Add );
            AddIf( null != (((object)ActivationLockBypassCode)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ActivationLockBypassCode.ToString()) : null, "activationLockBypassCode" ,container.Add );
            AddIf( null != (((object)AndroidSecurityPatchLevel)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AndroidSecurityPatchLevel.ToString()) : null, "androidSecurityPatchLevel" ,container.Add );
            AddIf( null != (((object)AzureADDeviceId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AzureADDeviceId.ToString()) : null, "azureADDeviceId" ,container.Add );
            AddIf( null != AzureADRegistered ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AzureADRegistered) : null, "azureADRegistered" ,container.Add );
            AddIf( null != ComplianceGracePeriodExpirationDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ComplianceGracePeriodExpirationDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "complianceGracePeriodExpirationDateTime" ,container.Add );
            AddIf( null != (((object)ComplianceState)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ComplianceState.ToString()) : null, "complianceState" ,container.Add );
            if (null != DeviceActionResults)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in DeviceActionResults )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("deviceActionResults",__w);
            }
            AddIf( null != DeviceCategory ? (Sample.API.Runtime.Json.JsonNode) DeviceCategory.ToJson(null,serializationMode) : null, "deviceCategory" ,container.Add );
            AddIf( null != (((object)DeviceCategoryDisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceCategoryDisplayName.ToString()) : null, "deviceCategoryDisplayName" ,container.Add );
            if (null != DeviceCompliancePolicyStates)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in DeviceCompliancePolicyStates )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("deviceCompliancePolicyStates",__r);
            }
            if (null != DeviceConfigurationStates)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in DeviceConfigurationStates )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("deviceConfigurationStates",__m);
            }
            AddIf( null != (((object)DeviceEnrollmentType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceEnrollmentType.ToString()) : null, "deviceEnrollmentType" ,container.Add );
            AddIf( null != (((object)DeviceName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceName.ToString()) : null, "deviceName" ,container.Add );
            AddIf( null != (((object)DeviceRegistrationState)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceRegistrationState.ToString()) : null, "deviceRegistrationState" ,container.Add );
            AddIf( null != EasActivated ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)EasActivated) : null, "easActivated" ,container.Add );
            AddIf( null != EasActivationDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(EasActivationDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "easActivationDateTime" ,container.Add );
            AddIf( null != (((object)EasDeviceId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(EasDeviceId.ToString()) : null, "easDeviceId" ,container.Add );
            AddIf( null != (((object)EmailAddress)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(EmailAddress.ToString()) : null, "emailAddress" ,container.Add );
            AddIf( null != EnrolledDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(EnrolledDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "enrolledDateTime" ,container.Add );
            AddIf( null != (((object)ExchangeAccessState)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExchangeAccessState.ToString()) : null, "exchangeAccessState" ,container.Add );
            AddIf( null != (((object)ExchangeAccessStateReason)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExchangeAccessStateReason.ToString()) : null, "exchangeAccessStateReason" ,container.Add );
            AddIf( null != ExchangeLastSuccessfulSyncDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExchangeLastSuccessfulSyncDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "exchangeLastSuccessfulSyncDateTime" ,container.Add );
            AddIf( null != FreeStorageSpaceInBytes ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)FreeStorageSpaceInBytes) : null, "freeStorageSpaceInBytes" ,container.Add );
            AddIf( null != (((object)Imei)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Imei.ToString()) : null, "imei" ,container.Add );
            AddIf( null != IsEncrypted ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsEncrypted) : null, "isEncrypted" ,container.Add );
            AddIf( null != IsSupervised ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsSupervised) : null, "isSupervised" ,container.Add );
            AddIf( null != (((object)JailBroken)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(JailBroken.ToString()) : null, "jailBroken" ,container.Add );
            AddIf( null != LastSyncDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LastSyncDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "lastSyncDateTime" ,container.Add );
            AddIf( null != (((object)ManagedDeviceName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ManagedDeviceName.ToString()) : null, "managedDeviceName" ,container.Add );
            AddIf( null != (((object)ManagedDeviceOwnerType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ManagedDeviceOwnerType.ToString()) : null, "managedDeviceOwnerType" ,container.Add );
            AddIf( null != (((object)ManagementAgent)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ManagementAgent.ToString()) : null, "managementAgent" ,container.Add );
            AddIf( null != (((object)Manufacturer)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Manufacturer.ToString()) : null, "manufacturer" ,container.Add );
            AddIf( null != (((object)Meid)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Meid.ToString()) : null, "meid" ,container.Add );
            AddIf( null != (((object)Model)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Model.ToString()) : null, "model" ,container.Add );
            AddIf( null != (((object)OperatingSystem)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OperatingSystem.ToString()) : null, "operatingSystem" ,container.Add );
            AddIf( null != (((object)OsVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OsVersion.ToString()) : null, "osVersion" ,container.Add );
            AddIf( null != (((object)PartnerReportedThreatState)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PartnerReportedThreatState.ToString()) : null, "partnerReportedThreatState" ,container.Add );
            AddIf( null != (((object)PhoneNumber)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PhoneNumber.ToString()) : null, "phoneNumber" ,container.Add );
            AddIf( null != (((object)RemoteAssistanceSessionErrorDetails)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(RemoteAssistanceSessionErrorDetails.ToString()) : null, "remoteAssistanceSessionErrorDetails" ,container.Add );
            AddIf( null != (((object)RemoteAssistanceSessionUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(RemoteAssistanceSessionUrl.ToString()) : null, "remoteAssistanceSessionUrl" ,container.Add );
            AddIf( null != (((object)SerialNumber)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SerialNumber.ToString()) : null, "serialNumber" ,container.Add );
            AddIf( null != (((object)SubscriberCarrier)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SubscriberCarrier.ToString()) : null, "subscriberCarrier" ,container.Add );
            AddIf( null != TotalStorageSpaceInBytes ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)TotalStorageSpaceInBytes) : null, "totalStorageSpaceInBytes" ,container.Add );
            AddIf( null != (((object)UserDisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserDisplayName.ToString()) : null, "userDisplayName" ,container.Add );
            AddIf( null != (((object)UserId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserId.ToString()) : null, "userId" ,container.Add );
            AddIf( null != (((object)UserPrincipalName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserPrincipalName.ToString()) : null, "userPrincipalName" ,container.Add );
            AddIf( null != (((object)WiFiMacAddress)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(WiFiMacAddress.ToString()) : null, "wiFiMacAddress" ,container.Add );
            AddIf( null != DeviceHealthAttestationState ? (Sample.API.Runtime.Json.JsonNode) DeviceHealthAttestationState.ToJson(null,serializationMode) : null, "deviceHealthAttestationState" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}