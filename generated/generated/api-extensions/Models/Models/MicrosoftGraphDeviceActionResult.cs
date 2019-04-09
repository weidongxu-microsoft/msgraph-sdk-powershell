namespace Sample.API.Models
{

    /// <summary>deviceActionResult</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphDeviceActionResultTypeConverter))]
    public partial class MicrosoftGraphDeviceActionResult
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphDeviceActionResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphDeviceActionResult FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// deviceActionResult
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphDeviceActionResultTypeConverter))]
    public partial interface IMicrosoftGraphDeviceActionResult {

    }
}