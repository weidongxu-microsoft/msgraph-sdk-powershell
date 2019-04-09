namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>drive</summary>
    public partial class ComponentsSchemasMicrosoftGraphDriveAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphDriveAllof1" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphDriveAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_owner = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("owner"), out var __jsonOwner) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonOwner) : Owner;}
            {_quota = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("quota"), out var __jsonQuota) ? Sample.API.Models.MicrosoftGraphQuota.FromJson(__jsonQuota) : Quota;}
            {_sharePointIds = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sharePointIds"), out var __jsonSharePointIds) ? Sample.API.Models.MicrosoftGraphSharepointIds.FromJson(__jsonSharePointIds) : SharePointIds;}
            {_driveType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("driveType"), out var __jsonDriveType) ? (string)__jsonDriveType : (string)DriveType;}
            {_items = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("items"), out var __jsonItems) ? If( __jsonItems as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDriveItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphDriveItem) (Sample.API.Models.MicrosoftGraphDriveItem.FromJson(__u) )) ))() : null : Items;}
            {_list = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("list"), out var __jsonList) ? Sample.API.Models.MicrosoftGraphList.FromJson(__jsonList) : List;}
            {_root = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("root"), out var __jsonRoot) ? Sample.API.Models.MicrosoftGraphDriveItem.FromJson(__jsonRoot) : Root;}
            {_special = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("special"), out var __jsonSpecial) ? If( __jsonSpecial as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDriveItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphDriveItem) (Sample.API.Models.MicrosoftGraphDriveItem.FromJson(__p) )) ))() : null : Special;}
            {_system = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("system"), out var __jsonSystem) ? Sample.API.Models.MicrosoftGraphSystemFacet.FromJson(__jsonSystem) : System;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphDriveAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphDriveAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphDriveAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Owner ? (Sample.API.Runtime.Json.JsonNode) Owner.ToJson(null,serializationMode) : null, "owner" ,container.Add );
            AddIf( null != Quota ? (Sample.API.Runtime.Json.JsonNode) Quota.ToJson(null,serializationMode) : null, "quota" ,container.Add );
            AddIf( null != SharePointIds ? (Sample.API.Runtime.Json.JsonNode) SharePointIds.ToJson(null,serializationMode) : null, "sharePointIds" ,container.Add );
            AddIf( null != (((object)DriveType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DriveType.ToString()) : null, "driveType" ,container.Add );
            if (null != Items)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Items )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("items",__w);
            }
            AddIf( null != List ? (Sample.API.Runtime.Json.JsonNode) List.ToJson(null,serializationMode) : null, "list" ,container.Add );
            AddIf( null != Root ? (Sample.API.Runtime.Json.JsonNode) Root.ToJson(null,serializationMode) : null, "root" ,container.Add );
            if (null != Special)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Special )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("special",__r);
            }
            AddIf( null != System ? (Sample.API.Runtime.Json.JsonNode) System.ToJson(null,serializationMode) : null, "system" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}