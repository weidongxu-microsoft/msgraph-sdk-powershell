namespace Sample.API.Models
{

    /// <summary>configurationManagerClientEnabledFeatures</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphConfigurationManagerClientEnabledFeaturesTypeConverter))]
    public partial class MicrosoftGraphConfigurationManagerClientEnabledFeatures
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphConfigurationManagerClientEnabledFeatures" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// configurationManagerClientEnabledFeatures
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphConfigurationManagerClientEnabledFeaturesTypeConverter))]
    public partial interface IMicrosoftGraphConfigurationManagerClientEnabledFeatures {

    }
}