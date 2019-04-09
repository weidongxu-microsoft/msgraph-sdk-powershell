namespace Sample.API.Models
{

    /// <summary>FIXME: Class MicrosoftGraphPlannerTaskDetails is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerTaskDetailsTypeConverter))]
    public partial class MicrosoftGraphPlannerTaskDetails
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphPlannerTaskDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphPlannerTaskDetails FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IMicrosoftGraphPlannerTaskDetails is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerTaskDetailsTypeConverter))]
    public partial interface IMicrosoftGraphPlannerTaskDetails {

    }
}