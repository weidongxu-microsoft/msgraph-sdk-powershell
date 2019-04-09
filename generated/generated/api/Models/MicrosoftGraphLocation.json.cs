namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>location</summary>
    public partial class MicrosoftGraphLocation
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Sample.API.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Sample.API.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Sample.API.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Sample.API.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Sample.API.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphLocation.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphLocation.</returns>
        public static Sample.API.Models.IMicrosoftGraphLocation FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphLocation(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphLocation" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphLocation(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_address = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("address"), out var __jsonAddress) ? Sample.API.Models.MicrosoftGraphPhysicalAddress.FromJson(__jsonAddress) : Address;}
            {_coordinates = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("coordinates"), out var __jsonCoordinates) ? Sample.API.Models.MicrosoftGraphOutlookGeoCoordinates.FromJson(__jsonCoordinates) : Coordinates;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_locationEmailAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("locationEmailAddress"), out var __jsonLocationEmailAddress) ? (string)__jsonLocationEmailAddress : (string)LocationEmailAddress;}
            {_locationType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("locationType"), out var __jsonLocationType) ? (string)__jsonLocationType : (string)LocationType;}
            {_locationUri = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("locationUri"), out var __jsonLocationUri) ? (string)__jsonLocationUri : (string)LocationUri;}
            {_uniqueId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("uniqueId"), out var __jsonUniqueId) ? (string)__jsonUniqueId : (string)UniqueId;}
            {_uniqueIdType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("uniqueIdType"), out var __jsonUniqueIdType) ? (string)__jsonUniqueIdType : (string)UniqueIdType;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphLocation" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphLocation" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </returns>
        public Sample.API.Runtime.Json.JsonNode ToJson(Sample.API.Runtime.Json.JsonObject container, Sample.API.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Sample.API.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != Address ? (Sample.API.Runtime.Json.JsonNode) Address.ToJson(null,serializationMode) : null, "address" ,container.Add );
            AddIf( null != Coordinates ? (Sample.API.Runtime.Json.JsonNode) Coordinates.ToJson(null,serializationMode) : null, "coordinates" ,container.Add );
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)LocationEmailAddress)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LocationEmailAddress.ToString()) : null, "locationEmailAddress" ,container.Add );
            AddIf( null != (((object)LocationType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LocationType.ToString()) : null, "locationType" ,container.Add );
            AddIf( null != (((object)LocationUri)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LocationUri.ToString()) : null, "locationUri" ,container.Add );
            AddIf( null != (((object)UniqueId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UniqueId.ToString()) : null, "uniqueId" ,container.Add );
            AddIf( null != (((object)UniqueIdType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UniqueIdType.ToString()) : null, "uniqueIdType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}