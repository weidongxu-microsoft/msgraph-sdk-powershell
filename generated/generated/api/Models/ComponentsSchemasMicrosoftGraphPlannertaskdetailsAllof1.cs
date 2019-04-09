namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerTaskDetails</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1
    {
        /// <summary>Backing field for <see cref="Checklist" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerChecklistItems _checklist;

        /// <summary>plannerChecklistItems</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerChecklistItems Checklist
        {
            get
            {
                return this._checklist;
            }
            set
            {
                this._checklist = value;
            }
        }
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for <see cref="PreviewType" /> property.</summary>
        private string _previewType;

        /// <summary>plannerPreviewType</summary>
        public string PreviewType
        {
            get
            {
                return this._previewType;
            }
            set
            {
                this._previewType = value;
            }
        }
        /// <summary>Backing field for <see cref="References" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerExternalReferences _references;

        /// <summary>plannerExternalReferences</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerExternalReferences References
        {
            get
            {
                return this._references;
            }
            set
            {
                this._references = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1()
        {
        }
    }
    /// plannerTaskDetails
    public partial interface IComponentsSchemasMicrosoftGraphPlannertaskdetailsAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphPlannerChecklistItems Checklist { get; set; }
        string Description { get; set; }
        string PreviewType { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerExternalReferences References { get; set; }
    }
}