namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerBucketTaskBoardTaskFormat : Sample.API.Models.IMicrosoftGraphPlannerBucketTaskBoardTaskFormat, Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphPlannerBucketTaskBoardTaskFormat" />
        /// </summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 _componentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 ();
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphPlannerBucketTaskBoardTaskFormat" />
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
                return _componentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 .OrderHint;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 .OrderHint = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphPlannerBucketTaskBoardTaskFormat" /> instance.
        /// </summary>
        public MicrosoftGraphPlannerBucketTaskBoardTaskFormat()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 ), _componentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 ), _componentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerBucketTaskBoardTaskFormat : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerbuckettaskboardtaskformatAllof1 {

    }
}