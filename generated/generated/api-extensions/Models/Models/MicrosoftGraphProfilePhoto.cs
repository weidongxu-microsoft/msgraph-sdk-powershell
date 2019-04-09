namespace Sample.API.Models
{

    /// <summary>FIXME: Class MicrosoftGraphProfilePhoto is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphProfilePhotoTypeConverter))]
    public partial class MicrosoftGraphProfilePhoto
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphProfilePhoto" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphProfilePhoto FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IMicrosoftGraphProfilePhoto is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphProfilePhotoTypeConverter))]
    public partial interface IMicrosoftGraphProfilePhoto {

    }
}