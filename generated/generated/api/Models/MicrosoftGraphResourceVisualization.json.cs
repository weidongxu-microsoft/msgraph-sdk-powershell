namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>resourceVisualization</summary>
    public partial class MicrosoftGraphResourceVisualization
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphResourceVisualization.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphResourceVisualization.</returns>
        public static Sample.API.Models.IMicrosoftGraphResourceVisualization FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphResourceVisualization(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphResourceVisualization" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphResourceVisualization(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_containerDisplayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("containerDisplayName"), out var __jsonContainerDisplayName) ? (string)__jsonContainerDisplayName : (string)ContainerDisplayName;}
            {_containerType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("containerType"), out var __jsonContainerType) ? (string)__jsonContainerType : (string)ContainerType;}
            {_containerWebUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("containerWebUrl"), out var __jsonContainerWebUrl) ? (string)__jsonContainerWebUrl : (string)ContainerWebUrl;}
            {_mediaType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("mediaType"), out var __jsonMediaType) ? (string)__jsonMediaType : (string)MediaType;}
            {_previewImageUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("previewImageUrl"), out var __jsonPreviewImageUrl) ? (string)__jsonPreviewImageUrl : (string)PreviewImageUrl;}
            {_previewText = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("previewText"), out var __jsonPreviewText) ? (string)__jsonPreviewText : (string)PreviewText;}
            {_title = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphResourceVisualization" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphResourceVisualization" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)Type)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)ContainerDisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ContainerDisplayName.ToString()) : null, "containerDisplayName" ,container.Add );
            AddIf( null != (((object)ContainerType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ContainerType.ToString()) : null, "containerType" ,container.Add );
            AddIf( null != (((object)ContainerWebUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ContainerWebUrl.ToString()) : null, "containerWebUrl" ,container.Add );
            AddIf( null != (((object)MediaType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MediaType.ToString()) : null, "mediaType" ,container.Add );
            AddIf( null != (((object)PreviewImageUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PreviewImageUrl.ToString()) : null, "previewImageUrl" ,container.Add );
            AddIf( null != (((object)PreviewText)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PreviewText.ToString()) : null, "previewText" ,container.Add );
            AddIf( null != (((object)Title)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Title.ToString()) : null, "title" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}