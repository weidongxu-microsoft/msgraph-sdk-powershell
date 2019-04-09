namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>columnLink</summary>
    public partial class ComponentsSchemasMicrosoftGraphColumnlinkAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphColumnlinkAllof1
    {
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphColumnlinkAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphColumnlinkAllof1()
        {
        }
    }
    /// columnLink
    public partial interface IComponentsSchemasMicrosoftGraphColumnlinkAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Name { get; set; }
    }
}