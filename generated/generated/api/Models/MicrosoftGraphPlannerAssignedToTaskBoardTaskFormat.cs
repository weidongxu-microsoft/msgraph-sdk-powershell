namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerAssignedToTaskBoardTaskFormat : Sample.API.Models.IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphPlannerAssignedToTaskBoardTaskFormat" />
        /// </summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 _componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 ();
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphPlannerAssignedToTaskBoardTaskFormat" />
        /// </summary>
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
        /// <summary>plannerOrderHintsByAssignee</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerOrderHintsByAssignee OrderHintsByAssignee
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 .OrderHintsByAssignee;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 .OrderHintsByAssignee = value;
            }
        }
        public string UnassignedOrderHint
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 .UnassignedOrderHint;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 .UnassignedOrderHint = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphPlannerAssignedToTaskBoardTaskFormat" /> instance.
        /// </summary>
        public MicrosoftGraphPlannerAssignedToTaskBoardTaskFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 ), _componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 ), _componentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerassignedtotaskboardtaskformatAllof1 {

    }
}