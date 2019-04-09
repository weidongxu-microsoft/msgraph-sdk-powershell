namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookNamedItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1
    {
        /// <summary>Backing field for <see cref="Comment" /> property.</summary>
        private string _comment;

        public string Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
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
        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        public string Scope
        {
            get
            {
                return this._scope;
            }
            set
            {
                this._scope = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _value;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Value
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
        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private bool? _visible;

        public bool? Visible
        {
            get
            {
                return this._visible;
            }
            set
            {
                this._visible = value;
            }
        }
        /// <summary>Backing field for <see cref="Worksheet" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookWorksheet _worksheet;

        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet
        {
            get
            {
                return this._worksheet;
            }
            set
            {
                this._worksheet = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1()
        {
        }
    }
    /// workbookNamedItem
    public partial interface IComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Comment { get; set; }
        string Name { get; set; }
        string Scope { get; set; }
        string Type { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Value { get; set; }
        bool? Visible { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet { get; set; }
    }
}