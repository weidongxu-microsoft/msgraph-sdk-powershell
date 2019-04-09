namespace Sample.API.Models
{

    /// <summary>notebook</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphNotebookAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphNotebookAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphNotebookAllof1" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphNotebookAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// notebook
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphNotebookAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphNotebookAllof1 {

    }
}