namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerAssignedToTaskBoardTaskFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1
    {
        /// <summary>Backing field for <see cref="OrderHintsByAssignee" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerOrderHintsByAssignee _orderHintsByAssignee;

        /// <summary>plannerOrderHintsByAssignee</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerOrderHintsByAssignee OrderHintsByAssignee
        {
            get
            {
                return this._orderHintsByAssignee;
            }
            set
            {
                this._orderHintsByAssignee = value;
            }
        }
        /// <summary>Backing field for <see cref="UnassignedOrderHint" /> property.</summary>
        private string _unassignedOrderHint;

        public string UnassignedOrderHint
        {
            get
            {
                return this._unassignedOrderHint;
            }
            set
            {
                this._unassignedOrderHint = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1()
        {
        }
    }
    /// plannerAssignedToTaskBoardTaskFormat
    public partial interface IComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphPlannerOrderHintsByAssignee OrderHintsByAssignee { get; set; }
        string UnassignedOrderHint { get; set; }
    }
}