namespace Sample.API.Models
{

    /// <summary>onenote</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphOnenoteAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphOnenoteAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphOnenoteAllof1" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// onenote
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphOnenoteAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteAllof1 {

    }
}