namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenotePage</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenotepageAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphOnenotepageAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphOnenotepageAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_links = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("links"), out var __jsonLinks) ? Sample.API.Models.MicrosoftGraphPageLinks.FromJson(__jsonLinks) : Links;}
            {_content = null /* deserializeFromContainerMember doesn't support 'application/json' C:\Users\deagrawa\.autorest\@microsoft.azure_autorest.csharp-v2@2.0.227\node_modules\@microsoft.azure\autorest.csharp-v2\dist\schema\byte-array.js*/;}
            {_contentUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("contentUrl"), out var __jsonContentUrl) ? (string)__jsonContentUrl : (string)ContentUrl;}
            {_createdByAppId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("createdByAppId"), out var __jsonCreatedByAppId) ? (string)__jsonCreatedByAppId : (string)CreatedByAppId;}
            {_lastModifiedDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("lastModifiedDateTime"), out var __jsonLastModifiedDateTime) ? System.DateTime.TryParse((string)__jsonLastModifiedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedDateTimeValue) ? __jsonLastModifiedDateTimeValue : LastModifiedDateTime : LastModifiedDateTime;}
            {_level = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("level"), out var __jsonLevel) ? (int?)__jsonLevel : Level;}
            {_order = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("order"), out var __jsonOrder) ? (int?)__jsonOrder : Order;}
            {_parentNotebook = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("parentNotebook"), out var __jsonParentNotebook) ? Sample.API.Models.MicrosoftGraphNotebook.FromJson(__jsonParentNotebook) : ParentNotebook;}
            {_parentSection = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("parentSection"), out var __jsonParentSection) ? Sample.API.Models.MicrosoftGraphOnenoteSection.FromJson(__jsonParentSection) : ParentSection;}
            {_title = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            {_userTags = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("userTags"), out var __jsonUserTags) ? If( __jsonUserTags as Sample.API.Runtime.Json.JsonArray, out var __u) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__u, (__t)=>(string) (__t is Sample.API.Runtime.Json.JsonString __s ? (string)__s : null)) ))() : null : UserTags;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotepageAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotepageAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotepageAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphOnenotepageAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphOnenotepageAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphOnenotepageAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Links ? (Sample.API.Runtime.Json.JsonNode) Links.ToJson(null,serializationMode) : null, "links" ,container.Add );
            /* serializeToContainerMember doesn't support 'application/json' C:\Users\deagrawa\.autorest\@microsoft.azure_autorest.csharp-v2@2.0.227\node_modules\@microsoft.azure\autorest.csharp-v2\dist\schema\byte-array.js*/
            AddIf( null != (((object)ContentUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ContentUrl.ToString()) : null, "contentUrl" ,container.Add );
            AddIf( null != (((object)CreatedByAppId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CreatedByAppId.ToString()) : null, "createdByAppId" ,container.Add );
            AddIf( null != LastModifiedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LastModifiedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModifiedDateTime" ,container.Add );
            AddIf( null != Level ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Level) : null, "level" ,container.Add );
            AddIf( null != Order ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Order) : null, "order" ,container.Add );
            AddIf( null != ParentNotebook ? (Sample.API.Runtime.Json.JsonNode) ParentNotebook.ToJson(null,serializationMode) : null, "parentNotebook" ,container.Add );
            AddIf( null != ParentSection ? (Sample.API.Runtime.Json.JsonNode) ParentSection.ToJson(null,serializationMode) : null, "parentSection" ,container.Add );
            AddIf( null != (((object)Title)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Title.ToString()) : null, "title" ,container.Add );
            if (null != UserTags)
            {
                var __v = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __w in UserTags )
                {
                    AddIf(null != (((object)__w)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__w.ToString()) : null ,__v.Add);
                }
                container.Add("userTags",__v);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}