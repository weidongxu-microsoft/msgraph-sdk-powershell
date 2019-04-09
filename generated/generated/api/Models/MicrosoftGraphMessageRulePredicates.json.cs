namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>messageRulePredicates</summary>
    public partial class MicrosoftGraphMessageRulePredicates
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphMessageRulePredicates.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphMessageRulePredicates.</returns>
        public static Sample.API.Models.IMicrosoftGraphMessageRulePredicates FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphMessageRulePredicates(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphMessageRulePredicates" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphMessageRulePredicates(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_withinSizeRange = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("withinSizeRange"), out var __jsonWithinSizeRange) ? Sample.API.Models.MicrosoftGraphSizeRange.FromJson(__jsonWithinSizeRange) : WithinSizeRange;}
            {_bodyContains = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("bodyContains"), out var __jsonBodyContains) ? If( __jsonBodyContains as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Sample.API.Runtime.Json.JsonString __t ? (string)__t : null)) ))() : null : BodyContains;}
            {_bodyOrSubjectContains = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("bodyOrSubjectContains"), out var __jsonBodyOrSubjectContains) ? If( __jsonBodyOrSubjectContains as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Sample.API.Runtime.Json.JsonString __o ? (string)__o : null)) ))() : null : BodyOrSubjectContains;}
            {_categories = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("categories"), out var __jsonCategories) ? If( __jsonCategories as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Sample.API.Runtime.Json.JsonString __j ? (string)__j : null)) ))() : null : Categories;}
            {_fromAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("fromAddresses"), out var __jsonFromAddresses) ? If( __jsonFromAddresses as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(__f) )) ))() : null : FromAddresses;}
            {_hasAttachments = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hasAttachments"), out var __jsonHasAttachments) ? (bool?)__jsonHasAttachments : HasAttachments;}
            {_headerContains = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("headerContains"), out var __jsonHeaderContains) ? If( __jsonHeaderContains as Sample.API.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(string) (__a is Sample.API.Runtime.Json.JsonString ___z ? (string)___z : null)) ))() : null : HeaderContains;}
            {_importance = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("importance"), out var __jsonImportance) ? (string)__jsonImportance : (string)Importance;}
            {_isApprovalRequest = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isApprovalRequest"), out var __jsonIsApprovalRequest) ? (bool?)__jsonIsApprovalRequest : IsApprovalRequest;}
            {_isAutomaticForward = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isAutomaticForward"), out var __jsonIsAutomaticForward) ? (bool?)__jsonIsAutomaticForward : IsAutomaticForward;}
            {_isAutomaticReply = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isAutomaticReply"), out var __jsonIsAutomaticReply) ? (bool?)__jsonIsAutomaticReply : IsAutomaticReply;}
            {_isEncrypted = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isEncrypted"), out var __jsonIsEncrypted) ? (bool?)__jsonIsEncrypted : IsEncrypted;}
            {_isMeetingRequest = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isMeetingRequest"), out var __jsonIsMeetingRequest) ? (bool?)__jsonIsMeetingRequest : IsMeetingRequest;}
            {_isMeetingResponse = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isMeetingResponse"), out var __jsonIsMeetingResponse) ? (bool?)__jsonIsMeetingResponse : IsMeetingResponse;}
            {_isNonDeliveryReport = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isNonDeliveryReport"), out var __jsonIsNonDeliveryReport) ? (bool?)__jsonIsNonDeliveryReport : IsNonDeliveryReport;}
            {_isPermissionControlled = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isPermissionControlled"), out var __jsonIsPermissionControlled) ? (bool?)__jsonIsPermissionControlled : IsPermissionControlled;}
            {_isReadReceipt = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isReadReceipt"), out var __jsonIsReadReceipt) ? (bool?)__jsonIsReadReceipt : IsReadReceipt;}
            {_isSigned = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isSigned"), out var __jsonIsSigned) ? (bool?)__jsonIsSigned : IsSigned;}
            {_isVoicemail = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isVoicemail"), out var __jsonIsVoicemail) ? (bool?)__jsonIsVoicemail : IsVoicemail;}
            {_messageActionFlag = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("messageActionFlag"), out var __jsonMessageActionFlag) ? (string)__jsonMessageActionFlag : (string)MessageActionFlag;}
            {_notSentToMe = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("notSentToMe"), out var __jsonNotSentToMe) ? (bool?)__jsonNotSentToMe : NotSentToMe;}
            {_recipientContains = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("recipientContains"), out var __jsonRecipientContains) ? If( __jsonRecipientContains as Sample.API.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(string) (___v is Sample.API.Runtime.Json.JsonString ___u ? (string)___u : null)) ))() : null : RecipientContains;}
            {_senderContains = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("senderContains"), out var __jsonSenderContains) ? If( __jsonSenderContains as Sample.API.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___r, (___q)=>(string) (___q is Sample.API.Runtime.Json.JsonString ___p ? (string)___p : null)) ))() : null : SenderContains;}
            {_sensitivity = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sensitivity"), out var __jsonSensitivity) ? (string)__jsonSensitivity : (string)Sensitivity;}
            {_sentCcMe = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("sentCcMe"), out var __jsonSentCcMe) ? (bool?)__jsonSentCcMe : SentCcMe;}
            {_sentOnlyToMe = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("sentOnlyToMe"), out var __jsonSentOnlyToMe) ? (bool?)__jsonSentOnlyToMe : SentOnlyToMe;}
            {_sentToAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("sentToAddresses"), out var __jsonSentToAddresses) ? If( __jsonSentToAddresses as Sample.API.Runtime.Json.JsonArray, out var ___m) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphRecipient[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___m, (___l)=>(Sample.API.Models.IMicrosoftGraphRecipient) (Sample.API.Models.MicrosoftGraphRecipient.FromJson(___l) )) ))() : null : SentToAddresses;}
            {_sentToMe = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("sentToMe"), out var __jsonSentToMe) ? (bool?)__jsonSentToMe : SentToMe;}
            {_sentToOrCcMe = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("sentToOrCcMe"), out var __jsonSentToOrCcMe) ? (bool?)__jsonSentToOrCcMe : SentToOrCcMe;}
            {_subjectContains = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("subjectContains"), out var __jsonSubjectContains) ? If( __jsonSubjectContains as Sample.API.Runtime.Json.JsonArray, out var ___h) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___h, (___g)=>(string) (___g is Sample.API.Runtime.Json.JsonString ___f ? (string)___f : null)) ))() : null : SubjectContains;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphMessageRulePredicates" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphMessageRulePredicates" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != WithinSizeRange ? (Sample.API.Runtime.Json.JsonNode) WithinSizeRange.ToJson(null,serializationMode) : null, "withinSizeRange" ,container.Add );
            if (null != BodyContains)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in BodyContains )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("bodyContains",__w);
            }
            if (null != BodyOrSubjectContains)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in BodyOrSubjectContains )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("bodyOrSubjectContains",__r);
            }
            if (null != Categories)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in Categories )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("categories",__m);
            }
            if (null != FromAddresses)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in FromAddresses )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("fromAddresses",__h);
            }
            AddIf( null != HasAttachments ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HasAttachments) : null, "hasAttachments" ,container.Add );
            if (null != HeaderContains)
            {
                var __c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __d in HeaderContains )
                {
                    AddIf(null != (((object)__d)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__d.ToString()) : null ,__c.Add);
                }
                container.Add("headerContains",__c);
            }
            AddIf( null != (((object)Importance)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Importance.ToString()) : null, "importance" ,container.Add );
            AddIf( null != IsApprovalRequest ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsApprovalRequest) : null, "isApprovalRequest" ,container.Add );
            AddIf( null != IsAutomaticForward ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsAutomaticForward) : null, "isAutomaticForward" ,container.Add );
            AddIf( null != IsAutomaticReply ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsAutomaticReply) : null, "isAutomaticReply" ,container.Add );
            AddIf( null != IsEncrypted ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsEncrypted) : null, "isEncrypted" ,container.Add );
            AddIf( null != IsMeetingRequest ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsMeetingRequest) : null, "isMeetingRequest" ,container.Add );
            AddIf( null != IsMeetingResponse ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsMeetingResponse) : null, "isMeetingResponse" ,container.Add );
            AddIf( null != IsNonDeliveryReport ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsNonDeliveryReport) : null, "isNonDeliveryReport" ,container.Add );
            AddIf( null != IsPermissionControlled ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsPermissionControlled) : null, "isPermissionControlled" ,container.Add );
            AddIf( null != IsReadReceipt ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsReadReceipt) : null, "isReadReceipt" ,container.Add );
            AddIf( null != IsSigned ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsSigned) : null, "isSigned" ,container.Add );
            AddIf( null != IsVoicemail ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsVoicemail) : null, "isVoicemail" ,container.Add );
            AddIf( null != (((object)MessageActionFlag)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MessageActionFlag.ToString()) : null, "messageActionFlag" ,container.Add );
            AddIf( null != NotSentToMe ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)NotSentToMe) : null, "notSentToMe" ,container.Add );
            if (null != RecipientContains)
            {
                var ___x = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___y in RecipientContains )
                {
                    AddIf(null != (((object)___y)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(___y.ToString()) : null ,___x.Add);
                }
                container.Add("recipientContains",___x);
            }
            if (null != SenderContains)
            {
                var ___s = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___t in SenderContains )
                {
                    AddIf(null != (((object)___t)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(___t.ToString()) : null ,___s.Add);
                }
                container.Add("senderContains",___s);
            }
            AddIf( null != (((object)Sensitivity)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Sensitivity.ToString()) : null, "sensitivity" ,container.Add );
            AddIf( null != SentCcMe ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)SentCcMe) : null, "sentCcMe" ,container.Add );
            AddIf( null != SentOnlyToMe ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)SentOnlyToMe) : null, "sentOnlyToMe" ,container.Add );
            if (null != SentToAddresses)
            {
                var ___n = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___o in SentToAddresses )
                {
                    AddIf(___o?.ToJson(null, serializationMode) ,___n.Add);
                }
                container.Add("sentToAddresses",___n);
            }
            AddIf( null != SentToMe ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)SentToMe) : null, "sentToMe" ,container.Add );
            AddIf( null != SentToOrCcMe ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)SentToOrCcMe) : null, "sentToOrCcMe" ,container.Add );
            if (null != SubjectContains)
            {
                var ___i = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___j in SubjectContains )
                {
                    AddIf(null != (((object)___j)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(___j.ToString()) : null ,___i.Add);
                }
                container.Add("subjectContains",___i);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}