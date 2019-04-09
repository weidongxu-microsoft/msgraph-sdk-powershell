namespace Sample.API.Models
{

    /// <summary>FIXME: Class MicrosoftGraphPlannerTask is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerTaskTypeConverter))]
    public partial class MicrosoftGraphPlannerTask
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphPlannerTask" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphPlannerTask FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IMicrosoftGraphPlannerTask is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerTaskTypeConverter))]
    public partial interface IMicrosoftGraphPlannerTask {

    }
}