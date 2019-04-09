namespace Sample.API.Models
{

    /// <summary>FIXME: Class MicrosoftGraphManagedAppOperation is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphManagedAppOperationTypeConverter))]
    public partial class MicrosoftGraphManagedAppOperation
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphManagedAppOperation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphManagedAppOperation FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IMicrosoftGraphManagedAppOperation is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphManagedAppOperationTypeConverter))]
    public partial interface IMicrosoftGraphManagedAppOperation {

    }
}