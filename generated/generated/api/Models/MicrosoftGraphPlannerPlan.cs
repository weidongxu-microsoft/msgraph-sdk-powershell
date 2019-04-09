namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerPlan : Sample.API.Models.IMicrosoftGraphPlannerPlan, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerPlan" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplanAllof1 _componentsSchemasMicrosoftGraphPlannerplanAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannerplanAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerPlan" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string ApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .ApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .ApplicationDisplayName = value;
            }
        }
        public string ApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .ApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .ApplicationId = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerBucket[] Buckets
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Buckets;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Buckets = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedByUser = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .CreatedDateTime = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerPlanDetails Details
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Details;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Details = value;
            }
        }
        public string DeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .DeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .DeviceDisplayName = value;
            }
        }
        public string DeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .DeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .DeviceId = value;
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
        public string Owner
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Owner;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Owner = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerTask[] Tasks
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Tasks;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Tasks = value;
            }
        }
        public string Title
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Title;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .Title = value;
            }
        }
        public string UserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .UserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .UserDisplayName = value;
            }
        }
        public string UserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplanAllof1 .UserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplanAllof1 .UserId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerPlan" /> instance.</summary>
        public MicrosoftGraphPlannerPlan()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannerplanAllof1 ), _componentsSchemasMicrosoftGraphPlannerplanAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannerplanAllof1 ), _componentsSchemasMicrosoftGraphPlannerplanAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerPlan : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplanAllof1 {

    }
}