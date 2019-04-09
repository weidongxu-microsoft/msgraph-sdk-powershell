namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>multiValueLegacyExtendedProperty</summary>
    public partial class ComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1
    {
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string[] _value;

        public string[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1()
        {
        }
    }
    /// multiValueLegacyExtendedProperty
    public partial interface IComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 : Sample.API.Runtime.IJsonSerializable {
        string[] Value { get; set; }
    }
}