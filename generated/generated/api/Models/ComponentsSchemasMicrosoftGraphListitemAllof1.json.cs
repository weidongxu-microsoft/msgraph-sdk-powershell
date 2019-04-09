namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>listItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphListitemAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphListitemAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphListitemAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_contentType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("contentType"), out var __jsonContentType) ? Sample.API.Models.MicrosoftGraphContentTypeInfo.FromJson(__jsonContentType) : ContentType;}
            {_sharepointIds = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sharepointIds"), out var __jsonSharepointIds) ? Sample.API.Models.MicrosoftGraphSharepointIds.FromJson(__jsonSharepointIds) : SharepointIds;}
            {_driveItem = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("driveItem"), out var __jsonDriveItem) ? Sample.API.Models.MicrosoftGraphDriveItem.FromJson(__jsonDriveItem) : DriveItem;}
            {_fields = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("fields"), out var __jsonFields) ? Sample.API.Models.MicrosoftGraphFieldValueSet.FromJson(__jsonFields) : Fields;}
            {_versions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("versions"), out var __jsonVersions) ? If( __jsonVersions as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphListItemVersion[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphListItemVersion) (Sample.API.Models.MicrosoftGraphListItemVersion.FromJson(__u) )) ))() : null : Versions;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphListitemAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphListitemAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphListitemAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != ContentType ? (Sample.API.Runtime.Json.JsonNode) ContentType.ToJson(null,serializationMode) : null, "contentType" ,container.Add );
            AddIf( null != SharepointIds ? (Sample.API.Runtime.Json.JsonNode) SharepointIds.ToJson(null,serializationMode) : null, "sharepointIds" ,container.Add );
            AddIf( null != DriveItem ? (Sample.API.Runtime.Json.JsonNode) DriveItem.ToJson(null,serializationMode) : null, "driveItem" ,container.Add );
            AddIf( null != Fields ? (Sample.API.Runtime.Json.JsonNode) Fields.ToJson(null,serializationMode) : null, "fields" ,container.Add );
            if (null != Versions)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Versions )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("versions",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}