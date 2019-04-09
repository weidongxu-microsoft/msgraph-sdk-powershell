namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>deviceCompliancePolicySettingState</summary>
    public partial class MicrosoftGraphDeviceCompliancePolicySettingState
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState.
        /// </returns>
        public static Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphDeviceCompliancePolicySettingState(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphDeviceCompliancePolicySettingState"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphDeviceCompliancePolicySettingState(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_currentValue = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("currentValue"), out var __jsonCurrentValue) ? (string)__jsonCurrentValue : (string)CurrentValue;}
            {_errorCode = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("errorCode"), out var __jsonErrorCode) ? (long?)__jsonErrorCode : ErrorCode;}
            {_errorDescription = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("errorDescription"), out var __jsonErrorDescription) ? (string)__jsonErrorDescription : (string)ErrorDescription;}
            {_instanceDisplayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("instanceDisplayName"), out var __jsonInstanceDisplayName) ? (string)__jsonInstanceDisplayName : (string)InstanceDisplayName;}
            {_setting = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("setting"), out var __jsonSetting) ? (string)__jsonSetting : (string)Setting;}
            {_settingName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("settingName"), out var __jsonSettingName) ? (string)__jsonSettingName : (string)SettingName;}
            {_sources = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("sources"), out var __jsonSources) ? If( __jsonSources as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSettingSource[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphSettingSource) (Sample.API.Models.MicrosoftGraphSettingSource.FromJson(__u) )) ))() : null : Sources;}
            {_state = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_userEmail = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userEmail"), out var __jsonUserEmail) ? (string)__jsonUserEmail : (string)UserEmail;}
            {_userId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userId"), out var __jsonUserId) ? (string)__jsonUserId : (string)UserId;}
            {_userName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)UserName;}
            {_userPrincipalName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userPrincipalName"), out var __jsonUserPrincipalName) ? (string)__jsonUserPrincipalName : (string)UserPrincipalName;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphDeviceCompliancePolicySettingState" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphDeviceCompliancePolicySettingState" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != (((object)CurrentValue)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CurrentValue.ToString()) : null, "currentValue" ,container.Add );
            AddIf( null != ErrorCode ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)ErrorCode) : null, "errorCode" ,container.Add );
            AddIf( null != (((object)ErrorDescription)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ErrorDescription.ToString()) : null, "errorDescription" ,container.Add );
            AddIf( null != (((object)InstanceDisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(InstanceDisplayName.ToString()) : null, "instanceDisplayName" ,container.Add );
            AddIf( null != (((object)Setting)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Setting.ToString()) : null, "setting" ,container.Add );
            AddIf( null != (((object)SettingName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SettingName.ToString()) : null, "settingName" ,container.Add );
            if (null != Sources)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Sources )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("sources",__w);
            }
            AddIf( null != (((object)State)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(State.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)UserEmail)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserEmail.ToString()) : null, "userEmail" ,container.Add );
            AddIf( null != (((object)UserId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserId.ToString()) : null, "userId" ,container.Add );
            AddIf( null != (((object)UserName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserName.ToString()) : null, "userName" ,container.Add );
            AddIf( null != (((object)UserPrincipalName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserPrincipalName.ToString()) : null, "userPrincipalName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}