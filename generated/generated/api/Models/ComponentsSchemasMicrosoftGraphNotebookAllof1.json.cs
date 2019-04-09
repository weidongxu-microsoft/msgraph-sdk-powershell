namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>notebook</summary>
    public partial class ComponentsSchemasMicrosoftGraphNotebookAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphNotebookAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphNotebookAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_links = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("links"), out var __jsonLinks) ? Sample.API.Models.MicrosoftGraphNotebookLinks.FromJson(__jsonLinks) : Links;}
            {_isDefault = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isDefault"), out var __jsonIsDefault) ? (bool?)__jsonIsDefault : IsDefault;}
            {_isShared = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isShared"), out var __jsonIsShared) ? (bool?)__jsonIsShared : IsShared;}
            {_sectionGroups = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("sectionGroups"), out var __jsonSectionGroups) ? If( __jsonSectionGroups as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSectionGroup[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphSectionGroup) (Sample.API.Models.MicrosoftGraphSectionGroup.FromJson(__u) )) ))() : null : SectionGroups;}
            {_sectionGroupsUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sectionGroupsUrl"), out var __jsonSectionGroupsUrl) ? (string)__jsonSectionGroupsUrl : (string)SectionGroupsUrl;}
            {_sections = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("sections"), out var __jsonSections) ? If( __jsonSections as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphOnenoteSection[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphOnenoteSection) (Sample.API.Models.MicrosoftGraphOnenoteSection.FromJson(__p) )) ))() : null : Sections;}
            {_sectionsUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("sectionsUrl"), out var __jsonSectionsUrl) ? (string)__jsonSectionsUrl : (string)SectionsUrl;}
            {_userRole = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userRole"), out var __jsonUserRole) ? (string)__jsonUserRole : (string)UserRole;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphNotebookAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphNotebookAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphNotebookAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphNotebookAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphNotebookAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphNotebookAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != Links ? (Sample.API.Runtime.Json.JsonNode) Links.ToJson(null,serializationMode) : null, "links" ,container.Add );
            AddIf( null != IsDefault ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsDefault) : null, "isDefault" ,container.Add );
            AddIf( null != IsShared ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsShared) : null, "isShared" ,container.Add );
            if (null != SectionGroups)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in SectionGroups )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("sectionGroups",__w);
            }
            AddIf( null != (((object)SectionGroupsUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SectionGroupsUrl.ToString()) : null, "sectionGroupsUrl" ,container.Add );
            if (null != Sections)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Sections )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("sections",__r);
            }
            AddIf( null != (((object)SectionsUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SectionsUrl.ToString()) : null, "sectionsUrl" ,container.Add );
            AddIf( null != (((object)UserRole)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserRole.ToString()) : null, "userRole" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}