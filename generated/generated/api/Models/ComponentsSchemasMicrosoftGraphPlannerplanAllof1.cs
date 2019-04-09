namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerPlan</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannerplanAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplanAllof1
    {
        public string ApplicationDisplayName
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
        public string ApplicationId
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
        /// <summary>Backing field for <see cref="Buckets" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerBucket[] _buckets;

        public Sample.API.Models.IMicrosoftGraphPlannerBucket[] Buckets
        {
            get
            {
                return this._buckets;
            }
            set
            {
                this._buckets = value;
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
        private Sample.API.Models.IMicrosoftGraphPlannerPlanDetails _details;

        public Sample.API.Models.IMicrosoftGraphPlannerPlanDetails Details
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
        public string DeviceDisplayName
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
        public string DeviceId
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
        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private string _owner;

        public string Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        /// <summary>Backing field for <see cref="Tasks" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerTask[] _tasks;

        public Sample.API.Models.IMicrosoftGraphPlannerTask[] Tasks
        {
            get
            {
                return this._tasks;
            }
            set
            {
                this._tasks = value;
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
        public string UserDisplayName
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
        public string UserId
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannerplanAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannerplanAllof1()
        {
        }
    }
    /// plannerPlan
    public partial interface IComponentsSchemasMicrosoftGraphPlannerplanAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayName { get; set; }
        string ApplicationId { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerBucket[] Buckets { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerPlanDetails Details { get; set; }
        string DeviceDisplayName { get; set; }
        string DeviceId { get; set; }
        string Owner { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerTask[] Tasks { get; set; }
        string Title { get; set; }
        string UserDisplayName { get; set; }
        string UserId { get; set; }
    }
}