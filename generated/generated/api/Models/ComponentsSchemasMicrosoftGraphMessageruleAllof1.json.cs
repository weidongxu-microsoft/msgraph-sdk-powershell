namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>messageRule</summary>
    public partial class ComponentsSchemasMicrosoftGraphMessageruleAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphMessageruleAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphMessageruleAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_actions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("actions"), out var __jsonActions) ? Sample.API.Models.MicrosoftGraphMessageRuleActions.FromJson(__jsonActions) : Actions;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_hasError = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hasError"), out var __jsonHasError) ? (bool?)__jsonHasError : HasError;}
            {_isEnabled = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isEnabled"), out var __jsonIsEnabled) ? (bool?)__jsonIsEnabled : IsEnabled;}
            {_isReadOnly = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isReadOnly"), out var __jsonIsReadOnly) ? (bool?)__jsonIsReadOnly : IsReadOnly;}
            {_sequence = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("sequence"), out var __jsonSequence) ? (int?)__jsonSequence : Sequence;}
            {_conditions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("conditions"), out var __jsonConditions) ? Sample.API.Models.MicrosoftGraphMessageRulePredicates.FromJson(__jsonConditions) : Conditions;}
            {_exceptions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("exceptions"), out var __jsonExceptions) ? Sample.API.Models.MicrosoftGraphMessageRulePredicates.FromJson(__jsonExceptions) : Exceptions;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageruleAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageruleAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageruleAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphMessageruleAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphMessageruleAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphMessageruleAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
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
            AddIf( null != Actions ? (Sample.API.Runtime.Json.JsonNode) Actions.ToJson(null,serializationMode) : null, "actions" ,container.Add );
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != HasError ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HasError) : null, "hasError" ,container.Add );
            AddIf( null != IsEnabled ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsEnabled) : null, "isEnabled" ,container.Add );
            AddIf( null != IsReadOnly ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsReadOnly) : null, "isReadOnly" ,container.Add );
            AddIf( null != Sequence ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Sequence) : null, "sequence" ,container.Add );
            AddIf( null != Conditions ? (Sample.API.Runtime.Json.JsonNode) Conditions.ToJson(null,serializationMode) : null, "conditions" ,container.Add );
            AddIf( null != Exceptions ? (Sample.API.Runtime.Json.JsonNode) Exceptions.ToJson(null,serializationMode) : null, "exceptions" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}