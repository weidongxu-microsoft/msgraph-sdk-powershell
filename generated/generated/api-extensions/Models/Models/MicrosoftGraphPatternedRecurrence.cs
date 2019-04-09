namespace Sample.API.Models
{

    /// <summary>patternedRecurrence</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPatternedRecurrenceTypeConverter))]
    public partial class MicrosoftGraphPatternedRecurrence
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphPatternedRecurrence" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphPatternedRecurrence FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// patternedRecurrence
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPatternedRecurrenceTypeConverter))]
    public partial interface IMicrosoftGraphPatternedRecurrence {

    }
}