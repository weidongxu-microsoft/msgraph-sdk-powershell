namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerPlan</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannerplanAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphPlannerplanAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphPlannerplanAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_createdBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("createdBy"), out var __jsonCreatedBy) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonCreatedBy) : CreatedBy;}
            {_buckets = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("buckets"), out var __jsonBuckets) ? If( __jsonBuckets as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphPlannerBucket[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphPlannerBucket) (Sample.API.Models.MicrosoftGraphPlannerBucket.FromJson(__u) )) ))() : null : Buckets;}
            {_createdDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("createdDateTime"), out var __jsonCreatedDateTime) ? System.DateTime.TryParse((string)__jsonCreatedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedDateTimeValue) ? __jsonCreatedDateTimeValue : CreatedDateTime : CreatedDateTime;}
            {_owner = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("owner"), out var __jsonOwner) ? (string)__jsonOwner : (string)Owner;}
            {_tasks = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("tasks"), out var __jsonTasks) ? If( __jsonTasks as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphPlannerTask[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphPlannerTask) (Sample.API.Models.MicrosoftGraphPlannerTask.FromJson(__p) )) ))() : null : Tasks;}
            {_title = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            {_details = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("details"), out var __jsonDetails) ? Sample.API.Models.MicrosoftGraphPlannerPlanDetails.FromJson(__jsonDetails) : Details;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplanAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplanAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplanAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphPlannerplanAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphPlannerplanAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphPlannerplanAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != CreatedBy ? (Sample.API.Runtime.Json.JsonNode) CreatedBy.ToJson(null,serializationMode) : null, "createdBy" ,container.Add );
            if (null != Buckets)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Buckets )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("buckets",__w);
            }
            AddIf( null != CreatedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CreatedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "createdDateTime" ,container.Add );
            AddIf( null != (((object)Owner)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Owner.ToString()) : null, "owner" ,container.Add );
            if (null != Tasks)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Tasks )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("tasks",__r);
            }
            AddIf( null != (((object)Title)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Title.ToString()) : null, "title" ,container.Add );
            AddIf( null != Details ? (Sample.API.Runtime.Json.JsonNode) Details.ToJson(null,serializationMode) : null, "details" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}