namespace Sample.API.Models
{

    /// <summary>servicePlanInfo</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphServicePlanInfoTypeConverter))]
    public partial class MicrosoftGraphServicePlanInfo
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphServicePlanInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphServicePlanInfo FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// servicePlanInfo
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphServicePlanInfoTypeConverter))]
    public partial interface IMicrosoftGraphServicePlanInfo {

    }
}