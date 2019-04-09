namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerTask</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannertaskAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphPlannertaskAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphPlannertaskAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_completedBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("completedBy"), out var __jsonCompletedBy) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonCompletedBy) : CompletedBy;}
            {_createdBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("createdBy"), out var __jsonCreatedBy) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonCreatedBy) : CreatedBy;}
            {_activeChecklistItemCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("activeChecklistItemCount"), out var __jsonActiveChecklistItemCount) ? (int?)__jsonActiveChecklistItemCount : ActiveChecklistItemCount;}
            {_appliedCategories = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("appliedCategories"), out var __jsonAppliedCategories) ? Sample.API.Models.MicrosoftGraphPlannerAppliedCategories.FromJson(__jsonAppliedCategories) : AppliedCategories;}
            {_assignedToTaskBoardFormat = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("assignedToTaskBoardFormat"), out var __jsonAssignedToTaskBoardFormat) ? Sample.API.Models.MicrosoftGraphPlannerAssignedToTaskBoardTaskFormat.FromJson(__jsonAssignedToTaskBoardFormat) : AssignedToTaskBoardFormat;}
            {_assigneePriority = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("assigneePriority"), out var __jsonAssigneePriority) ? (string)__jsonAssigneePriority : (string)AssigneePriority;}
            {_assignments = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("assignments"), out var __jsonAssignments) ? Sample.API.Models.MicrosoftGraphPlannerAssignments.FromJson(__jsonAssignments) : Assignments;}
            {_bucketId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("bucketId"), out var __jsonBucketId) ? (string)__jsonBucketId : (string)BucketId;}
            {_bucketTaskBoardFormat = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("bucketTaskBoardFormat"), out var __jsonBucketTaskBoardFormat) ? Sample.API.Models.MicrosoftGraphPlannerBucketTaskBoardTaskFormat.FromJson(__jsonBucketTaskBoardFormat) : BucketTaskBoardFormat;}
            {_checklistItemCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("checklistItemCount"), out var __jsonChecklistItemCount) ? (int?)__jsonChecklistItemCount : ChecklistItemCount;}
            {_completedDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("completedDateTime"), out var __jsonCompletedDateTime) ? System.DateTime.TryParse((string)__jsonCompletedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCompletedDateTimeValue) ? __jsonCompletedDateTimeValue : CompletedDateTime : CompletedDateTime;}
            {_conversationThreadId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("conversationThreadId"), out var __jsonConversationThreadId) ? (string)__jsonConversationThreadId : (string)ConversationThreadId;}
            {_createdDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("createdDateTime"), out var __jsonCreatedDateTime) ? System.DateTime.TryParse((string)__jsonCreatedDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedDateTimeValue) ? __jsonCreatedDateTimeValue : CreatedDateTime : CreatedDateTime;}
            {_dueDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("dueDateTime"), out var __jsonDueDateTime) ? System.DateTime.TryParse((string)__jsonDueDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonDueDateTimeValue) ? __jsonDueDateTimeValue : DueDateTime : DueDateTime;}
            {_hasDescription = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hasDescription"), out var __jsonHasDescription) ? (bool?)__jsonHasDescription : HasDescription;}
            {_orderHint = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("orderHint"), out var __jsonOrderHint) ? (string)__jsonOrderHint : (string)OrderHint;}
            {_percentComplete = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("percentComplete"), out var __jsonPercentComplete) ? (int?)__jsonPercentComplete : PercentComplete;}
            {_planId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("planId"), out var __jsonPlanId) ? (string)__jsonPlanId : (string)PlanId;}
            {_previewType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("previewType"), out var __jsonPreviewType) ? (string)__jsonPreviewType : (string)PreviewType;}
            {_progressTaskBoardFormat = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("progressTaskBoardFormat"), out var __jsonProgressTaskBoardFormat) ? Sample.API.Models.MicrosoftGraphPlannerProgressTaskBoardTaskFormat.FromJson(__jsonProgressTaskBoardFormat) : ProgressTaskBoardFormat;}
            {_referenceCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("referenceCount"), out var __jsonReferenceCount) ? (int?)__jsonReferenceCount : ReferenceCount;}
            {_startDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("startDateTime"), out var __jsonStartDateTime) ? System.DateTime.TryParse((string)__jsonStartDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartDateTimeValue) ? __jsonStartDateTimeValue : StartDateTime : StartDateTime;}
            {_title = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            {_details = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("details"), out var __jsonDetails) ? Sample.API.Models.MicrosoftGraphPlannerTaskDetails.FromJson(__jsonDetails) : Details;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphPlannertaskAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphPlannertaskAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphPlannertaskAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != CompletedBy ? (Sample.API.Runtime.Json.JsonNode) CompletedBy.ToJson(null,serializationMode) : null, "completedBy" ,container.Add );
            AddIf( null != CreatedBy ? (Sample.API.Runtime.Json.JsonNode) CreatedBy.ToJson(null,serializationMode) : null, "createdBy" ,container.Add );
            AddIf( null != ActiveChecklistItemCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)ActiveChecklistItemCount) : null, "activeChecklistItemCount" ,container.Add );
            AddIf( null != AppliedCategories ? (Sample.API.Runtime.Json.JsonNode) AppliedCategories.ToJson(null,serializationMode) : null, "appliedCategories" ,container.Add );
            AddIf( null != AssignedToTaskBoardFormat ? (Sample.API.Runtime.Json.JsonNode) AssignedToTaskBoardFormat.ToJson(null,serializationMode) : null, "assignedToTaskBoardFormat" ,container.Add );
            AddIf( null != (((object)AssigneePriority)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AssigneePriority.ToString()) : null, "assigneePriority" ,container.Add );
            AddIf( null != Assignments ? (Sample.API.Runtime.Json.JsonNode) Assignments.ToJson(null,serializationMode) : null, "assignments" ,container.Add );
            AddIf( null != (((object)BucketId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BucketId.ToString()) : null, "bucketId" ,container.Add );
            AddIf( null != BucketTaskBoardFormat ? (Sample.API.Runtime.Json.JsonNode) BucketTaskBoardFormat.ToJson(null,serializationMode) : null, "bucketTaskBoardFormat" ,container.Add );
            AddIf( null != ChecklistItemCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)ChecklistItemCount) : null, "checklistItemCount" ,container.Add );
            AddIf( null != CompletedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CompletedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "completedDateTime" ,container.Add );
            AddIf( null != (((object)ConversationThreadId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ConversationThreadId.ToString()) : null, "conversationThreadId" ,container.Add );
            AddIf( null != CreatedDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CreatedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "createdDateTime" ,container.Add );
            AddIf( null != DueDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DueDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "dueDateTime" ,container.Add );
            AddIf( null != HasDescription ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HasDescription) : null, "hasDescription" ,container.Add );
            AddIf( null != (((object)OrderHint)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OrderHint.ToString()) : null, "orderHint" ,container.Add );
            AddIf( null != PercentComplete ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)PercentComplete) : null, "percentComplete" ,container.Add );
            AddIf( null != (((object)PlanId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PlanId.ToString()) : null, "planId" ,container.Add );
            AddIf( null != (((object)PreviewType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PreviewType.ToString()) : null, "previewType" ,container.Add );
            AddIf( null != ProgressTaskBoardFormat ? (Sample.API.Runtime.Json.JsonNode) ProgressTaskBoardFormat.ToJson(null,serializationMode) : null, "progressTaskBoardFormat" ,container.Add );
            AddIf( null != ReferenceCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)ReferenceCount) : null, "referenceCount" ,container.Add );
            AddIf( null != StartDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(StartDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "startDateTime" ,container.Add );
            AddIf( null != (((object)Title)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Title.ToString()) : null, "title" ,container.Add );
            AddIf( null != Details ? (Sample.API.Runtime.Json.JsonNode) Details.ToJson(null,serializationMode) : null, "details" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}