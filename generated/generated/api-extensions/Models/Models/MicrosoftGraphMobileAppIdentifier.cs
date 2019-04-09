namespace Sample.API.Models
{

    /// <summary>mobileAppIdentifier</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphMobileAppIdentifierTypeConverter))]
    public partial class MicrosoftGraphMobileAppIdentifier
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphMobileAppIdentifier" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphMobileAppIdentifier FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// mobileAppIdentifier
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphMobileAppIdentifierTypeConverter))]
    public partial interface IMicrosoftGraphMobileAppIdentifier {

    }
}