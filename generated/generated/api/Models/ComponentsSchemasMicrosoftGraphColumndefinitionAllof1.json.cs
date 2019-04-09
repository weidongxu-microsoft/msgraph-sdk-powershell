namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>columnDefinition</summary>
    public partial class ComponentsSchemasMicrosoftGraphColumndefinitionAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphColumndefinitionAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphColumndefinitionAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_calculated = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("calculated"), out var __jsonCalculated) ? Sample.API.Models.MicrosoftGraphCalculatedColumn.FromJson(__jsonCalculated) : Calculated;}
            {_choice = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("choice"), out var __jsonChoice) ? Sample.API.Models.MicrosoftGraphChoiceColumn.FromJson(__jsonChoice) : Choice;}
            {_currency = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("currency"), out var __jsonCurrency) ? Sample.API.Models.MicrosoftGraphCurrencyColumn.FromJson(__jsonCurrency) : Currency;}
            {_dateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("dateTime"), out var __jsonDateTime) ? Sample.API.Models.MicrosoftGraphDateTimeColumn.FromJson(__jsonDateTime) : DateTime;}
            {_defaultValue = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("defaultValue"), out var __jsonDefaultValue) ? Sample.API.Models.MicrosoftGraphDefaultColumnValue.FromJson(__jsonDefaultValue) : DefaultValue;}
            {_lookup = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("lookup"), out var __jsonLookup) ? Sample.API.Models.MicrosoftGraphLookupColumn.FromJson(__jsonLookup) : Lookup;}
            {_number = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("number"), out var __jsonNumber) ? Sample.API.Models.MicrosoftGraphNumberColumn.FromJson(__jsonNumber) : Number;}
            {_personOrGroup = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("personOrGroup"), out var __jsonPersonOrGroup) ? Sample.API.Models.MicrosoftGraphPersonOrGroupColumn.FromJson(__jsonPersonOrGroup) : PersonOrGroup;}
            {_text = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("text"), out var __jsonText) ? Sample.API.Models.MicrosoftGraphTextColumn.FromJson(__jsonText) : Text;}
            {_name = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_description = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_boolean = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("boolean"), out var __jsonBoolean) ? Sample.API.Models.MicrosoftGraphBooleanColumn.FromJson(__jsonBoolean) : Boolean;}
            {_columnGroup = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("columnGroup"), out var __jsonColumnGroup) ? (string)__jsonColumnGroup : (string)ColumnGroup;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_enforceUniqueValues = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("enforceUniqueValues"), out var __jsonEnforceUniqueValues) ? (bool?)__jsonEnforceUniqueValues : EnforceUniqueValues;}
            {_hidden = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hidden"), out var __jsonHidden) ? (bool?)__jsonHidden : Hidden;}
            {_indexed = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("indexed"), out var __jsonIndexed) ? (bool?)__jsonIndexed : Indexed;}
            {_readOnly = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("readOnly"), out var __jsonReadOnly) ? (bool?)__jsonReadOnly : ReadOnly;}
            {_required = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("required"), out var __jsonRequired) ? (bool?)__jsonRequired : Required;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphColumndefinitionAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphColumndefinitionAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphColumndefinitionAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphColumndefinitionAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphColumndefinitionAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphColumndefinitionAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Calculated ? (Sample.API.Runtime.Json.JsonNode) Calculated.ToJson(null,serializationMode) : null, "calculated" ,container.Add );
            AddIf( null != Choice ? (Sample.API.Runtime.Json.JsonNode) Choice.ToJson(null,serializationMode) : null, "choice" ,container.Add );
            AddIf( null != Currency ? (Sample.API.Runtime.Json.JsonNode) Currency.ToJson(null,serializationMode) : null, "currency" ,container.Add );
            AddIf( null != DateTime ? (Sample.API.Runtime.Json.JsonNode) DateTime.ToJson(null,serializationMode) : null, "dateTime" ,container.Add );
            AddIf( null != DefaultValue ? (Sample.API.Runtime.Json.JsonNode) DefaultValue.ToJson(null,serializationMode) : null, "defaultValue" ,container.Add );
            AddIf( null != Lookup ? (Sample.API.Runtime.Json.JsonNode) Lookup.ToJson(null,serializationMode) : null, "lookup" ,container.Add );
            AddIf( null != Number ? (Sample.API.Runtime.Json.JsonNode) Number.ToJson(null,serializationMode) : null, "number" ,container.Add );
            AddIf( null != PersonOrGroup ? (Sample.API.Runtime.Json.JsonNode) PersonOrGroup.ToJson(null,serializationMode) : null, "personOrGroup" ,container.Add );
            AddIf( null != Text ? (Sample.API.Runtime.Json.JsonNode) Text.ToJson(null,serializationMode) : null, "text" ,container.Add );
            AddIf( null != (((object)Name)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)Description)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Description.ToString()) : null, "description" ,container.Add );
            AddIf( null != Boolean ? (Sample.API.Runtime.Json.JsonNode) Boolean.ToJson(null,serializationMode) : null, "boolean" ,container.Add );
            AddIf( null != (((object)ColumnGroup)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ColumnGroup.ToString()) : null, "columnGroup" ,container.Add );
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != EnforceUniqueValues ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)EnforceUniqueValues) : null, "enforceUniqueValues" ,container.Add );
            AddIf( null != Hidden ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)Hidden) : null, "hidden" ,container.Add );
            AddIf( null != Indexed ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)Indexed) : null, "indexed" ,container.Add );
            AddIf( null != ReadOnly ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)ReadOnly) : null, "readOnly" ,container.Add );
            AddIf( null != Required ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)Required) : null, "required" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}