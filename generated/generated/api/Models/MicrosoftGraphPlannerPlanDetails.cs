namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerPlanDetails : Sample.API.Models.IMicrosoftGraphPlannerPlanDetails, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerPlanDetails" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1 _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerPlanDetails" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>plannerCategoryDescriptions</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerCategoryDescriptions CategoryDescriptions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptions = value;
            }
        }
        public string CategoryDescriptionsCategory1
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory1;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory1 = value;
            }
        }
        public string CategoryDescriptionsCategory2
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory2;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory2 = value;
            }
        }
        public string CategoryDescriptionsCategory3
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory3;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory3 = value;
            }
        }
        public string CategoryDescriptionsCategory4
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory4;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory4 = value;
            }
        }
        public string CategoryDescriptionsCategory5
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory5;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory5 = value;
            }
        }
        public string CategoryDescriptionsCategory6
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory6;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .CategoryDescriptionsCategory6 = value;
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
        /// <summary>plannerUserIds</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerUserIds SharedWith
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .SharedWith;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 .SharedWith = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerPlanDetails" /> instance.</summary>
        public MicrosoftGraphPlannerPlanDetails()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 ), _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 ), _componentsSchemasMicrosoftGraphPlannerplandetailsAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerPlanDetails : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1 {

    }
}