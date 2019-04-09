namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onPremisesExtensionAttributes</summary>
    public partial class MicrosoftGraphOnPremisesExtensionAttributes
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphOnPremisesExtensionAttributes.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphOnPremisesExtensionAttributes.</returns>
        public static Sample.API.Models.IMicrosoftGraphOnPremisesExtensionAttributes FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphOnPremisesExtensionAttributes(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphOnPremisesExtensionAttributes" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphOnPremisesExtensionAttributes(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_extensionAttribute1 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute1"), out var __jsonExtensionAttribute1) ? (string)__jsonExtensionAttribute1 : (string)ExtensionAttribute1;}
            {_extensionAttribute10 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute10"), out var __jsonExtensionAttribute10) ? (string)__jsonExtensionAttribute10 : (string)ExtensionAttribute10;}
            {_extensionAttribute11 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute11"), out var __jsonExtensionAttribute11) ? (string)__jsonExtensionAttribute11 : (string)ExtensionAttribute11;}
            {_extensionAttribute12 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute12"), out var __jsonExtensionAttribute12) ? (string)__jsonExtensionAttribute12 : (string)ExtensionAttribute12;}
            {_extensionAttribute13 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute13"), out var __jsonExtensionAttribute13) ? (string)__jsonExtensionAttribute13 : (string)ExtensionAttribute13;}
            {_extensionAttribute14 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute14"), out var __jsonExtensionAttribute14) ? (string)__jsonExtensionAttribute14 : (string)ExtensionAttribute14;}
            {_extensionAttribute15 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute15"), out var __jsonExtensionAttribute15) ? (string)__jsonExtensionAttribute15 : (string)ExtensionAttribute15;}
            {_extensionAttribute2 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute2"), out var __jsonExtensionAttribute2) ? (string)__jsonExtensionAttribute2 : (string)ExtensionAttribute2;}
            {_extensionAttribute3 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute3"), out var __jsonExtensionAttribute3) ? (string)__jsonExtensionAttribute3 : (string)ExtensionAttribute3;}
            {_extensionAttribute4 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute4"), out var __jsonExtensionAttribute4) ? (string)__jsonExtensionAttribute4 : (string)ExtensionAttribute4;}
            {_extensionAttribute5 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute5"), out var __jsonExtensionAttribute5) ? (string)__jsonExtensionAttribute5 : (string)ExtensionAttribute5;}
            {_extensionAttribute6 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute6"), out var __jsonExtensionAttribute6) ? (string)__jsonExtensionAttribute6 : (string)ExtensionAttribute6;}
            {_extensionAttribute7 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute7"), out var __jsonExtensionAttribute7) ? (string)__jsonExtensionAttribute7 : (string)ExtensionAttribute7;}
            {_extensionAttribute8 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute8"), out var __jsonExtensionAttribute8) ? (string)__jsonExtensionAttribute8 : (string)ExtensionAttribute8;}
            {_extensionAttribute9 = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("extensionAttribute9"), out var __jsonExtensionAttribute9) ? (string)__jsonExtensionAttribute9 : (string)ExtensionAttribute9;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphOnPremisesExtensionAttributes" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphOnPremisesExtensionAttributes" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != (((object)ExtensionAttribute1)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute1.ToString()) : null, "extensionAttribute1" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute10)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute10.ToString()) : null, "extensionAttribute10" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute11)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute11.ToString()) : null, "extensionAttribute11" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute12)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute12.ToString()) : null, "extensionAttribute12" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute13)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute13.ToString()) : null, "extensionAttribute13" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute14)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute14.ToString()) : null, "extensionAttribute14" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute15)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute15.ToString()) : null, "extensionAttribute15" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute2)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute2.ToString()) : null, "extensionAttribute2" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute3)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute3.ToString()) : null, "extensionAttribute3" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute4)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute4.ToString()) : null, "extensionAttribute4" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute5)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute5.ToString()) : null, "extensionAttribute5" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute6)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute6.ToString()) : null, "extensionAttribute6" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute7)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute7.ToString()) : null, "extensionAttribute7" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute8)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute8.ToString()) : null, "extensionAttribute8" ,container.Add );
            AddIf( null != (((object)ExtensionAttribute9)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ExtensionAttribute9.ToString()) : null, "extensionAttribute9" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}