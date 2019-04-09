namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharingDetail</summary>
    public partial class MicrosoftGraphSharingDetail
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphSharingDetail.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphSharingDetail.</returns>
        public static Sample.API.Models.IMicrosoftGraphSharingDetail FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphSharingDetail(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphSharingDetail" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphSharingDetail(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sharedBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sharedBy"), out var __jsonSharedBy) ? Sample.API.Models.MicrosoftGraphInsightIdentity.FromJson(__jsonSharedBy) : SharedBy;}
            {_sharingReference = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sharingReference"), out var __jsonSharingReference) ? Sample.API.Models.MicrosoftGraphResourceReference.FromJson(__jsonSharingReference) : SharingReference;}
            {_sharedDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sharedDateTime"), out var __jsonSharedDateTime) ? System.DateTime.TryParse((string)__jsonSharedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonSharedDateTimeValue) ? __jsonSharedDateTimeValue : SharedDateTime : SharedDateTime;}
            {_sharingSubject = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sharingSubject"), out var __jsonSharingSubject) ? (string)__jsonSharingSubject : (string)SharingSubject;}
            {_sharingType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sharingType"), out var __jsonSharingType) ? (string)__jsonSharingType : (string)SharingType;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphSharingDetail" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphSharingDetail" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != SharedBy ? (Sample.API.Runtime.Json.JsonNode) SharedBy.ToJson(null,serializationMode) : null, "sharedBy" ,container.Add );
            AddIf( null != SharingReference ? (Sample.API.Runtime.Json.JsonNode) SharingReference.ToJson(null,serializationMode) : null, "sharingReference" ,container.Add );
            AddIf( null != SharedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SharedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "sharedDateTime" ,container.Add );
            AddIf( null != (((object)SharingSubject)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SharingSubject.ToString()) : null, "sharingSubject" ,container.Add );
            AddIf( null != (((object)SharingType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SharingType.ToString()) : null, "sharingType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}