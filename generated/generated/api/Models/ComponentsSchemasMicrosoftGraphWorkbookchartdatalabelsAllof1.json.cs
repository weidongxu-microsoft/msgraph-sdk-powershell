namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartDataLabels</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_format = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("format"), out var __jsonFormat) ? Sample.API.Models.MicrosoftGraphWorkbookChartDataLabelFormat.FromJson(__jsonFormat) : Format;}
            {_position = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("position"), out var __jsonPosition) ? (string)__jsonPosition : (string)Position;}
            {_separator = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("separator"), out var __jsonSeparator) ? (string)__jsonSeparator : (string)Separator;}
            {_showBubbleSize = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showBubbleSize"), out var __jsonShowBubbleSize) ? (bool?)__jsonShowBubbleSize : ShowBubbleSize;}
            {_showCategoryName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showCategoryName"), out var __jsonShowCategoryName) ? (bool?)__jsonShowCategoryName : ShowCategoryName;}
            {_showLegendKey = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showLegendKey"), out var __jsonShowLegendKey) ? (bool?)__jsonShowLegendKey : ShowLegendKey;}
            {_showPercentage = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showPercentage"), out var __jsonShowPercentage) ? (bool?)__jsonShowPercentage : ShowPercentage;}
            {_showSeriesName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showSeriesName"), out var __jsonShowSeriesName) ? (bool?)__jsonShowSeriesName : ShowSeriesName;}
            {_showValue = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("showValue"), out var __jsonShowValue) ? (bool?)__jsonShowValue : ShowValue;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelsAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Format ? (Sample.API.Runtime.Json.JsonNode) Format.ToJson(null,serializationMode) : null, "format" ,container.Add );
            AddIf( null != (((object)Position)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Position.ToString()) : null, "position" ,container.Add );
            AddIf( null != (((object)Separator)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Separator.ToString()) : null, "separator" ,container.Add );
            AddIf( null != ShowBubbleSize ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowBubbleSize) : null, "showBubbleSize" ,container.Add );
            AddIf( null != ShowCategoryName ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowCategoryName) : null, "showCategoryName" ,container.Add );
            AddIf( null != ShowLegendKey ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowLegendKey) : null, "showLegendKey" ,container.Add );
            AddIf( null != ShowPercentage ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowPercentage) : null, "showPercentage" ,container.Add );
            AddIf( null != ShowSeriesName ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowSeriesName) : null, "showSeriesName" ,container.Add );
            AddIf( null != ShowValue ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ShowValue) : null, "showValue" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}