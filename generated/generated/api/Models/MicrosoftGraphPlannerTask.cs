namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerTask : Sample.API.Models.IMicrosoftGraphPlannerTask, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerTask" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskAllof1 _componentsSchemasMicrosoftGraphPlannertaskAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannertaskAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerTask" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public int? ActiveChecklistItemCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ActiveChecklistItemCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ActiveChecklistItemCount = value;
            }
        }
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ApplicationDisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ApplicationDisplayNameApplicationDisplayName = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ApplicationIdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ApplicationIdApplicationId = value;
            }
        }
        /// <summary>plannerAppliedCategories</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerAppliedCategories AppliedCategories
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .AppliedCategories;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .AppliedCategories = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .AssignedToTaskBoardFormat;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .AssignedToTaskBoardFormat = value;
            }
        }
        public string AssigneePriority
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .AssigneePriority;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .AssigneePriority = value;
            }
        }
        /// <summary>plannerAssignments</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerAssignments Assignments
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .Assignments;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .Assignments = value;
            }
        }
        public string BucketId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .BucketId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .BucketId = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .BucketTaskBoardFormat;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .BucketTaskBoardFormat = value;
            }
        }
        public int? ChecklistItemCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ChecklistItemCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ChecklistItemCount = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CompletedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CompletedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CompletedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CompletedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedByUser = value;
            }
        }
        public System.DateTime? CompletedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CompletedDateTime = value;
            }
        }
        public string ConversationThreadId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ConversationThreadId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ConversationThreadId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedByUser = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .CreatedDateTime = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerTaskDetails Details
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .Details;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .Details = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DeviceDisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DeviceDisplayNameDeviceDisplayName = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DeviceIdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DeviceIdDeviceId = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DisplayNameApplicationDisplayName = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DisplayNameDeviceDisplayName = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DisplayNameUserDisplayName = value;
            }
        }
        public System.DateTime? DueDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DueDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .DueDateTime = value;
            }
        }
        public bool? HasDescription
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .HasDescription;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .HasDescription = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .IdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .IdApplicationId = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .IdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .IdDeviceId = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .IdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .IdUserId = value;
            }
        }
        public string OrderHint
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .OrderHint;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .OrderHint = value;
            }
        }
        public int? PercentComplete
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .PercentComplete;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .PercentComplete = value;
            }
        }
        public string PlanId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .PlanId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .PlanId = value;
            }
        }
        /// <summary>plannerPreviewType</summary>
        public string PreviewType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .PreviewType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .PreviewType = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ProgressTaskBoardFormat;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ProgressTaskBoardFormat = value;
            }
        }
        public int? ReferenceCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ReferenceCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .ReferenceCount = value;
            }
        }
        public System.DateTime? StartDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .StartDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .StartDateTime = value;
            }
        }
        public string Title
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .Title;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .Title = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .UserDisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .UserDisplayNameUserDisplayName = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskAllof1 .UserIdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskAllof1 .UserIdUserId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerTask" /> instance.</summary>
        public MicrosoftGraphPlannerTask()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannertaskAllof1 ), _componentsSchemasMicrosoftGraphPlannertaskAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannertaskAllof1 ), _componentsSchemasMicrosoftGraphPlannertaskAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerTask : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskAllof1 {

    }
}