namespace Sample.API.Models
{

    /// <summary>Device Configuration State for a given device.</summary>
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1TypeConverter))]
    public partial class ComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1
    {

        /// <summary>
        /// Creates a new instance of <see cref="ComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1" />, deserializing
        /// the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Device Configuration State for a given device.
    [System.ComponentModel.TypeConverter(typeof(ComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1TypeConverter))]
    public partial interface IComponentsSchemasMicrosoftGraphDeviceconfigurationstateAllof1 {

    }
}