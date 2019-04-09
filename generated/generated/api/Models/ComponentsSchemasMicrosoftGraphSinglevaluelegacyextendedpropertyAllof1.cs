namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>singleValueLegacyExtendedProperty</summary>
    public partial class ComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1
    {
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        public string Value
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1()
        {
        }
    }
    /// singleValueLegacyExtendedProperty
    public partial interface IComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Value { get; set; }
    }
}