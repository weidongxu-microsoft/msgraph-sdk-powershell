namespace Sample.API.Models
{

    /// <summary>dateTimeTimeZone</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphDateTimeZoneTypeConverter))]
    public partial class MicrosoftGraphDateTimeZone
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphDateTimeZone" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphDateTimeZone FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// dateTimeTimeZone
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphDateTimeZoneTypeConverter))]
    public partial interface IMicrosoftGraphDateTimeZone {

    }
}