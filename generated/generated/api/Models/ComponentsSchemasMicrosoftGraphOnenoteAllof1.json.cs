namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenote</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenoteAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphOnenoteAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphOnenoteAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_notebooks = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("notebooks"), out var __jsonNotebooks) ? If( __jsonNotebooks as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphNotebook[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphNotebook) (Sample.API.Models.MicrosoftGraphNotebook.FromJson(__u) )) ))() : null : Notebooks;}
            {_pages = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("pages"), out var __jsonPages) ? If( __jsonPages as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphOnenotePage[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphOnenotePage) (Sample.API.Models.MicrosoftGraphOnenotePage.FromJson(__p) )) ))() : null : Pages;}
            {_resources = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("resources"), out var __jsonResources) ? If( __jsonResources as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphOnenoteResource[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphOnenoteResource) (Sample.API.Models.MicrosoftGraphOnenoteResource.FromJson(__k) )) ))() : null : Resources;}
            {_sectionGroups = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("sectionGroups"), out var __jsonSectionGroups) ? If( __jsonSectionGroups as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSectionGroup[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphSectionGroup) (Sample.API.Models.MicrosoftGraphSectionGroup.FromJson(__f) )) ))() : null : SectionGroups;}
            {_sections = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("sections"), out var __jsonSections) ? If( __jsonSections as Sample.API.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphOnenoteSection[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Sample.API.Models.IMicrosoftGraphOnenoteSection) (Sample.API.Models.MicrosoftGraphOnenoteSection.FromJson(__a) )) ))() : null : Sections;}
            {_operations = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("operations"), out var __jsonOperations) ? If( __jsonOperations as Sample.API.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphOnenoteOperation[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(Sample.API.Models.IMicrosoftGraphOnenoteOperation) (Sample.API.Models.MicrosoftGraphOnenoteOperation.FromJson(___v) )) ))() : null : Operations;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphOnenoteAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphOnenoteAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphOnenoteAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            if (null != Notebooks)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Notebooks )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("notebooks",__w);
            }
            if (null != Pages)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Pages )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("pages",__r);
            }
            if (null != Resources)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in Resources )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("resources",__m);
            }
            if (null != SectionGroups)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in SectionGroups )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("sectionGroups",__h);
            }
            if (null != Sections)
            {
                var __c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __d in Sections )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("sections",__c);
            }
            if (null != Operations)
            {
                var ___x = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___y in Operations )
                {
                    AddIf(___y?.ToJson(null, serializationMode) ,___x.Add);
                }
                container.Add("operations",___x);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}