namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>message</summary>
    public partial class ComponentsSchemasMicrosoftGraphMessageAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphMessageAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphMessageAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_body = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("body"), out var __jsonBody) ? Sample.API.Models.MicrosoftGraphItemBody.FromJson(__jsonBody) : Body;}
            {_flag = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("flag"), out var __jsonFlag) ? Sample.API.Models.MicrosoftGraphFollowupFlag.FromJson(__jsonFlag) : Flag;}
            {_from = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("from"), out var __jsonFrom) ? Sample.API.Models.MicrosoftGraphRecipient.FromJson(__jsonFrom) : From;}
            {_sender = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sender"), out var __jsonSender) ? Sample.API.Models.MicrosoftGraphRecipient.FromJson(__jsonSender) : Sender;}
            {_uniqueBody = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("uniqueBody"), out var __jsonUniqueBody) ? Sample.API.Models.MicrosoftGraphItemBody.FromJson(__jsonUniqueBody) : UniqueBody;}
            {_attachments = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("attachments"), out var __jsonAttachments) ? If( __jsonAttachments as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphAttachment[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphAttachment) (Sample.API.Models.MicrosoftGraphAttachment.FromJson(__u) )) ))() : null : Attachments;}
            {_bccRecipients = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("bccRecipients"), out var __jsonBccRecipients) ? If( __jsonBccRecipients as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(__p) )) ))() : null : BccRecipients;}
            {_bodyPreview = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bodyPreview"), out var __jsonBodyPreview) ? (string)__jsonBodyPreview : (string)BodyPreview;}
            {_ccRecipients = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("ccRecipients"), out var __jsonCcRecipients) ? If( __jsonCcRecipients as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(__k) )) ))() : null : CcRecipients;}
            {_conversationId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("conversationId"), out var __jsonConversationId) ? (string)__jsonConversationId : (string)ConversationId;}
            {_hasAttachments = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hasAttachments"), out var __jsonHasAttachments) ? (bool?)__jsonHasAttachments : HasAttachments;}
            {_importance = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("importance"), out var __jsonImportance) ? (string)__jsonImportance : (string)Importance;}
            {_inferenceClassification = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("inferenceClassification"), out var __jsonInferenceClassification) ? (string)__jsonInferenceClassification : (string)InferenceClassification;}
            {_internetMessageHeaders = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("internetMessageHeaders"), out var __jsonInternetMessageHeaders) ? If( __jsonInternetMessageHeaders as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphInternetMessageHeader[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphInternetMessageHeader) (Sample.API.Models.MicrosoftGraphInternetMessageHeader.FromJson(__f) )) ))() : null : InternetMessageHeaders;}
            {_internetMessageId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("internetMessageId"), out var __jsonInternetMessageId) ? (string)__jsonInternetMessageId : (string)InternetMessageId;}
            {_isDeliveryReceiptRequested = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isDeliveryReceiptRequested"), out var __jsonIsDeliveryReceiptRequested) ? (bool?)__jsonIsDeliveryReceiptRequested : IsDeliveryReceiptRequested;}
            {_isDraft = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isDraft"), out var __jsonIsDraft) ? (bool?)__jsonIsDraft : IsDraft;}
            {_isRead = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isRead"), out var __jsonIsRead) ? (bool?)__jsonIsRead : IsRead;}
            {_isReadReceiptRequested = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isReadReceiptRequested"), out var __jsonIsReadReceiptRequested) ? (bool?)__jsonIsReadReceiptRequested : IsReadReceiptRequested;}
            {_multiValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("multiValueExtendedProperties"), out var __jsonMultiValueExtendedProperties) ? If( __jsonMultiValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphMultiValueLegacyExtendedProperty.FromJson(__a) )) ))() : null : MultiValueExtendedProperties;}
            {_parentFolderId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("parentFolderId"), out var __jsonParentFolderId) ? (string)__jsonParentFolderId : (string)ParentFolderId;}
            {_receivedDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("receivedDateTime"), out var __jsonReceivedDateTime) ? System.DateTime.TryParse((string)__jsonReceivedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonReceivedDateTimeValue) ? __jsonReceivedDateTimeValue : ReceivedDateTime : ReceivedDateTime;}
            {_replyTo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("replyTo"), out var __jsonReplyTo) ? If( __jsonReplyTo as Sample.API.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(___v) )) ))() : null : ReplyTo;}
            {_sentDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sentDateTime"), out var __jsonSentDateTime) ? System.DateTime.TryParse((string)__jsonSentDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonSentDateTimeValue) ? __jsonSentDateTimeValue : SentDateTime : SentDateTime;}
            {_singleValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("singleValueExtendedProperties"), out var __jsonSingleValueExtendedProperties) ? If( __jsonSingleValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___r, (___q)=>(Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphSingleValueLegacyExtendedProperty.FromJson(___q) )) ))() : null : SingleValueExtendedProperties;}
            {_subject = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("subject"), out var __jsonSubject) ? (string)__jsonSubject : (string)Subject;}
            {_toRecipients = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("toRecipients"), out var __jsonToRecipients) ? If( __jsonToRecipients as Sample.API.Runtime.Json.JsonArray, out var ___m) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___m, (___l)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(___l) )) ))() : null : ToRecipients;}
            {_webLink = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("webLink"), out var __jsonWebLink) ? (string)__jsonWebLink : (string)WebLink;}
            {_extensions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("extensions"), out var __jsonExtensions) ? If( __jsonExtensions as Sample.API.Runtime.Json.JsonArray, out var ___h) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphExtension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___h, (___g)=>(Sample.API.Models.IMicrosoftGraphExtension) (Sample.API.Models.MicrosoftGraphExtension.FromJson(___g) )) ))() : null : Extensions;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphMessageAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphMessageAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphMessageAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Body ? (Sample.API.Runtime.Json.JsonNode) Body.ToJson(null,serializationMode) : null, "body" ,container.Add );
            AddIf( null != Flag ? (Sample.API.Runtime.Json.JsonNode) Flag.ToJson(null,serializationMode) : null, "flag" ,container.Add );
            AddIf( null != From ? (Sample.API.Runtime.Json.JsonNode) From.ToJson(null,serializationMode) : null, "from" ,container.Add );
            AddIf( null != Sender ? (Sample.API.Runtime.Json.JsonNode) Sender.ToJson(null,serializationMode) : null, "sender" ,container.Add );
            AddIf( null != UniqueBody ? (Sample.API.Runtime.Json.JsonNode) UniqueBody.ToJson(null,serializationMode) : null, "uniqueBody" ,container.Add );
            if (null != Attachments)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Attachments )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("attachments",__w);
            }
            if (null != BccRecipients)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in BccRecipients )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("bccRecipients",__r);
            }
            AddIf( null != (((object)BodyPreview)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BodyPreview.ToString()) : null, "bodyPreview" ,container.Add );
            if (null != CcRecipients)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in CcRecipients )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("ccRecipients",__m);
            }
            AddIf( null != (((object)ConversationId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ConversationId.ToString()) : null, "conversationId" ,container.Add );
            AddIf( null != HasAttachments ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HasAttachments) : null, "hasAttachments" ,container.Add );
            AddIf( null != (((object)Importance)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Importance.ToString()) : null, "importance" ,container.Add );
            AddIf( null != (((object)InferenceClassification)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(InferenceClassification.ToString()) : null, "inferenceClassification" ,container.Add );
            if (null != InternetMessageHeaders)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in InternetMessageHeaders )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("internetMessageHeaders",__h);
            }
            AddIf( null != (((object)InternetMessageId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(InternetMessageId.ToString()) : null, "internetMessageId" ,container.Add );
            AddIf( null != IsDeliveryReceiptRequested ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsDeliveryReceiptRequested) : null, "isDeliveryReceiptRequested" ,container.Add );
            AddIf( null != IsDraft ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsDraft) : null, "isDraft" ,container.Add );
            AddIf( null != IsRead ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsRead) : null, "isRead" ,container.Add );
            AddIf( null != IsReadReceiptRequested ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsReadReceiptRequested) : null, "isReadReceiptRequested" ,container.Add );
            if (null != MultiValueExtendedProperties)
            {
                var __c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __d in MultiValueExtendedProperties )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("multiValueExtendedProperties",__c);
            }
            AddIf( null != (((object)ParentFolderId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ParentFolderId.ToString()) : null, "parentFolderId" ,container.Add );
            AddIf( null != ReceivedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ReceivedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "receivedDateTime" ,container.Add );
            if (null != ReplyTo)
            {
                var ___x = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___y in ReplyTo )
                {
                    AddIf(___y?.ToJson(null, serializationMode) ,___x.Add);
                }
                container.Add("replyTo",___x);
            }
            AddIf( null != SentDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SentDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "sentDateTime" ,container.Add );
            if (null != SingleValueExtendedProperties)
            {
                var ___s = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___t in SingleValueExtendedProperties )
                {
                    AddIf(___t?.ToJson(null, serializationMode) ,___s.Add);
                }
                container.Add("singleValueExtendedProperties",___s);
            }
            AddIf( null != (((object)Subject)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Subject.ToString()) : null, "subject" ,container.Add );
            if (null != ToRecipients)
            {
                var ___n = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___o in ToRecipients )
                {
                    AddIf(___o?.ToJson(null, serializationMode) ,___n.Add);
                }
                container.Add("toRecipients",___n);
            }
            AddIf( null != (((object)WebLink)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(WebLink.ToString()) : null, "webLink" ,container.Add );
            if (null != Extensions)
            {
                var ___i = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___j in Extensions )
                {
                    AddIf(___j?.ToJson(null, serializationMode) ,___i.Add);
                }
                container.Add("extensions",___i);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}