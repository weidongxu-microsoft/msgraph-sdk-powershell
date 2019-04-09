namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerBucket : Sample.API.Models.IMicrosoftGraphPlannerBucket, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerBucket" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerbucketAllof1 _componentsSchemasMicrosoftGraphPlannerbucketAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannerbucketAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerBucket" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
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
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .Name = value;
            }
        }
        public string OrderHint
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .OrderHint;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .OrderHint = value;
            }
        }
        public string PlanId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .PlanId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .PlanId = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerTask[] Tasks
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .Tasks;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerbucketAllof1 .Tasks = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerBucket" /> instance.</summary>
        public MicrosoftGraphPlannerBucket()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannerbucketAllof1 ), _componentsSchemasMicrosoftGraphPlannerbucketAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannerbucketAllof1 ), _componentsSchemasMicrosoftGraphPlannerbucketAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerBucket : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerbucketAllof1 {

    }
}