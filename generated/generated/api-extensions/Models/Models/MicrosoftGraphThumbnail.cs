namespace Sample.API.Models
{

    /// <summary>thumbnail</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphThumbnailTypeConverter))]
    public partial class MicrosoftGraphThumbnail
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphThumbnail" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphThumbnail FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// thumbnail
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphThumbnailTypeConverter))]
    public partial interface IMicrosoftGraphThumbnail {

    }
}