namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerBucket</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannerbucketAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerbucketAllof1
    {
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannerbucketAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannerbucketAllof1()
        {
        }
    }
    /// plannerBucket
    public partial interface IComponentsSchemasMicrosoftGraphPlannerbucketAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Name { get; set; }
        string OrderHint { get; set; }
        string PlanId { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerTask[] Tasks { get; set; }
    }
}