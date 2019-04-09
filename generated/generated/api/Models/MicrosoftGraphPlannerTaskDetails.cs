namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPlannerTaskDetails : Sample.API.Models.IMicrosoftGraphPlannerTaskDetails, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerTaskDetails" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPlannerTaskDetails" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>plannerChecklistItems</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerChecklistItems Checklist
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .Checklist;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .Checklist = value;
            }
        }
        public string Description
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .Description;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .Description = value;
            }
        }
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
        /// <summary>plannerPreviewType</summary>
        public string PreviewType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .PreviewType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .PreviewType = value;
            }
        }
        /// <summary>plannerExternalReferences</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerExternalReferences References
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .References;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 .References = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerTaskDetails" /> instance.</summary>
        public MicrosoftGraphPlannerTaskDetails()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 ), _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 ), _componentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPlannerTaskDetails : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 {

    }
}