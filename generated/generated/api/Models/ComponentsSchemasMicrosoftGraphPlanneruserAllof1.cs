namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerUser</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlanneruserAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlanneruserAllof1
    {
        /// <summary>Backing field for <see cref="Plans" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerPlan[] _plans;

        public Sample.API.Models.IMicrosoftGraphPlannerPlan[] Plans
        {
            get
            {
                return this._plans;
            }
            set
            {
                this._plans = value;
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlanneruserAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlanneruserAllof1()
        {
        }
    }
    /// plannerUser
    public partial interface IComponentsSchemasMicrosoftGraphPlanneruserAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphPlannerPlan[] Plans { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerTask[] Tasks { get; set; }
    }
}