namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenoteEntityBaseModel</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1
    {
        /// <summary>Backing field for <see cref="Self" /> property.</summary>
        private string _self;

        public string Self
        {
            get
            {
                return this._self;
            }
            set
            {
                this._self = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1()
        {
        }
    }
    /// onenoteEntityBaseModel
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Self { get; set; }
    }
}