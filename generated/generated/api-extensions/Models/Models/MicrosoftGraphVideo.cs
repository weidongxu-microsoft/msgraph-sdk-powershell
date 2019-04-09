namespace Sample.API.Models
{

    /// <summary>video</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphVideoTypeConverter))]
    public partial class MicrosoftGraphVideo
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphVideo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphVideo FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// video
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphVideoTypeConverter))]
    public partial interface IMicrosoftGraphVideo {

    }
}