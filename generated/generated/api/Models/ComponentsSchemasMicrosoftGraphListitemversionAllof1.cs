namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>listItemVersion</summary>
    public partial class ComponentsSchemasMicrosoftGraphListitemversionAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemversionAllof1
    {
        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphFieldValueSet _fields;

        public Sample.API.Models.IMicrosoftGraphFieldValueSet Fields
        {
            get
            {
                return this._fields;
            }
            set
            {
                this._fields = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphListitemversionAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphListitemversionAllof1()
        {
        }
    }
    /// listItemVersion
    public partial interface IComponentsSchemasMicrosoftGraphListitemversionAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphFieldValueSet Fields { get; set; }
    }
}