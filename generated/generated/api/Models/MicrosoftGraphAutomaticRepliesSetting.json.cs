namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>automaticRepliesSetting</summary>
    public partial class MicrosoftGraphAutomaticRepliesSetting
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting.</returns>
        public static Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphAutomaticRepliesSetting(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphAutomaticRepliesSetting" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphAutomaticRepliesSetting(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_scheduledEndDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("scheduledEndDateTime"), out var __jsonScheduledEndDateTime) ? Sample.API.Models.MicrosoftGraphDateTimeZone.FromJson(__jsonScheduledEndDateTime) : ScheduledEndDateTime;}
            {_scheduledStartDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("scheduledStartDateTime"), out var __jsonScheduledStartDateTime) ? Sample.API.Models.MicrosoftGraphDateTimeZone.FromJson(__jsonScheduledStartDateTime) : ScheduledStartDateTime;}
            {_externalAudience = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("externalAudience"), out var __jsonExternalAudience) ? (string)__jsonExternalAudience : (string)ExternalAudience;}
            {_externalReplyMessage = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("externalReplyMessage"), out var __jsonExternalReplyMessage) ? (string)__jsonExternalReplyMessage : (string)ExternalReplyMessage;}
            {_internalReplyMessage = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("internalReplyMessage"), out var __jsonInternalReplyMessage) ? (string)__jsonInternalReplyMessage : (string)InternalReplyMessage;}
            {_status = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphAutomaticRepliesSetting" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphAutomaticRepliesSetting" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != ScheduledEndDateTime ? (Sample.API.Runtime.Json.JsonNode) ScheduledEndDateTime.ToJson(null,serializationMode) : null, "scheduledEndDateTime" ,container.Add );
            AddIf( null != ScheduledStartDateTime ? (Sample.API.Runtime.Json.JsonNode) ScheduledStartDateTime.ToJson(null,serializationMode) : null, "scheduledStartDateTime" ,container.Add );
            AddIf( null != (((object)ExternalAudience)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExternalAudience.ToString()) : null, "externalAudience" ,container.Add );
            AddIf( null != (((object)ExternalReplyMessage)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExternalReplyMessage.ToString()) : null, "externalReplyMessage" ,container.Add );
            AddIf( null != (((object)InternalReplyMessage)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(InternalReplyMessage.ToString()) : null, "internalReplyMessage" ,container.Add );
            AddIf( null != (((object)Status)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Status.ToString()) : null, "status" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}