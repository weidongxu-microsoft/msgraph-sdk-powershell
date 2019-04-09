namespace Sample.API.Models
{

    /// <summary>lookupColumn</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphLookupColumnTypeConverter))]
    public partial class MicrosoftGraphLookupColumn
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphLookupColumn" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphLookupColumn FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// lookupColumn
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphLookupColumnTypeConverter))]
    public partial interface IMicrosoftGraphLookupColumn {

    }
}