namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    /// </summary>
    public partial class ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_appIdentifier = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("appIdentifier"), out var __jsonAppIdentifier) ? Sample.API.Models.MicrosoftGraphMobileAppIdentifier.FromJson(__jsonAppIdentifier) : AppIdentifier;}
            {_applicationVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("applicationVersion"), out var __jsonApplicationVersion) ? (string)__jsonApplicationVersion : (string)ApplicationVersion;}
            {_appliedPolicies = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("appliedPolicies"), out var __jsonAppliedPolicies) ? If( __jsonAppliedPolicies as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphManagedAppPolicy[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphManagedAppPolicy) (Sample.API.Models.MicrosoftGraphManagedAppPolicy.FromJson(__u) )) ))() : null : AppliedPolicies;}
            {_createdDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("createdDateTime"), out var __jsonCreatedDateTime) ? System.DateTime.TryParse((string)__jsonCreatedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedDateTimeValue) ? __jsonCreatedDateTimeValue : CreatedDateTime : CreatedDateTime;}
            {_deviceName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceName"), out var __jsonDeviceName) ? (string)__jsonDeviceName : (string)DeviceName;}
            {_deviceTag = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceTag"), out var __jsonDeviceTag) ? (string)__jsonDeviceTag : (string)DeviceTag;}
            {_deviceType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("deviceType"), out var __jsonDeviceType) ? (string)__jsonDeviceType : (string)DeviceType;}
            {_flaggedReasons = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("flaggedReasons"), out var __jsonFlaggedReasons) ? If( __jsonFlaggedReasons as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Sample.API.Runtime.Json.JsonString __o ? (string)__o : null)) ))() : null : FlaggedReasons;}
            {_intendedPolicies = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("intendedPolicies"), out var __jsonIntendedPolicies) ? If( __jsonIntendedPolicies as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphManagedAppPolicy[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphManagedAppPolicy) (Sample.API.Models.MicrosoftGraphManagedAppPolicy.FromJson(__k) )) ))() : null : IntendedPolicies;}
            {_lastSyncDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("lastSyncDateTime"), out var __jsonLastSyncDateTime) ? System.DateTime.TryParse((string)__jsonLastSyncDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastSyncDateTimeValue) ? __jsonLastSyncDateTimeValue : LastSyncDateTime : LastSyncDateTime;}
            {_managementSdkVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("managementSdkVersion"), out var __jsonManagementSdkVersion) ? (string)__jsonManagementSdkVersion : (string)ManagementSdkVersion;}
            {_platformVersion = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("platformVersion"), out var __jsonPlatformVersion) ? (string)__jsonPlatformVersion : (string)PlatformVersion;}
            {_userId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userId"), out var __jsonUserId) ? (string)__jsonUserId : (string)UserId;}
            {_version = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            {_operations = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("operations"), out var __jsonOperations) ? If( __jsonOperations as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphManagedAppOperation[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphManagedAppOperation) (Sample.API.Models.MicrosoftGraphManagedAppOperation.FromJson(__f) )) ))() : null : Operations;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != AppIdentifier ? (Sample.API.Runtime.Json.JsonNode) AppIdentifier.ToJson(null,serializationMode) : null, "appIdentifier" ,container.Add );
            AddIf( null != (((object)ApplicationVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ApplicationVersion.ToString()) : null, "applicationVersion" ,container.Add );
            if (null != AppliedPolicies)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in AppliedPolicies )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("appliedPolicies",__w);
            }
            AddIf( null != CreatedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CreatedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "createdDateTime" ,container.Add );
            AddIf( null != (((object)DeviceName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceName.ToString()) : null, "deviceName" ,container.Add );
            AddIf( null != (((object)DeviceTag)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceTag.ToString()) : null, "deviceTag" ,container.Add );
            AddIf( null != (((object)DeviceType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DeviceType.ToString()) : null, "deviceType" ,container.Add );
            if (null != FlaggedReasons)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in FlaggedReasons )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("flaggedReasons",__r);
            }
            if (null != IntendedPolicies)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in IntendedPolicies )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("intendedPolicies",__m);
            }
            AddIf( null != LastSyncDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LastSyncDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "lastSyncDateTime" ,container.Add );
            AddIf( null != (((object)ManagementSdkVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ManagementSdkVersion.ToString()) : null, "managementSdkVersion" ,container.Add );
            AddIf( null != (((object)PlatformVersion)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PlatformVersion.ToString()) : null, "platformVersion" ,container.Add );
            AddIf( null != (((object)UserId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserId.ToString()) : null, "userId" ,container.Add );
            AddIf( null != (((object)Version)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Version.ToString()) : null, "version" ,container.Add );
            if (null != Operations)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in Operations )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("operations",__h);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}