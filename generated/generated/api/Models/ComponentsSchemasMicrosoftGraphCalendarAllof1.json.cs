namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>calendar</summary>
    public partial class ComponentsSchemasMicrosoftGraphCalendarAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphCalendarAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphCalendarAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_owner = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("owner"), out var __jsonOwner) ? Sample.API.Models.MicrosoftGraphEmailAddress.FromJson(__jsonOwner) : Owner;}
            {_name = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_calendarView = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("calendarView"), out var __jsonCalendarView) ? If( __jsonCalendarView as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphEvent[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphEvent) (Sample.API.Models.MicrosoftGraphEvent.FromJson(__u) )) ))() : null : CalendarView;}
            {_canEdit = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("canEdit"), out var __jsonCanEdit) ? (bool?)__jsonCanEdit : CanEdit;}
            {_canShare = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("canShare"), out var __jsonCanShare) ? (bool?)__jsonCanShare : CanShare;}
            {_canViewPrivateItems = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("canViewPrivateItems"), out var __jsonCanViewPrivateItems) ? (bool?)__jsonCanViewPrivateItems : CanViewPrivateItems;}
            {_changeKey = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("changeKey"), out var __jsonChangeKey) ? (string)__jsonChangeKey : (string)ChangeKey;}
            {_color = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("color"), out var __jsonColor) ? (string)__jsonColor : (string)Color;}
            {_events = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("events"), out var __jsonEvents) ? If( __jsonEvents as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphEvent[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphEvent) (Sample.API.Models.MicrosoftGraphEvent.FromJson(__p) )) ))() : null : Events;}
            {_multiValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("multiValueExtendedProperties"), out var __jsonMultiValueExtendedProperties) ? If( __jsonMultiValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphMultiValueLegacyExtendedProperty.FromJson(__k) )) ))() : null : MultiValueExtendedProperties;}
            {_singleValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("singleValueExtendedProperties"), out var __jsonSingleValueExtendedProperties) ? If( __jsonSingleValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphSingleValueLegacyExtendedProperty.FromJson(__f) )) ))() : null : SingleValueExtendedProperties;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendarAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendarAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendarAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphCalendarAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphCalendarAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphCalendarAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != (((object)Name)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Name.ToString()) : null, "name" ,container.Add );
            if (null != CalendarView)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in CalendarView )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("calendarView",__w);
            }
            AddIf( null != CanEdit ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)CanEdit) : null, "canEdit" ,container.Add );
            AddIf( null != CanShare ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)CanShare) : null, "canShare" ,container.Add );
            AddIf( null != CanViewPrivateItems ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)CanViewPrivateItems) : null, "canViewPrivateItems" ,container.Add );
            AddIf( null != (((object)ChangeKey)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ChangeKey.ToString()) : null, "changeKey" ,container.Add );
            AddIf( null != (((object)Color)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Color.ToString()) : null, "color" ,container.Add );
            if (null != Events)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Events )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("events",__r);
            }
            if (null != MultiValueExtendedProperties)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in MultiValueExtendedProperties )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("multiValueExtendedProperties",__m);
            }
            if (null != SingleValueExtendedProperties)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in SingleValueExtendedProperties )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("singleValueExtendedProperties",__h);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}