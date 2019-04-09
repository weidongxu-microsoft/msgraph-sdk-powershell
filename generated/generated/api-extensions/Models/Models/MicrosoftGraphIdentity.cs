namespace Sample.API.Models
{

    /// <summary>identity</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphIdentityTypeConverter))]
    public partial class MicrosoftGraphIdentity
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphIdentity FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// identity
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphIdentityTypeConverter))]
    public partial interface IMicrosoftGraphIdentity {

    }
}