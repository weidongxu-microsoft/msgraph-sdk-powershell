namespace Sample.API.Models
{

    /// <summary>shared</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphSharedTypeConverter))]
    public partial class MicrosoftGraphShared
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphShared" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphShared FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// shared
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphSharedTypeConverter))]
    public partial interface IMicrosoftGraphShared {

    }
}