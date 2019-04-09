namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookWorksheetProtectionOptions</summary>
    public partial class MicrosoftGraphWorkbookWorksheetProtectionOptions
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions.
        /// </returns>
        public static Sample.API.Models.IMicrosoftGraphWorkbookWorksheetProtectionOptions FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphWorkbookWorksheetProtectionOptions(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphWorkbookWorksheetProtectionOptions"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphWorkbookWorksheetProtectionOptions(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_allowAutoFilter = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowAutoFilter"), out var __jsonAllowAutoFilter) ? (bool?)__jsonAllowAutoFilter : AllowAutoFilter;}
            {_allowDeleteColumns = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowDeleteColumns"), out var __jsonAllowDeleteColumns) ? (bool?)__jsonAllowDeleteColumns : AllowDeleteColumns;}
            {_allowDeleteRows = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowDeleteRows"), out var __jsonAllowDeleteRows) ? (bool?)__jsonAllowDeleteRows : AllowDeleteRows;}
            {_allowFormatCells = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowFormatCells"), out var __jsonAllowFormatCells) ? (bool?)__jsonAllowFormatCells : AllowFormatCells;}
            {_allowFormatColumns = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowFormatColumns"), out var __jsonAllowFormatColumns) ? (bool?)__jsonAllowFormatColumns : AllowFormatColumns;}
            {_allowFormatRows = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowFormatRows"), out var __jsonAllowFormatRows) ? (bool?)__jsonAllowFormatRows : AllowFormatRows;}
            {_allowInsertColumns = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowInsertColumns"), out var __jsonAllowInsertColumns) ? (bool?)__jsonAllowInsertColumns : AllowInsertColumns;}
            {_allowInsertHyperlinks = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowInsertHyperlinks"), out var __jsonAllowInsertHyperlinks) ? (bool?)__jsonAllowInsertHyperlinks : AllowInsertHyperlinks;}
            {_allowInsertRows = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowInsertRows"), out var __jsonAllowInsertRows) ? (bool?)__jsonAllowInsertRows : AllowInsertRows;}
            {_allowPivotTables = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowPivotTables"), out var __jsonAllowPivotTables) ? (bool?)__jsonAllowPivotTables : AllowPivotTables;}
            {_allowSort = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("allowSort"), out var __jsonAllowSort) ? (bool?)__jsonAllowSort : AllowSort;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphWorkbookWorksheetProtectionOptions" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphWorkbookWorksheetProtectionOptions" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != AllowAutoFilter ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowAutoFilter) : null, "allowAutoFilter" ,container.Add );
            AddIf( null != AllowDeleteColumns ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowDeleteColumns) : null, "allowDeleteColumns" ,container.Add );
            AddIf( null != AllowDeleteRows ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowDeleteRows) : null, "allowDeleteRows" ,container.Add );
            AddIf( null != AllowFormatCells ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowFormatCells) : null, "allowFormatCells" ,container.Add );
            AddIf( null != AllowFormatColumns ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowFormatColumns) : null, "allowFormatColumns" ,container.Add );
            AddIf( null != AllowFormatRows ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowFormatRows) : null, "allowFormatRows" ,container.Add );
            AddIf( null != AllowInsertColumns ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowInsertColumns) : null, "allowInsertColumns" ,container.Add );
            AddIf( null != AllowInsertHyperlinks ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowInsertHyperlinks) : null, "allowInsertHyperlinks" ,container.Add );
            AddIf( null != AllowInsertRows ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowInsertRows) : null, "allowInsertRows" ,container.Add );
            AddIf( null != AllowPivotTables ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowPivotTables) : null, "allowPivotTables" ,container.Add );
            AddIf( null != AllowSort ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AllowSort) : null, "allowSort" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}