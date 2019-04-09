namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>driveItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphDriveitemAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphDriveitemAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphDriveitemAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_audio = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("audio"), out var __jsonAudio) ? Sample.API.Models.MicrosoftGraphAudio.FromJson(__jsonAudio) : Audio;}
            {_deleted = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("deleted"), out var __jsonDeleted) ? Sample.API.Models.MicrosoftGraphDeleted.FromJson(__jsonDeleted) : Deleted;}
            {_file = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("file"), out var __jsonFile) ? Sample.API.Models.MicrosoftGraphFile.FromJson(__jsonFile) : File;}
            {_fileSystemInfo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("fileSystemInfo"), out var __jsonFileSystemInfo) ? Sample.API.Models.MicrosoftGraphFileSystemInfo.FromJson(__jsonFileSystemInfo) : FileSystemInfo;}
            {_folder = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("folder"), out var __jsonFolder) ? Sample.API.Models.MicrosoftGraphFolder.FromJson(__jsonFolder) : Folder;}
            {_image = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("image"), out var __jsonImage) ? Sample.API.Models.MicrosoftGraphImage.FromJson(__jsonImage) : Image;}
            {_location = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("location"), out var __jsonLocation) ? Sample.API.Models.MicrosoftGraphGeoCoordinates.FromJson(__jsonLocation) : Location;}
            {_package = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("package"), out var __jsonPackage) ? Sample.API.Models.MicrosoftGraphPackage.FromJson(__jsonPackage) : Package;}
            {_photo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("photo"), out var __jsonPhoto) ? Sample.API.Models.MicrosoftGraphPhoto.FromJson(__jsonPhoto) : Photo;}
            {_publication = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("publication"), out var __jsonPublication) ? Sample.API.Models.MicrosoftGraphPublicationFacet.FromJson(__jsonPublication) : Publication;}
            {_searchResult = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("searchResult"), out var __jsonSearchResult) ? Sample.API.Models.MicrosoftGraphSearchResult.FromJson(__jsonSearchResult) : SearchResult;}
            {_shared = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("shared"), out var __jsonShared) ? Sample.API.Models.MicrosoftGraphShared.FromJson(__jsonShared) : Shared;}
            {_sharepointIds = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("sharepointIds"), out var __jsonSharepointIds) ? Sample.API.Models.MicrosoftGraphSharepointIds.FromJson(__jsonSharepointIds) : SharepointIds;}
            {_specialFolder = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("specialFolder"), out var __jsonSpecialFolder) ? Sample.API.Models.MicrosoftGraphSpecialFolder.FromJson(__jsonSpecialFolder) : SpecialFolder;}
            {_video = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("video"), out var __jsonVideo) ? Sample.API.Models.MicrosoftGraphVideo.FromJson(__jsonVideo) : Video;}
            {_cTag = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("cTag"), out var __jsonCTag) ? (string)__jsonCTag : (string)CTag;}
            {_children = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("children"), out var __jsonChildren) ? If( __jsonChildren as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDriveItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphDriveItem) (Sample.API.Models.MicrosoftGraphDriveItem.FromJson(__u) )) ))() : null : Children;}
            {_content = null /* deserializeFromContainerMember doesn't support 'application/json' C:\Users\deagrawa\.autorest\@microsoft.azure_autorest.csharp-v2@2.0.227\node_modules\@microsoft.azure\autorest.csharp-v2\dist\schema\byte-array.js*/;}
            {_listItem = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("listItem"), out var __jsonListItem) ? Sample.API.Models.MicrosoftGraphListItem.FromJson(__jsonListItem) : ListItem;}
            {_permissions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("permissions"), out var __jsonPermissions) ? If( __jsonPermissions as Sample.API.Runtime.Json.JsonArray, out var __p) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphPermission[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__p, (__o)=>(Sample.API.Models.IMicrosoftGraphPermission) (Sample.API.Models.MicrosoftGraphPermission.FromJson(__o) )) ))() : null : Permissions;}
            {_root = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("root"), out var __jsonRoot) ? Sample.API.Models.MicrosoftGraphRoot.FromJson(__jsonRoot) : Root;}
            {_size = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("size"), out var __jsonSize) ? (long?)__jsonSize : Size;}
            {_thumbnails = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("thumbnails"), out var __jsonThumbnails) ? If( __jsonThumbnails as Sample.API.Runtime.Json.JsonArray, out var __k) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphThumbnailSet[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__k, (__j)=>(Sample.API.Models.IMicrosoftGraphThumbnailSet) (Sample.API.Models.MicrosoftGraphThumbnailSet.FromJson(__j) )) ))() : null : Thumbnails;}
            {_versions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("versions"), out var __jsonVersions) ? If( __jsonVersions as Sample.API.Runtime.Json.JsonArray, out var __f) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDriveItemVersion[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__f, (__e)=>(Sample.API.Models.IMicrosoftGraphDriveItemVersion) (Sample.API.Models.MicrosoftGraphDriveItemVersion.FromJson(__e) )) ))() : null : Versions;}
            {_webDavUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("webDavUrl"), out var __jsonWebDavUrl) ? (string)__jsonWebDavUrl : (string)WebDavUrl;}
            {_workbook = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("workbook"), out var __jsonWorkbook) ? Sample.API.Models.MicrosoftGraphWorkbook.FromJson(__jsonWorkbook) : Workbook;}
            {_remoteItem = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("remoteItem"), out var __jsonRemoteItem) ? Sample.API.Models.MicrosoftGraphRemoteItem.FromJson(__jsonRemoteItem) : RemoteItem;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphDriveitemAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphDriveitemAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphDriveitemAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Audio ? (Sample.API.Runtime.Json.JsonNode) Audio.ToJson(null,serializationMode) : null, "audio" ,container.Add );
            AddIf( null != Deleted ? (Sample.API.Runtime.Json.JsonNode) Deleted.ToJson(null,serializationMode) : null, "deleted" ,container.Add );
            AddIf( null != File ? (Sample.API.Runtime.Json.JsonNode) File.ToJson(null,serializationMode) : null, "file" ,container.Add );
            AddIf( null != FileSystemInfo ? (Sample.API.Runtime.Json.JsonNode) FileSystemInfo.ToJson(null,serializationMode) : null, "fileSystemInfo" ,container.Add );
            AddIf( null != Folder ? (Sample.API.Runtime.Json.JsonNode) Folder.ToJson(null,serializationMode) : null, "folder" ,container.Add );
            AddIf( null != Image ? (Sample.API.Runtime.Json.JsonNode) Image.ToJson(null,serializationMode) : null, "image" ,container.Add );
            AddIf( null != Location ? (Sample.API.Runtime.Json.JsonNode) Location.ToJson(null,serializationMode) : null, "location" ,container.Add );
            AddIf( null != Package ? (Sample.API.Runtime.Json.JsonNode) Package.ToJson(null,serializationMode) : null, "package" ,container.Add );
            AddIf( null != Photo ? (Sample.API.Runtime.Json.JsonNode) Photo.ToJson(null,serializationMode) : null, "photo" ,container.Add );
            AddIf( null != Publication ? (Sample.API.Runtime.Json.JsonNode) Publication.ToJson(null,serializationMode) : null, "publication" ,container.Add );
            AddIf( null != SearchResult ? (Sample.API.Runtime.Json.JsonNode) SearchResult.ToJson(null,serializationMode) : null, "searchResult" ,container.Add );
            AddIf( null != Shared ? (Sample.API.Runtime.Json.JsonNode) Shared.ToJson(null,serializationMode) : null, "shared" ,container.Add );
            AddIf( null != SharepointIds ? (Sample.API.Runtime.Json.JsonNode) SharepointIds.ToJson(null,serializationMode) : null, "sharepointIds" ,container.Add );
            AddIf( null != SpecialFolder ? (Sample.API.Runtime.Json.JsonNode) SpecialFolder.ToJson(null,serializationMode) : null, "specialFolder" ,container.Add );
            AddIf( null != Video ? (Sample.API.Runtime.Json.JsonNode) Video.ToJson(null,serializationMode) : null, "video" ,container.Add );
            AddIf( null != (((object)CTag)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CTag.ToString()) : null, "cTag" ,container.Add );
            if (null != Children)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Children )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("children",__w);
            }
            /* serializeToContainerMember doesn't support 'application/json' C:\Users\deagrawa\.autorest\@microsoft.azure_autorest.csharp-v2@2.0.227\node_modules\@microsoft.azure\autorest.csharp-v2\dist\schema\byte-array.js*/
            AddIf( null != ListItem ? (Sample.API.Runtime.Json.JsonNode) ListItem.ToJson(null,serializationMode) : null, "listItem" ,container.Add );
            if (null != Permissions)
            {
                var __q = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __r in Permissions )
                {
                    AddIf(__r?.ToJson(null, serializationMode) ,__q.Add);
                }
                container.Add("permissions",__q);
            }
            AddIf( null != Root ? (Sample.API.Runtime.Json.JsonNode) Root.ToJson(null,serializationMode) : null, "root" ,container.Add );
            AddIf( null != Size ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)Size) : null, "size" ,container.Add );
            if (null != Thumbnails)
            {
                var __l = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __m in Thumbnails )
                {
                    AddIf(__m?.ToJson(null, serializationMode) ,__l.Add);
                }
                container.Add("thumbnails",__l);
            }
            if (null != Versions)
            {
                var __g = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __h in Versions )
                {
                    AddIf(__h?.ToJson(null, serializationMode) ,__g.Add);
                }
                container.Add("versions",__g);
            }
            AddIf( null != (((object)WebDavUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(WebDavUrl.ToString()) : null, "webDavUrl" ,container.Add );
            AddIf( null != Workbook ? (Sample.API.Runtime.Json.JsonNode) Workbook.ToJson(null,serializationMode) : null, "workbook" ,container.Add );
            AddIf( null != RemoteItem ? (Sample.API.Runtime.Json.JsonNode) RemoteItem.ToJson(null,serializationMode) : null, "remoteItem" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}