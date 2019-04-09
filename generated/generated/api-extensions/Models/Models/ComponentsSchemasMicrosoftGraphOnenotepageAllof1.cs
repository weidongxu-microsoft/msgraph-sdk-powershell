namespace Sample.API.Models
{

    /// <summary>onenotePage</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphOnenotepageAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphOnenotepageAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphOnenotepageAllof1" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotepageAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// onenotePage
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphOnenotepageAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphOnenotepageAllof1 {

    }
}