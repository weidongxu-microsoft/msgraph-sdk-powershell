namespace Sample.API.Models
{

    /// <summary>pageLinks</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPageLinksTypeConverter))]
    public partial class MicrosoftGraphPageLinks
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphPageLinks" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphPageLinks FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// pageLinks
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPageLinksTypeConverter))]
    public partial interface IMicrosoftGraphPageLinks {

    }
}