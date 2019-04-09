namespace Sample.API.Models
{

    /// <summary>sharedInsight</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphSharedinsightAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphSharedinsightAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphSharedinsightAllof1" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphSharedinsightAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// sharedInsight
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphSharedinsightAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphSharedinsightAllof1 {

    }
}