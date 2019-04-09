namespace Sample.API.Models
{

    /// <summary>plannerChecklistItems</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerChecklistItemsTypeConverter))]
    public partial class MicrosoftGraphPlannerChecklistItems
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphPlannerChecklistItems" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphPlannerChecklistItems FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// plannerChecklistItems
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphPlannerChecklistItemsTypeConverter))]
    public partial interface IMicrosoftGraphPlannerChecklistItems {

    }
}