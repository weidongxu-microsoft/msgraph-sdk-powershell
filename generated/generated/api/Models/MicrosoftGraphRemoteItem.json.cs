namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>remoteItem</summary>
    public partial class MicrosoftGraphRemoteItem
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphRemoteItem.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphRemoteItem.</returns>
        public static Sample.API.Models.IMicrosoftGraphRemoteItem FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphRemoteItem(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphRemoteItem" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphRemoteItem(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_createdBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("createdBy"), out var __jsonCreatedBy) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonCreatedBy) : CreatedBy;}
            {_file = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("file"), out var __jsonFile) ? Sample.API.Models.MicrosoftGraphFile.FromJson(__jsonFile) : File;}
            {_fileSystemInfo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("fileSystemInfo"), out var __jsonFileSystemInfo) ? Sample.API.Models.MicrosoftGraphFileSystemInfo.FromJson(__jsonFileSystemInfo) : FileSystemInfo;}
            {_folder = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("folder"), out var __jsonFolder) ? Sample.API.Models.MicrosoftGraphFolder.FromJson(__jsonFolder) : Folder;}
            {_lastModifiedBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("lastModifiedBy"), out var __jsonLastModifiedBy) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonLastModifiedBy) : LastModifiedBy;}
            {_package = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("package"), out var __jsonPackage) ? Sample.API.Models.MicrosoftGraphPackage.FromJson(__jsonPackage) : Package;}
            {_parentReference = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("parentReference"), out var __jsonParentReference) ? Sample.API.Models.MicrosoftGraphItemReference.FromJson(__jsonParentReference) : ParentReference;}
            {_shared = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("shared"), out var __jsonShared) ? Sample.API.Models.MicrosoftGraphShared.FromJson(__jsonShared) : Shared;}
            {_sharepointIds = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sharepointIds"), out var __jsonSharepointIds) ? Sample.API.Models.MicrosoftGraphSharepointIds.FromJson(__jsonSharepointIds) : SharepointIds;}
            {_specialFolder = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("specialFolder"), out var __jsonSpecialFolder) ? Sample.API.Models.MicrosoftGraphSpecialFolder.FromJson(__jsonSpecialFolder) : SpecialFolder;}
            {_name = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_createdDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("createdDateTime"), out var __jsonCreatedDateTime) ? System.DateTime.TryParse((string)__jsonCreatedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedDateTimeValue) ? __jsonCreatedDateTimeValue : CreatedDateTime : CreatedDateTime;}
            {_id = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_lastModifiedDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("lastModifiedDateTime"), out var __jsonLastModifiedDateTime) ? System.DateTime.TryParse((string)__jsonLastModifiedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedDateTimeValue) ? __jsonLastModifiedDateTimeValue : LastModifiedDateTime : LastModifiedDateTime;}
            {_size = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("size"), out var __jsonSize) ? (long?)__jsonSize : Size;}
            {_webDavUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("webDavUrl"), out var __jsonWebDavUrl) ? (string)__jsonWebDavUrl : (string)WebDavUrl;}
            {_webUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("webUrl"), out var __jsonWebUrl) ? (string)__jsonWebUrl : (string)WebUrl;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphRemoteItem" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphRemoteItem" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != CreatedBy ? (Sample.API.Runtime.Json.JsonNode) CreatedBy.ToJson(null,serializationMode) : null, "createdBy" ,container.Add );
            AddIf( null != File ? (Sample.API.Runtime.Json.JsonNode) File.ToJson(null,serializationMode) : null, "file" ,container.Add );
            AddIf( null != FileSystemInfo ? (Sample.API.Runtime.Json.JsonNode) FileSystemInfo.ToJson(null,serializationMode) : null, "fileSystemInfo" ,container.Add );
            AddIf( null != Folder ? (Sample.API.Runtime.Json.JsonNode) Folder.ToJson(null,serializationMode) : null, "folder" ,container.Add );
            AddIf( null != LastModifiedBy ? (Sample.API.Runtime.Json.JsonNode) LastModifiedBy.ToJson(null,serializationMode) : null, "lastModifiedBy" ,container.Add );
            AddIf( null != Package ? (Sample.API.Runtime.Json.JsonNode) Package.ToJson(null,serializationMode) : null, "package" ,container.Add );
            AddIf( null != ParentReference ? (Sample.API.Runtime.Json.JsonNode) ParentReference.ToJson(null,serializationMode) : null, "parentReference" ,container.Add );
            AddIf( null != Shared ? (Sample.API.Runtime.Json.JsonNode) Shared.ToJson(null,serializationMode) : null, "shared" ,container.Add );
            AddIf( null != SharepointIds ? (Sample.API.Runtime.Json.JsonNode) SharepointIds.ToJson(null,serializationMode) : null, "sharepointIds" ,container.Add );
            AddIf( null != SpecialFolder ? (Sample.API.Runtime.Json.JsonNode) SpecialFolder.ToJson(null,serializationMode) : null, "specialFolder" ,container.Add );
            AddIf( null != (((object)Name)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Name.ToString()) : null, "name" ,container.Add );
            AddIf( null != CreatedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CreatedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "createdDateTime" ,container.Add );
            AddIf( null != (((object)Id)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Id.ToString()) : null, "id" ,container.Add );
            AddIf( null != LastModifiedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LastModifiedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModifiedDateTime" ,container.Add );
            AddIf( null != Size ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)Size) : null, "size" ,container.Add );
            AddIf( null != (((object)WebDavUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(WebDavUrl.ToString()) : null, "webDavUrl" ,container.Add );
            AddIf( null != (((object)WebUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(WebUrl.ToString()) : null, "webUrl" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}