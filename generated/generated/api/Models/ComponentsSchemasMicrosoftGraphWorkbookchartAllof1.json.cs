namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChart</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphWorkbookchartAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_format = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("format"), out var __jsonFormat) ? Sample.API.Models.MicrosoftGraphWorkbookChartAreaFormat.FromJson(__jsonFormat) : Format;}
            {_axes = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("axes"), out var __jsonAxes) ? Sample.API.Models.MicrosoftGraphWorkbookChartAxes.FromJson(__jsonAxes) : Axes;}
            {_dataLabels = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("dataLabels"), out var __jsonDataLabels) ? Sample.API.Models.MicrosoftGraphWorkbookChartDataLabels.FromJson(__jsonDataLabels) : DataLabels;}
            {_height = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("height"), out var __jsonHeight) ? (double?)__jsonHeight : Height;}
            {_left = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("left"), out var __jsonLeft) ? (double?)__jsonLeft : Left;}
            {_legend = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("legend"), out var __jsonLegend) ? Sample.API.Models.MicrosoftGraphWorkbookChartLegend.FromJson(__jsonLegend) : Legend;}
            {_series = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("series"), out var __jsonSeries) ? If( __jsonSeries as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWorkbookChartSeries[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphWorkbookChartSeries) (Sample.API.Models.MicrosoftGraphWorkbookChartSeries.FromJson(__u) )) ))() : null : Series;}
            {_title = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("title"), out var __jsonTitle) ? Sample.API.Models.MicrosoftGraphWorkbookChartTitle.FromJson(__jsonTitle) : Title;}
            {_top = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("top"), out var __jsonTop) ? (double?)__jsonTop : Top;}
            {_width = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("width"), out var __jsonWidth) ? (double?)__jsonWidth : Width;}
            {_worksheet = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("worksheet"), out var __jsonWorksheet) ? Sample.API.Models.MicrosoftGraphWorkbookWorksheet.FromJson(__jsonWorksheet) : Worksheet;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphWorkbookchartAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Format ? (Sample.API.Runtime.Json.JsonNode) Format.ToJson(null,serializationMode) : null, "format" ,container.Add );
            AddIf( null != Axes ? (Sample.API.Runtime.Json.JsonNode) Axes.ToJson(null,serializationMode) : null, "axes" ,container.Add );
            AddIf( null != DataLabels ? (Sample.API.Runtime.Json.JsonNode) DataLabels.ToJson(null,serializationMode) : null, "dataLabels" ,container.Add );
            AddIf( null != Height ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((double)Height) : null, "height" ,container.Add );
            AddIf( null != Left ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((double)Left) : null, "left" ,container.Add );
            AddIf( null != Legend ? (Sample.API.Runtime.Json.JsonNode) Legend.ToJson(null,serializationMode) : null, "legend" ,container.Add );
            if (null != Series)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Series )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("series",__w);
            }
            AddIf( null != Title ? (Sample.API.Runtime.Json.JsonNode) Title.ToJson(null,serializationMode) : null, "title" ,container.Add );
            AddIf( null != Top ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((double)Top) : null, "top" ,container.Add );
            AddIf( null != Width ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((double)Width) : null, "width" ,container.Add );
            AddIf( null != Worksheet ? (Sample.API.Runtime.Json.JsonNode) Worksheet.ToJson(null,serializationMode) : null, "worksheet" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}