namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerBucketTaskBoardTaskFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1()
        {
        }
    }
    /// plannerBucketTaskBoardTaskFormat
    public partial interface IComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        string OrderHint { get; set; }
    }
}