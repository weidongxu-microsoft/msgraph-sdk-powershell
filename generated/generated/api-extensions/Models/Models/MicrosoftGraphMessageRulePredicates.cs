namespace Sample.API.Models
{

    /// <summary>messageRulePredicates</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphMessageRulePredicatesTypeConverter))]
    public partial class MicrosoftGraphMessageRulePredicates
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphMessageRulePredicates" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphMessageRulePredicates FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// messageRulePredicates
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphMessageRulePredicatesTypeConverter))]
    public partial interface IMicrosoftGraphMessageRulePredicates {

    }
}