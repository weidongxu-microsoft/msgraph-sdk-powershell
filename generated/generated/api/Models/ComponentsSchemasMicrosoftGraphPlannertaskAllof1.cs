namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerTask</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannertaskAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskAllof1
    {
        /// <summary>Backing field for <see cref="ActiveChecklistItemCount" /> property.</summary>
        private int? _activeChecklistItemCount;

        public int? ActiveChecklistItemCount
        {
            get
            {
                return this._activeChecklistItemCount;
            }
            set
            {
                this._activeChecklistItemCount = value;
            }
        }
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="AppliedCategories" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerAppliedCategories _appliedCategories;

        /// <summary>plannerAppliedCategories</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerAppliedCategories AppliedCategories
        {
            get
            {
                return this._appliedCategories;
            }
            set
            {
                this._appliedCategories = value;
            }
        }
        /// <summary>Backing field for <see cref="AssignedToTaskBoardFormat" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat _assignedToTaskBoardFormat;

        public Sample.API.Models.IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat
        {
            get
            {
                return this._assignedToTaskBoardFormat;
            }
            set
            {
                this._assignedToTaskBoardFormat = value;
            }
        }
        /// <summary>Backing field for <see cref="AssigneePriority" /> property.</summary>
        private string _assigneePriority;

        public string AssigneePriority
        {
            get
            {
                return this._assigneePriority;
            }
            set
            {
                this._assigneePriority = value;
            }
        }
        /// <summary>Backing field for <see cref="Assignments" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerAssignments _assignments;

        /// <summary>plannerAssignments</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerAssignments Assignments
        {
            get
            {
                return this._assignments;
            }
            set
            {
                this._assignments = value;
            }
        }
        /// <summary>Backing field for <see cref="BucketId" /> property.</summary>
        private string _bucketId;

        public string BucketId
        {
            get
            {
                return this._bucketId;
            }
            set
            {
                this._bucketId = value;
            }
        }
        /// <summary>Backing field for <see cref="BucketTaskBoardFormat" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerBucketTaskBoardTaskFormat _bucketTaskBoardFormat;

        public Sample.API.Models.IMicrosoftGraphPlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat
        {
            get
            {
                return this._bucketTaskBoardFormat;
            }
            set
            {
                this._bucketTaskBoardFormat = value;
            }
        }
        /// <summary>Backing field for <see cref="ChecklistItemCount" /> property.</summary>
        private int? _checklistItemCount;

        public int? ChecklistItemCount
        {
            get
            {
                return this._checklistItemCount;
            }
            set
            {
                this._checklistItemCount = value;
            }
        }
        /// <summary>Backing field for <see cref="CompletedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _completedBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CompletedBy
        {
            get
            {
                return this._completedBy;
            }
            set
            {
                this._completedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CompletedByApplication
        {
            get
            {
                return /*1*/CompletedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CompletedByDevice
        {
            get
            {
                return /*1*/CompletedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CompletedByUser
        {
            get
            {
                return /*1*/CompletedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.User/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="CompletedDateTime" /> property.</summary>
        private System.DateTime? _completedDateTime;

        public System.DateTime? CompletedDateTime
        {
            get
            {
                return this._completedDateTime;
            }
            set
            {
                this._completedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="ConversationThreadId" /> property.</summary>
        private string _conversationThreadId;

        public string ConversationThreadId
        {
            get
            {
                return this._conversationThreadId;
            }
            set
            {
                this._conversationThreadId = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _createdBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return this._createdBy;
            }
            set
            {
                this._createdBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return /*1*/CreatedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return /*1*/CreatedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser
        {
            get
            {
                return /*1*/CreatedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.User/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Details" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerTaskDetails _details;

        public Sample.API.Models.IMicrosoftGraphPlannerTaskDetails Details
        {
            get
            {
                return this._details;
            }
            set
            {
                this._details = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/CompletedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/CompletedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return /*1*/CompletedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="DueDateTime" /> property.</summary>
        private System.DateTime? _dueDateTime;

        public System.DateTime? DueDateTime
        {
            get
            {
                return this._dueDateTime;
            }
            set
            {
                this._dueDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="HasDescription" /> property.</summary>
        private bool? _hasDescription;

        public bool? HasDescription
        {
            get
            {
                return this._hasDescription;
            }
            set
            {
                this._hasDescription = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return /*1*/CompletedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return /*1*/CompletedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return /*1*/CompletedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/CompletedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="OrderHint" /> property.</summary>
        private string _orderHint;

        public string OrderHint
        {
            get
            {
                return this._orderHint;
            }
            set
            {
                this._orderHint = value;
            }
        }
        /// <summary>Backing field for <see cref="PercentComplete" /> property.</summary>
        private int? _percentComplete;

        public int? PercentComplete
        {
            get
            {
                return this._percentComplete;
            }
            set
            {
                this._percentComplete = value;
            }
        }
        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private string _planId;

        public string PlanId
        {
            get
            {
                return this._planId;
            }
            set
            {
                this._planId = value;
            }
        }
        /// <summary>Backing field for <see cref="PreviewType" /> property.</summary>
        private string _previewType;

        /// <summary>plannerPreviewType</summary>
        public string PreviewType
        {
            get
            {
                return this._previewType;
            }
            set
            {
                this._previewType = value;
            }
        }
        /// <summary>Backing field for <see cref="ProgressTaskBoardFormat" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerProgressTaskBoardTaskFormat _progressTaskBoardFormat;

        public Sample.API.Models.IMicrosoftGraphPlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat
        {
            get
            {
                return this._progressTaskBoardFormat;
            }
            set
            {
                this._progressTaskBoardFormat = value;
            }
        }
        /// <summary>Backing field for <see cref="ReferenceCount" /> property.</summary>
        private int? _referenceCount;

        public int? ReferenceCount
        {
            get
            {
                return this._referenceCount;
            }
            set
            {
                this._referenceCount = value;
            }
        }
        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private System.DateTime? _startDateTime;

        public System.DateTime? StartDateTime
        {
            get
            {
                return this._startDateTime;
            }
            set
            {
                this._startDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannertaskAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannertaskAllof1()
        {
        }
    }
    /// plannerTask
    public partial interface IComponentsSchemasMicrosoftGraphPlannertaskAllof1 : Sample.API.Runtime.IJsonSerializable {
        int? ActiveChecklistItemCount { get; set; }
        string ApplicationDisplayNameApplicationDisplayName { get; set; }
        string ApplicationIdApplicationId { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerAppliedCategories AppliedCategories { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat { get; set; }
        string AssigneePriority { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerAssignments Assignments { get; set; }
        string BucketId { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat { get; set; }
        int? ChecklistItemCount { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet CompletedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CompletedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CompletedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CompletedByUser { get; set; }
        System.DateTime? CompletedDateTime { get; set; }
        string ConversationThreadId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerTaskDetails Details { get; set; }
        string DeviceDisplayNameDeviceDisplayName { get; set; }
        string DeviceIdDeviceId { get; set; }
        string DisplayNameApplicationDisplayName { get; set; }
        string DisplayNameDeviceDisplayName { get; set; }
        string DisplayNameUserDisplayName { get; set; }
        System.DateTime? DueDateTime { get; set; }
        bool? HasDescription { get; set; }
        string IdApplicationId { get; set; }
        string IdDeviceId { get; set; }
        string IdUserId { get; set; }
        string OrderHint { get; set; }
        int? PercentComplete { get; set; }
        string PlanId { get; set; }
        string PreviewType { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat { get; set; }
        int? ReferenceCount { get; set; }
        System.DateTime? StartDateTime { get; set; }
        string Title { get; set; }
        string UserDisplayNameUserDisplayName { get; set; }
        string UserIdUserId { get; set; }
    }
}