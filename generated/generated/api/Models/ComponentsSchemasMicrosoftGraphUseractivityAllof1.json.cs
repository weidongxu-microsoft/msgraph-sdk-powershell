namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>userActivity</summary>
    public partial class ComponentsSchemasMicrosoftGraphUseractivityAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphUseractivityAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphUseractivityAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_visualElements = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("visualElements"), out var __jsonVisualElements) ? Sample.API.Models.MicrosoftGraphVisualInfo.FromJson(__jsonVisualElements) : VisualElements;}
            {_activationUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("activationUrl"), out var __jsonActivationUrl) ? (string)__jsonActivationUrl : (string)ActivationUrl;}
            {_activitySourceHost = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("activitySourceHost"), out var __jsonActivitySourceHost) ? (string)__jsonActivitySourceHost : (string)ActivitySourceHost;}
            {_appActivityId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("appActivityId"), out var __jsonAppActivityId) ? (string)__jsonAppActivityId : (string)AppActivityId;}
            {_appDisplayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("appDisplayName"), out var __jsonAppDisplayName) ? (string)__jsonAppDisplayName : (string)AppDisplayName;}
            {_contentInfo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("contentInfo"), out var __jsonContentInfo) ? Sample.API.Models.MicrosoftGraphJson.FromJson(__jsonContentInfo) : ContentInfo;}
            {_contentUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("contentUrl"), out var __jsonContentUrl) ? (string)__jsonContentUrl : (string)ContentUrl;}
            {_createdDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("createdDateTime"), out var __jsonCreatedDateTime) ? System.DateTime.TryParse((string)__jsonCreatedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedDateTimeValue) ? __jsonCreatedDateTimeValue : CreatedDateTime : CreatedDateTime;}
            {_expirationDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("expirationDateTime"), out var __jsonExpirationDateTime) ? System.DateTime.TryParse((string)__jsonExpirationDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonExpirationDateTimeValue) ? __jsonExpirationDateTimeValue : ExpirationDateTime : ExpirationDateTime;}
            {_fallbackUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("fallbackUrl"), out var __jsonFallbackUrl) ? (string)__jsonFallbackUrl : (string)FallbackUrl;}
            {_historyItems = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("historyItems"), out var __jsonHistoryItems) ? If( __jsonHistoryItems as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphActivityHistoryItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphActivityHistoryItem) (Sample.API.Models.MicrosoftGraphActivityHistoryItem.FromJson(__u) )) ))() : null : HistoryItems;}
            {_lastModifiedDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("lastModifiedDateTime"), out var __jsonLastModifiedDateTime) ? System.DateTime.TryParse((string)__jsonLastModifiedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedDateTimeValue) ? __jsonLastModifiedDateTimeValue : LastModifiedDateTime : LastModifiedDateTime;}
            {_status = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_userTimezone = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userTimezone"), out var __jsonUserTimezone) ? (string)__jsonUserTimezone : (string)UserTimezone;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphUseractivityAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphUseractivityAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphUseractivityAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphUseractivityAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphUseractivityAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphUseractivityAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != VisualElements ? (Sample.API.Runtime.Json.JsonNode) VisualElements.ToJson(null,serializationMode) : null, "visualElements" ,container.Add );
            AddIf( null != (((object)ActivationUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ActivationUrl.ToString()) : null, "activationUrl" ,container.Add );
            AddIf( null != (((object)ActivitySourceHost)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ActivitySourceHost.ToString()) : null, "activitySourceHost" ,container.Add );
            AddIf( null != (((object)AppActivityId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AppActivityId.ToString()) : null, "appActivityId" ,container.Add );
            AddIf( null != (((object)AppDisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AppDisplayName.ToString()) : null, "appDisplayName" ,container.Add );
            AddIf( null != ContentInfo ? (Sample.API.Runtime.Json.JsonNode) ContentInfo.ToJson(null,serializationMode) : null, "contentInfo" ,container.Add );
            AddIf( null != (((object)ContentUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ContentUrl.ToString()) : null, "contentUrl" ,container.Add );
            AddIf( null != CreatedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CreatedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "createdDateTime" ,container.Add );
            AddIf( null != ExpirationDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExpirationDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "expirationDateTime" ,container.Add );
            AddIf( null != (((object)FallbackUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(FallbackUrl.ToString()) : null, "fallbackUrl" ,container.Add );
            if (null != HistoryItems)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in HistoryItems )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("historyItems",__w);
            }
            AddIf( null != LastModifiedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LastModifiedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModifiedDateTime" ,container.Add );
            AddIf( null != (((object)Status)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)UserTimezone)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserTimezone.ToString()) : null, "userTimezone" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}