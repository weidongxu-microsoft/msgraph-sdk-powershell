namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerProgressTaskBoardTaskFormat : Sample.API.Models.IMicrosoftGraphPlannerProgressTaskBoardTaskFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphPlannerProgressTaskBoardTaskFormat" />
        /// </summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 _componentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 ();
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphPlannerProgressTaskBoardTaskFormat" />
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
        public string OrderHint
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 .OrderHint;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 .OrderHint = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphPlannerProgressTaskBoardTaskFormat" /> instance.
        /// </summary>
        public MicrosoftGraphPlannerProgressTaskBoardTaskFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 ), _componentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 ), _componentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerProgressTaskBoardTaskFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerprogresstaskboardtaskformatAllof1 {

    }
}