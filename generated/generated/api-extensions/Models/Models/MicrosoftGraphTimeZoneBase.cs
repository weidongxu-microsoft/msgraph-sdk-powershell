namespace Sample.API.Models
{

    /// <summary>timeZoneBase</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphTimeZoneBaseTypeConverter))]
    public partial class MicrosoftGraphTimeZoneBase
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphTimeZoneBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphTimeZoneBase FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// timeZoneBase
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphTimeZoneBaseTypeConverter))]
    public partial interface IMicrosoftGraphTimeZoneBase {

    }
}