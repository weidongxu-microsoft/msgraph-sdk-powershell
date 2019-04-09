namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookTable</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbooktableAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbooktableAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphWorkbooktableAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_columns = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("columns"), out var __jsonColumns) ? If( __jsonColumns as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWorkbookTableColumn[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphWorkbookTableColumn) (Sample.API.Models.MicrosoftGraphWorkbookTableColumn.FromJson(__u) )) ))() : null : Columns;}
            {_highlightFirstColumn = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("highlightFirstColumn"), out var __jsonHighlightFirstColumn) ? (bool?)__jsonHighlightFirstColumn : HighlightFirstColumn;}
            {_highlightLastColumn = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("highlightLastColumn"), out var __jsonHighlightLastColumn) ? (bool?)__jsonHighlightLastColumn : HighlightLastColumn;}
            {_rows = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("rows"), out var __jsonRows) ? If( __jsonRows as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWorkbookTableRow[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphWorkbookTableRow) (Sample.API.Models.MicrosoftGraphWorkbookTableRow.FromJson(__p) )) ))() : null : Rows;}
            {_showBandedColumns = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showBandedColumns"), out var __jsonShowBandedColumns) ? (bool?)__jsonShowBandedColumns : ShowBandedColumns;}
            {_showBandedRows = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showBandedRows"), out var __jsonShowBandedRows) ? (bool?)__jsonShowBandedRows : ShowBandedRows;}
            {_showFilterButton = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showFilterButton"), out var __jsonShowFilterButton) ? (bool?)__jsonShowFilterButton : ShowFilterButton;}
            {_showHeaders = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showHeaders"), out var __jsonShowHeaders) ? (bool?)__jsonShowHeaders : ShowHeaders;}
            {_showTotals = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showTotals"), out var __jsonShowTotals) ? (bool?)__jsonShowTotals : ShowTotals;}
            {_sort = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sort"), out var __jsonSort) ? Sample.API.Models.MicrosoftGraphWorkbookTableSort.FromJson(__jsonSort) : Sort;}
            {_style = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("style"), out var __jsonStyle) ? (string)__jsonStyle : (string)Style;}
            {_worksheet = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("worksheet"), out var __jsonWorksheet) ? Sample.API.Models.MicrosoftGraphWorkbookWorksheet.FromJson(__jsonWorksheet) : Worksheet;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktableAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktableAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktableAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphWorkbooktableAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbooktableAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbooktableAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            if (null != Columns)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Columns )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("columns",__w);
            }
            AddIf( null != HighlightFirstColumn ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HighlightFirstColumn) : null, "highlightFirstColumn" ,container.Add );
            AddIf( null != HighlightLastColumn ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HighlightLastColumn) : null, "highlightLastColumn" ,container.Add );
            if (null != Rows)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Rows )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("rows",__r);
            }
            AddIf( null != ShowBandedColumns ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowBandedColumns) : null, "showBandedColumns" ,container.Add );
            AddIf( null != ShowBandedRows ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowBandedRows) : null, "showBandedRows" ,container.Add );
            AddIf( null != ShowFilterButton ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowFilterButton) : null, "showFilterButton" ,container.Add );
            AddIf( null != ShowHeaders ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowHeaders) : null, "showHeaders" ,container.Add );
            AddIf( null != ShowTotals ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowTotals) : null, "showTotals" ,container.Add );
            AddIf( null != Sort ? (Sample.API.Runtime.Json.JsonNode) Sort.ToJson(null,serializationMode) : null, "sort" ,container.Add );
            AddIf( null != (((object)Style)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Style.ToString()) : null, "style" ,container.Add );
            AddIf( null != Worksheet ? (Sample.API.Runtime.Json.JsonNode) Worksheet.ToJson(null,serializationMode) : null, "worksheet" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}