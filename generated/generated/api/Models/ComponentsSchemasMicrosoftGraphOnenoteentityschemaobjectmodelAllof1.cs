namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenoteEntitySchemaObjectModel</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1
    {
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1()
        {
        }
    }
    /// onenoteEntitySchemaObjectModel
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? CreatedDateTime { get; set; }
    }
}