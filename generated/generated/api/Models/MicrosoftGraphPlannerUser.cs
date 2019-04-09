namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerUser : Sample.API.Models.IMicrosoftGraphPlannerUser, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerUser" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlanneruserAllof1 _componentsSchemasMicrosoftGraphPlanneruserAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlanneruserAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerUser" /></summary>
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
        public Sample.API.Models.IMicrosoftGraphPlannerPlan[] Plans
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlanneruserAllof1 .Plans;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlanneruserAllof1 .Plans = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerTask[] Tasks
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlanneruserAllof1 .Tasks;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlanneruserAllof1 .Tasks = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerUser" /> instance.</summary>
        public MicrosoftGraphPlannerUser()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlanneruserAllof1 ), _componentsSchemasMicrosoftGraphPlanneruserAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlanneruserAllof1 ), _componentsSchemasMicrosoftGraphPlanneruserAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerUser : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlanneruserAllof1 {

    }
}