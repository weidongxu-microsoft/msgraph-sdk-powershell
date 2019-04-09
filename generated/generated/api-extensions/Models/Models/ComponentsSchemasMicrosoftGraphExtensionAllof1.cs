namespace Sample.API.Models
{

    /// <summary>extension</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphExtensionAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphExtensionAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphExtensionAllof1" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphExtensionAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// extension
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphExtensionAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphExtensionAllof1 {

    }
}