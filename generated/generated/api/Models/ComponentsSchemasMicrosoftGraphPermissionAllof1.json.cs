namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>permission</summary>
    public partial class ComponentsSchemasMicrosoftGraphPermissionAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphPermissionAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphPermissionAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_grantedTo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("grantedTo"), out var __jsonGrantedTo) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonGrantedTo) : GrantedTo;}
            {_inheritedFrom = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("inheritedFrom"), out var __jsonInheritedFrom) ? Sample.API.Models.MicrosoftGraphItemReference.FromJson(__jsonInheritedFrom) : InheritedFrom;}
            {_invitation = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("invitation"), out var __jsonInvitation) ? Sample.API.Models.MicrosoftGraphSharingInvitation.FromJson(__jsonInvitation) : Invitation;}
            {_link = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("link"), out var __jsonLink) ? Sample.API.Models.MicrosoftGraphSharingLink.FromJson(__jsonLink) : Link;}
            {_roles = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("roles"), out var __jsonRoles) ? If( __jsonRoles as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Sample.API.Runtime.Json.JsonString __t ? (string)__t : null)) ))() : null : Roles;}
            {_shareId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("shareId"), out var __jsonShareId) ? (string)__jsonShareId : (string)ShareId;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPermissionAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPermissionAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphPermissionAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphPermissionAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphPermissionAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphPermissionAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != GrantedTo ? (Sample.API.Runtime.Json.JsonNode) GrantedTo.ToJson(null,serializationMode) : null, "grantedTo" ,container.Add );
            AddIf( null != InheritedFrom ? (Sample.API.Runtime.Json.JsonNode) InheritedFrom.ToJson(null,serializationMode) : null, "inheritedFrom" ,container.Add );
            AddIf( null != Invitation ? (Sample.API.Runtime.Json.JsonNode) Invitation.ToJson(null,serializationMode) : null, "invitation" ,container.Add );
            AddIf( null != Link ? (Sample.API.Runtime.Json.JsonNode) Link.ToJson(null,serializationMode) : null, "link" ,container.Add );
            if (null != Roles)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Roles )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("roles",__w);
            }
            AddIf( null != (((object)ShareId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ShareId.ToString()) : null, "shareId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}