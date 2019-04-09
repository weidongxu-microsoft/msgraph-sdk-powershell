namespace Sample.API.Models
{

    /// <summary>onenoteEntityHierarchyModel</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1" />, deserializing
        /// the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// onenoteEntityHierarchyModel
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 {

    }
}