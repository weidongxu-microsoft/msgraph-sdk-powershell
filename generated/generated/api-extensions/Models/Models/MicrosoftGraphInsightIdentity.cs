namespace Sample.API.Models
{

    /// <summary>insightIdentity</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphInsightIdentityTypeConverter))]
    public partial class MicrosoftGraphInsightIdentity
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphInsightIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphInsightIdentity FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// insightIdentity
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphInsightIdentityTypeConverter))]
    public partial interface IMicrosoftGraphInsightIdentity {

    }
}