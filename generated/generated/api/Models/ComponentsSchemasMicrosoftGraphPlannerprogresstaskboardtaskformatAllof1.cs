namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerProgressTaskBoardTaskFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1
    {
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1()
        {
        }
    }
    /// plannerProgressTaskBoardTaskFormat
    public partial interface IComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        string OrderHint { get; set; }
    }
}