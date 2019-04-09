namespace Sample.API.Models
{

    /// <summary>plannerUserIds</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerUserIdsTypeConverter))]
    public partial class MicrosoftGraphPlannerUserIds
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphPlannerUserIds" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphPlannerUserIds FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// plannerUserIds
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerUserIdsTypeConverter))]
    public partial interface IMicrosoftGraphPlannerUserIds {

    }
}