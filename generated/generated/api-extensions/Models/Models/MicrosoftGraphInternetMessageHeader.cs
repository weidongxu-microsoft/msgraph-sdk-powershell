namespace Sample.API.Models
{

    /// <summary>internetMessageHeader</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphInternetMessageHeaderTypeConverter))]
    public partial class MicrosoftGraphInternetMessageHeader
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphInternetMessageHeader" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphInternetMessageHeader FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// internetMessageHeader
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphInternetMessageHeaderTypeConverter))]
    public partial interface IMicrosoftGraphInternetMessageHeader {

    }
}