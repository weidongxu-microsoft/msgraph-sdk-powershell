namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharedInsight</summary>
    public partial class ComponentsSchemasMicrosoftGraphSharedinsightAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphSharedinsightAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphSharedinsightAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_lastShared = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("lastShared"), out var __jsonLastShared) ? Sample.API.Models.MicrosoftGraphSharingDetail.FromJson(__jsonLastShared) : LastShared;}
            {_lastSharedMethod = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("lastSharedMethod"), out var __jsonLastSharedMethod) ? Sample.API.Models.MicrosoftGraphEntity.FromJson(__jsonLastSharedMethod) : LastSharedMethod;}
            {_resource = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("resource"), out var __jsonResource) ? Sample.API.Models.MicrosoftGraphEntity.FromJson(__jsonResource) : Resource;}
            {_resourceReference = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("resourceReference"), out var __jsonResourceReference) ? Sample.API.Models.MicrosoftGraphResourceReference.FromJson(__jsonResourceReference) : ResourceReference;}
            {_resourceVisualization = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("resourceVisualization"), out var __jsonResourceVisualization) ? Sample.API.Models.MicrosoftGraphResourceVisualization.FromJson(__jsonResourceVisualization) : ResourceVisualization;}
            {_sharingHistory = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("sharingHistory"), out var __jsonSharingHistory) ? If( __jsonSharingHistory as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSharingDetail[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphSharingDetail) (Sample.API.Models.MicrosoftGraphSharingDetail.FromJson(__u) )) ))() : null : SharingHistory;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphSharedinsightAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphSharedinsightAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphSharedinsightAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphSharedinsightAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphSharedinsightAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphSharedinsightAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != LastShared ? (Sample.API.Runtime.Json.JsonNode) LastShared.ToJson(null,serializationMode) : null, "lastShared" ,container.Add );
            AddIf( null != LastSharedMethod ? (Sample.API.Runtime.Json.JsonNode) LastSharedMethod.ToJson(null,serializationMode) : null, "lastSharedMethod" ,container.Add );
            AddIf( null != Resource ? (Sample.API.Runtime.Json.JsonNode) Resource.ToJson(null,serializationMode) : null, "resource" ,container.Add );
            AddIf( null != ResourceReference ? (Sample.API.Runtime.Json.JsonNode) ResourceReference.ToJson(null,serializationMode) : null, "resourceReference" ,container.Add );
            AddIf( null != ResourceVisualization ? (Sample.API.Runtime.Json.JsonNode) ResourceVisualization.ToJson(null,serializationMode) : null, "resourceVisualization" ,container.Add );
            if (null != SharingHistory)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in SharingHistory )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("sharingHistory",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}