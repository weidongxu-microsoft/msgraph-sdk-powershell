namespace Sample.API.Models
{

    /// <summary>
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1" />, deserializing the
        /// content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 {

    }
}