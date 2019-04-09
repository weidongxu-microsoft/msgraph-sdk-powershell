namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookWorksheet</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_charts = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("charts"), out var __jsonCharts) ? If( __jsonCharts as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWorkbookChart[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphWorkbookChart) (Sample.API.Models.MicrosoftGraphWorkbookChart.FromJson(__u) )) ))() : null : Charts;}
            {_names = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("names"), out var __jsonNames) ? If( __jsonNames as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphWorkbookNamedItem) (Sample.API.Models.MicrosoftGraphWorkbookNamedItem.FromJson(__p) )) ))() : null : Names;}
            {_pivotTables = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("pivotTables"), out var __jsonPivotTables) ? If( __jsonPivotTables as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWorkbookPivotTable[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphWorkbookPivotTable) (Sample.API.Models.MicrosoftGraphWorkbookPivotTable.FromJson(__k) )) ))() : null : PivotTables;}
            {_position = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("position"), out var __jsonPosition) ? (int?)__jsonPosition : Position;}
            {_protection = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("protection"), out var __jsonProtection) ? Sample.API.Models.MicrosoftGraphWorkbookWorksheetProtection.FromJson(__jsonProtection) : Protection;}
            {_tables = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("tables"), out var __jsonTables) ? If( __jsonTables as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWorkbookTable[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphWorkbookTable) (Sample.API.Models.MicrosoftGraphWorkbookTable.FromJson(__f) )) ))() : null : Tables;}
            {_visibility = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("visibility"), out var __jsonVisibility) ? (string)__jsonVisibility : (string)Visibility;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookworksheetAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != (((object)Name)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Name.ToString()) : null, "name" ,container.Add );
            if (null != Charts)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Charts )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("charts",__w);
            }
            if (null != Names)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Names )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("names",__r);
            }
            if (null != PivotTables)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in PivotTables )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("pivotTables",__m);
            }
            AddIf( null != Position ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Position) : null, "position" ,container.Add );
            AddIf( null != Protection ? (Sample.API.Runtime.Json.JsonNode) Protection.ToJson(null,serializationMode) : null, "protection" ,container.Add );
            if (null != Tables)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in Tables )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("tables",__h);
            }
            AddIf( null != (((object)Visibility)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Visibility.ToString()) : null, "visibility" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}