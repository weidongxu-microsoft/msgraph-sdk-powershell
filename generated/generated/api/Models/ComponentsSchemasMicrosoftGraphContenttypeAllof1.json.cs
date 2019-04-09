namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>contentType</summary>
    public partial class ComponentsSchemasMicrosoftGraphContenttypeAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphContenttypeAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphContenttypeAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_inheritedFrom = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("inheritedFrom"), out var __jsonInheritedFrom) ? Sample.API.Models.MicrosoftGraphItemReference.FromJson(__jsonInheritedFrom) : InheritedFrom;}
            {_order = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("order"), out var __jsonOrder) ? Sample.API.Models.MicrosoftGraphContentTypeOrder.FromJson(__jsonOrder) : Order;}
            {_name = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_description = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_columnLinks = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("columnLinks"), out var __jsonColumnLinks) ? If( __jsonColumnLinks as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphColumnLink[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphColumnLink) (Sample.API.Models.MicrosoftGraphColumnLink.FromJson(__u) )) ))() : null : ColumnLinks;}
            {_group = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("group"), out var __jsonGroup) ? (string)__jsonGroup : (string)Group;}
            {_hidden = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hidden"), out var __jsonHidden) ? (bool?)__jsonHidden : Hidden;}
            {_parentId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("parentId"), out var __jsonParentId) ? (string)__jsonParentId : (string)ParentId;}
            {_readOnly = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("readOnly"), out var __jsonReadOnly) ? (bool?)__jsonReadOnly : ReadOnly;}
            {_sealed = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("sealed"), out var __jsonSealed) ? (bool?)__jsonSealed : Sealed;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphContenttypeAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphContenttypeAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphContenttypeAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphContenttypeAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphContenttypeAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphContenttypeAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != InheritedFrom ? (Sample.API.Runtime.Json.JsonNode) InheritedFrom.ToJson(null,serializationMode) : null, "inheritedFrom" ,container.Add );
            AddIf( null != Order ? (Sample.API.Runtime.Json.JsonNode) Order.ToJson(null,serializationMode) : null, "order" ,container.Add );
            AddIf( null != (((object)Name)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)Description)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Description.ToString()) : null, "description" ,container.Add );
            if (null != ColumnLinks)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in ColumnLinks )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("columnLinks",__w);
            }
            AddIf( null != (((object)Group)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Group.ToString()) : null, "group" ,container.Add );
            AddIf( null != Hidden ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)Hidden) : null, "hidden" ,container.Add );
            AddIf( null != (((object)ParentId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ParentId.ToString()) : null, "parentId" ,container.Add );
            AddIf( null != ReadOnly ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ReadOnly) : null, "readOnly" ,container.Add );
            AddIf( null != Sealed ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)Sealed) : null, "sealed" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}