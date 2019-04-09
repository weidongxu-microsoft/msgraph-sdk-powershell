namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>list</summary>
    public partial class ComponentsSchemasMicrosoftGraphListAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphListAllof1" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphListAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_list = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("list"), out var __jsonList) ? Sample.API.Models.MicrosoftGraphListInfo.FromJson(__jsonList) : List;}
            {_sharepointIds = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sharepointIds"), out var __jsonSharepointIds) ? Sample.API.Models.MicrosoftGraphSharepointIds.FromJson(__jsonSharepointIds) : SharepointIds;}
            {_columns = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("columns"), out var __jsonColumns) ? If( __jsonColumns as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphColumnDefinition[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphColumnDefinition) (Sample.API.Models.MicrosoftGraphColumnDefinition.FromJson(__u) )) ))() : null : Columns;}
            {_contentTypes = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("contentTypes"), out var __jsonContentTypes) ? If( __jsonContentTypes as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphContentType[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphContentType) (Sample.API.Models.MicrosoftGraphContentType.FromJson(__p) )) ))() : null : ContentTypes;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_drive = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("drive"), out var __jsonDrive) ? Sample.API.Models.MicrosoftGraphDrive.FromJson(__jsonDrive) : Drive;}
            {_items = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("items"), out var __jsonItems) ? If( __jsonItems as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphListItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphListItem) (Sample.API.Models.MicrosoftGraphListItem.FromJson(__k) )) ))() : null : Items;}
            {_system = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("system"), out var __jsonSystem) ? Sample.API.Models.MicrosoftGraphSystemFacet.FromJson(__jsonSystem) : System;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphListAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphListAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphListAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphListAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphListAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphListAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != List ? (Sample.API.Runtime.Json.JsonNode) List.ToJson(null,serializationMode) : null, "list" ,container.Add );
            AddIf( null != SharepointIds ? (Sample.API.Runtime.Json.JsonNode) SharepointIds.ToJson(null,serializationMode) : null, "sharepointIds" ,container.Add );
            if (null != Columns)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Columns )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("columns",__w);
            }
            if (null != ContentTypes)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in ContentTypes )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("contentTypes",__r);
            }
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != Drive ? (Sample.API.Runtime.Json.JsonNode) Drive.ToJson(null,serializationMode) : null, "drive" ,container.Add );
            if (null != Items)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in Items )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("items",__m);
            }
            AddIf( null != System ? (Sample.API.Runtime.Json.JsonNode) System.ToJson(null,serializationMode) : null, "system" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}