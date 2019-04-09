namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>messageRuleActions</summary>
    public partial class MicrosoftGraphMessageRuleActions
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphMessageRuleActions.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphMessageRuleActions.</returns>
        public static Sample.API.Models.IMicrosoftGraphMessageRuleActions FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphMessageRuleActions(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphMessageRuleActions" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphMessageRuleActions(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_assignCategories = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("assignCategories"), out var __jsonAssignCategories) ? If( __jsonAssignCategories as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Sample.API.Runtime.Json.JsonString __t ? (string)__t : null)) ))() : null : AssignCategories;}
            {_copyToFolder = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("copyToFolder"), out var __jsonCopyToFolder) ? (string)__jsonCopyToFolder : (string)CopyToFolder;}
            {_delete = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("delete"), out var __jsonDelete) ? (bool?)__jsonDelete : Delete;}
            {_forwardAsAttachmentTo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("forwardAsAttachmentTo"), out var __jsonForwardAsAttachmentTo) ? If( __jsonForwardAsAttachmentTo as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(__p) )) ))() : null : ForwardAsAttachmentTo;}
            {_forwardTo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("forwardTo"), out var __jsonForwardTo) ? If( __jsonForwardTo as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(__k) )) ))() : null : ForwardTo;}
            {_markAsRead = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("markAsRead"), out var __jsonMarkAsRead) ? (bool?)__jsonMarkAsRead : MarkAsRead;}
            {_markImportance = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("markImportance"), out var __jsonMarkImportance) ? (string)__jsonMarkImportance : (string)MarkImportance;}
            {_moveToFolder = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("moveToFolder"), out var __jsonMoveToFolder) ? (string)__jsonMoveToFolder : (string)MoveToFolder;}
            {_permanentDelete = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("permanentDelete"), out var __jsonPermanentDelete) ? (bool?)__jsonPermanentDelete : PermanentDelete;}
            {_redirectTo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("redirectTo"), out var __jsonRedirectTo) ? If( __jsonRedirectTo as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(__f) )) ))() : null : RedirectTo;}
            {_stopProcessingRules = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("stopProcessingRules"), out var __jsonStopProcessingRules) ? (bool?)__jsonStopProcessingRules : StopProcessingRules;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphMessageRuleActions" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphMessageRuleActions" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            if (null != AssignCategories)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in AssignCategories )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("assignCategories",__w);
            }
            AddIf( null != (((object)CopyToFolder)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CopyToFolder.ToString()) : null, "copyToFolder" ,container.Add );
            AddIf( null != Delete ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)Delete) : null, "delete" ,container.Add );
            if (null != ForwardAsAttachmentTo)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in ForwardAsAttachmentTo )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("forwardAsAttachmentTo",__r);
            }
            if (null != ForwardTo)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in ForwardTo )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("forwardTo",__m);
            }
            AddIf( null != MarkAsRead ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)MarkAsRead) : null, "markAsRead" ,container.Add );
            AddIf( null != (((object)MarkImportance)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MarkImportance.ToString()) : null, "markImportance" ,container.Add );
            AddIf( null != (((object)MoveToFolder)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MoveToFolder.ToString()) : null, "moveToFolder" ,container.Add );
            AddIf( null != PermanentDelete ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)PermanentDelete) : null, "permanentDelete" ,container.Add );
            if (null != RedirectTo)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in RedirectTo )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("redirectTo",__h);
            }
            AddIf( null != StopProcessingRules ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)StopProcessingRules) : null, "stopProcessingRules" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}