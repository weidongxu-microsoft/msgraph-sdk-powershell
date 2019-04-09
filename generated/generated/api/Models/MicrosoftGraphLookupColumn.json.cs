namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>lookupColumn</summary>
    public partial class MicrosoftGraphLookupColumn
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphLookupColumn.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphLookupColumn.</returns>
        public static Sample.API.Models.IMicrosoftGraphLookupColumn FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphLookupColumn(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphLookupColumn" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphLookupColumn(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_allowMultipleValues = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowMultipleValues"), out var __jsonAllowMultipleValues) ? (bool?)__jsonAllowMultipleValues : AllowMultipleValues;}
            {_allowUnlimitedLength = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowUnlimitedLength"), out var __jsonAllowUnlimitedLength) ? (bool?)__jsonAllowUnlimitedLength : AllowUnlimitedLength;}
            {_columnName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("columnName"), out var __jsonColumnName) ? (string)__jsonColumnName : (string)ColumnName;}
            {_listId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("listId"), out var __jsonListId) ? (string)__jsonListId : (string)ListId;}
            {_primaryLookupColumnId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("primaryLookupColumnId"), out var __jsonPrimaryLookupColumnId) ? (string)__jsonPrimaryLookupColumnId : (string)PrimaryLookupColumnId;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphLookupColumn" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphLookupColumn" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != AllowMultipleValues ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowMultipleValues) : null, "allowMultipleValues" ,container.Add );
            AddIf( null != AllowUnlimitedLength ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowUnlimitedLength) : null, "allowUnlimitedLength" ,container.Add );
            AddIf( null != (((object)ColumnName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ColumnName.ToString()) : null, "columnName" ,container.Add );
            AddIf( null != (((object)ListId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ListId.ToString()) : null, "listId" ,container.Add );
            AddIf( null != (((object)PrimaryLookupColumnId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PrimaryLookupColumnId.ToString()) : null, "primaryLookupColumnId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}