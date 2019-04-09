namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>event</summary>
    public partial class ComponentsSchemasMicrosoftGraphEventAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphEventAllof1" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphEventAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_body = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("body"), out var __jsonBody) ? Sample.API.Models.MicrosoftGraphItemBody.FromJson(__jsonBody) : Body;}
            {_end = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("end"), out var __jsonEnd) ? Sample.API.Models.MicrosoftGraphDateTimeZone.FromJson(__jsonEnd) : End;}
            {_location = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("location"), out var __jsonLocation) ? Sample.API.Models.MicrosoftGraphLocation.FromJson(__jsonLocation) : Location;}
            {_organizer = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("organizer"), out var __jsonOrganizer) ? Sample.API.Models.MicrosoftGraphRecipient.FromJson(__jsonOrganizer) : Organizer;}
            {_recurrence = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("recurrence"), out var __jsonRecurrence) ? Sample.API.Models.MicrosoftGraphPatternedRecurrence.FromJson(__jsonRecurrence) : Recurrence;}
            {_responseStatus = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("responseStatus"), out var __jsonResponseStatus) ? Sample.API.Models.MicrosoftGraphResponseStatus.FromJson(__jsonResponseStatus) : ResponseStatus;}
            {_start = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("start"), out var __jsonStart) ? Sample.API.Models.MicrosoftGraphDateTimeZone.FromJson(__jsonStart) : Start;}
            {_type = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_attachments = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("attachments"), out var __jsonAttachments) ? If( __jsonAttachments as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphAttachment[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphAttachment) (Sample.API.Models.MicrosoftGraphAttachment.FromJson(__u) )) ))() : null : Attachments;}
            {_attendees = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("attendees"), out var __jsonAttendees) ? If( __jsonAttendees as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphAttendee[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphAttendee) (Sample.API.Models.MicrosoftGraphAttendee.FromJson(__p) )) ))() : null : Attendees;}
            {_bodyPreview = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bodyPreview"), out var __jsonBodyPreview) ? (string)__jsonBodyPreview : (string)BodyPreview;}
            {_calendar = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("calendar"), out var __jsonCalendar) ? Sample.API.Models.MicrosoftGraphCalendar.FromJson(__jsonCalendar) : Calendar;}
            {_hasAttachments = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hasAttachments"), out var __jsonHasAttachments) ? (bool?)__jsonHasAttachments : HasAttachments;}
            {_iCalUId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("iCalUId"), out var __jsonICalUId) ? (string)__jsonICalUId : (string)ICalUId;}
            {_importance = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("importance"), out var __jsonImportance) ? (string)__jsonImportance : (string)Importance;}
            {_instances = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("instances"), out var __jsonInstances) ? If( __jsonInstances as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphEvent[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphEvent) (Sample.API.Models.MicrosoftGraphEvent.FromJson(__k) )) ))() : null : Instances;}
            {_isAllDay = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isAllDay"), out var __jsonIsAllDay) ? (bool?)__jsonIsAllDay : IsAllDay;}
            {_isCancelled = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isCancelled"), out var __jsonIsCancelled) ? (bool?)__jsonIsCancelled : IsCancelled;}
            {_isOrganizer = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isOrganizer"), out var __jsonIsOrganizer) ? (bool?)__jsonIsOrganizer : IsOrganizer;}
            {_isReminderOn = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isReminderOn"), out var __jsonIsReminderOn) ? (bool?)__jsonIsReminderOn : IsReminderOn;}
            {_locations = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("locations"), out var __jsonLocations) ? If( __jsonLocations as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphLocation[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphLocation) (Sample.API.Models.MicrosoftGraphLocation.FromJson(__f) )) ))() : null : Locations;}
            {_multiValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("multiValueExtendedProperties"), out var __jsonMultiValueExtendedProperties) ? If( __jsonMultiValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphMultiValueLegacyExtendedProperty.FromJson(__a) )) ))() : null : MultiValueExtendedProperties;}
            {_onlineMeetingUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("onlineMeetingUrl"), out var __jsonOnlineMeetingUrl) ? (string)__jsonOnlineMeetingUrl : (string)OnlineMeetingUrl;}
            {_originalEndTimeZone = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("originalEndTimeZone"), out var __jsonOriginalEndTimeZone) ? (string)__jsonOriginalEndTimeZone : (string)OriginalEndTimeZone;}
            {_originalStart = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("originalStart"), out var __jsonOriginalStart) ? System.DateTime.TryParse((string)__jsonOriginalStart, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonOriginalStartValue) ? __jsonOriginalStartValue : OriginalStart : OriginalStart;}
            {_originalStartTimeZone = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("originalStartTimeZone"), out var __jsonOriginalStartTimeZone) ? (string)__jsonOriginalStartTimeZone : (string)OriginalStartTimeZone;}
            {_reminderMinutesBeforeStart = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("reminderMinutesBeforeStart"), out var __jsonReminderMinutesBeforeStart) ? (int?)__jsonReminderMinutesBeforeStart : ReminderMinutesBeforeStart;}
            {_responseRequested = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("responseRequested"), out var __jsonResponseRequested) ? (bool?)__jsonResponseRequested : ResponseRequested;}
            {_sensitivity = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sensitivity"), out var __jsonSensitivity) ? (string)__jsonSensitivity : (string)Sensitivity;}
            {_seriesMasterId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("seriesMasterId"), out var __jsonSeriesMasterId) ? (string)__jsonSeriesMasterId : (string)SeriesMasterId;}
            {_showAs = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("showAs"), out var __jsonShowAs) ? (string)__jsonShowAs : (string)ShowAs;}
            {_singleValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("singleValueExtendedProperties"), out var __jsonSingleValueExtendedProperties) ? If( __jsonSingleValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphSingleValueLegacyExtendedProperty.FromJson(___v) )) ))() : null : SingleValueExtendedProperties;}
            {_subject = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("subject"), out var __jsonSubject) ? (string)__jsonSubject : (string)Subject;}
            {_webLink = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("webLink"), out var __jsonWebLink) ? (string)__jsonWebLink : (string)WebLink;}
            {_extensions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("extensions"), out var __jsonExtensions) ? If( __jsonExtensions as Sample.API.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphExtension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___r, (___q)=>(Sample.API.Models.IMicrosoftGraphExtension) (Sample.API.Models.MicrosoftGraphExtension.FromJson(___q) )) ))() : null : Extensions;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphEventAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphEventAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphEventAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphEventAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphEventAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphEventAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != End ? (Sample.API.Runtime.Json.JsonNode) End.ToJson(null,serializationMode) : null, "end" ,container.Add );
            AddIf( null != Location ? (Sample.API.Runtime.Json.JsonNode) Location.ToJson(null,serializationMode) : null, "location" ,container.Add );
            AddIf( null != Organizer ? (Sample.API.Runtime.Json.JsonNode) Organizer.ToJson(null,serializationMode) : null, "organizer" ,container.Add );
            AddIf( null != Recurrence ? (Sample.API.Runtime.Json.JsonNode) Recurrence.ToJson(null,serializationMode) : null, "recurrence" ,container.Add );
            AddIf( null != ResponseStatus ? (Sample.API.Runtime.Json.JsonNode) ResponseStatus.ToJson(null,serializationMode) : null, "responseStatus" ,container.Add );
            AddIf( null != Start ? (Sample.API.Runtime.Json.JsonNode) Start.ToJson(null,serializationMode) : null, "start" ,container.Add );
            AddIf( null != (((object)Type)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Type.ToString()) : null, "type" ,container.Add );
            if (null != Attachments)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Attachments )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("attachments",__w);
            }
            if (null != Attendees)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Attendees )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("attendees",__r);
            }
            AddIf( null != (((object)BodyPreview)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BodyPreview.ToString()) : null, "bodyPreview" ,container.Add );
            AddIf( null != Calendar ? (Sample.API.Runtime.Json.JsonNode) Calendar.ToJson(null,serializationMode) : null, "calendar" ,container.Add );
            AddIf( null != HasAttachments ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HasAttachments) : null, "hasAttachments" ,container.Add );
            AddIf( null != (((object)ICalUId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ICalUId.ToString()) : null, "iCalUId" ,container.Add );
            AddIf( null != (((object)Importance)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Importance.ToString()) : null, "importance" ,container.Add );
            if (null != Instances)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in Instances )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("instances",__m);
            }
            AddIf( null != IsAllDay ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsAllDay) : null, "isAllDay" ,container.Add );
            AddIf( null != IsCancelled ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsCancelled) : null, "isCancelled" ,container.Add );
            AddIf( null != IsOrganizer ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsOrganizer) : null, "isOrganizer" ,container.Add );
            AddIf( null != IsReminderOn ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsReminderOn) : null, "isReminderOn" ,container.Add );
            if (null != Locations)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in Locations )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("locations",__h);
            }
            if (null != MultiValueExtendedProperties)
            {
                var __c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __d in MultiValueExtendedProperties )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("multiValueExtendedProperties",__c);
            }
            AddIf( null != (((object)OnlineMeetingUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OnlineMeetingUrl.ToString()) : null, "onlineMeetingUrl" ,container.Add );
            AddIf( null != (((object)OriginalEndTimeZone)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OriginalEndTimeZone.ToString()) : null, "originalEndTimeZone" ,container.Add );
            AddIf( null != OriginalStart ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OriginalStart?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "originalStart" ,container.Add );
            AddIf( null != (((object)OriginalStartTimeZone)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OriginalStartTimeZone.ToString()) : null, "originalStartTimeZone" ,container.Add );
            AddIf( null != ReminderMinutesBeforeStart ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)ReminderMinutesBeforeStart) : null, "reminderMinutesBeforeStart" ,container.Add );
            AddIf( null != ResponseRequested ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ResponseRequested) : null, "responseRequested" ,container.Add );
            AddIf( null != (((object)Sensitivity)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Sensitivity.ToString()) : null, "sensitivity" ,container.Add );
            AddIf( null != (((object)SeriesMasterId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SeriesMasterId.ToString()) : null, "seriesMasterId" ,container.Add );
            AddIf( null != (((object)ShowAs)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ShowAs.ToString()) : null, "showAs" ,container.Add );
            if (null != SingleValueExtendedProperties)
            {
                var ___x = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___y in SingleValueExtendedProperties )
                {
                    AddIf(___y?.ToJson(null, serializationMode) ,___x.Add);
                }
                container.Add("singleValueExtendedProperties",___x);
            }
            AddIf( null != (((object)Subject)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Subject.ToString()) : null, "subject" ,container.Add );
            AddIf( null != (((object)WebLink)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(WebLink.ToString()) : null, "webLink" ,container.Add );
            if (null != Extensions)
            {
                var ___s = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___t in Extensions )
                {
                    AddIf(___t?.ToJson(null, serializationMode) ,___s.Add);
                }
                container.Add("extensions",___s);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}