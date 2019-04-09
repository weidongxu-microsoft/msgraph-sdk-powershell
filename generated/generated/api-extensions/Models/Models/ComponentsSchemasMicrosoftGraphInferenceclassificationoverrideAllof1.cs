namespace Sample.API.Models
{

    /// <summary>inferenceClassificationOverride</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1" />, deserializing
        /// the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// inferenceClassificationOverride
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 {

    }
}