namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>mailFolder</summary>
    public partial class ComponentsSchemasMicrosoftGraphMailfolderAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphMailfolderAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphMailfolderAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_childFolderCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("childFolderCount"), out var __jsonChildFolderCount) ? (int?)__jsonChildFolderCount : ChildFolderCount;}
            {_childFolders = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("childFolders"), out var __jsonChildFolders) ? If( __jsonChildFolders as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMailFolder[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphMailFolder) (Sample.API.Models.MicrosoftGraphMailFolder.FromJson(__u) )) ))() : null : ChildFolders;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_messageRules = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("messageRules"), out var __jsonMessageRules) ? If( __jsonMessageRules as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMessageRule[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphMessageRule) (Sample.API.Models.MicrosoftGraphMessageRule.FromJson(__p) )) ))() : null : MessageRules;}
            {_messages = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("messages"), out var __jsonMessages) ? If( __jsonMessages as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMessage[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphMessage) (Sample.API.Models.MicrosoftGraphMessage.FromJson(__k) )) ))() : null : Messages;}
            {_multiValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("multiValueExtendedProperties"), out var __jsonMultiValueExtendedProperties) ? If( __jsonMultiValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphMultiValueLegacyExtendedProperty.FromJson(__f) )) ))() : null : MultiValueExtendedProperties;}
            {_parentFolderId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("parentFolderId"), out var __jsonParentFolderId) ? (string)__jsonParentFolderId : (string)ParentFolderId;}
            {_singleValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("singleValueExtendedProperties"), out var __jsonSingleValueExtendedProperties) ? If( __jsonSingleValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphSingleValueLegacyExtendedProperty.FromJson(__a) )) ))() : null : SingleValueExtendedProperties;}
            {_totalItemCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("totalItemCount"), out var __jsonTotalItemCount) ? (int?)__jsonTotalItemCount : TotalItemCount;}
            {_unreadItemCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("unreadItemCount"), out var __jsonUnreadItemCount) ? (int?)__jsonUnreadItemCount : UnreadItemCount;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphMailfolderAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphMailfolderAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphMailfolderAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphMailfolderAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphMailfolderAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphMailfolderAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != ChildFolderCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)ChildFolderCount) : null, "childFolderCount" ,container.Add );
            if (null != ChildFolders)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in ChildFolders )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("childFolders",__w);
            }
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            if (null != MessageRules)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in MessageRules )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("messageRules",__r);
            }
            if (null != Messages)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in Messages )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("messages",__m);
            }
            if (null != MultiValueExtendedProperties)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in MultiValueExtendedProperties )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("multiValueExtendedProperties",__h);
            }
            AddIf( null != (((object)ParentFolderId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ParentFolderId.ToString()) : null, "parentFolderId" ,container.Add );
            if (null != SingleValueExtendedProperties)
            {
                var __c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __d in SingleValueExtendedProperties )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("singleValueExtendedProperties",__c);
            }
            AddIf( null != TotalItemCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)TotalItemCount) : null, "totalItemCount" ,container.Add );
            AddIf( null != UnreadItemCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)UnreadItemCount) : null, "unreadItemCount" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}