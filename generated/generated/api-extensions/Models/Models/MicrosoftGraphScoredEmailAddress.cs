namespace Sample.API.Models
{

    /// <summary>scoredEmailAddress</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphScoredEmailAddressTypeConverter))]
    public partial class MicrosoftGraphScoredEmailAddress
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphScoredEmailAddress" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphScoredEmailAddress FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// scoredEmailAddress
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphScoredEmailAddressTypeConverter))]
    public partial interface IMicrosoftGraphScoredEmailAddress {

    }
}