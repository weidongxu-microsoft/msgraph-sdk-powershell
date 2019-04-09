namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookPivotTable</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1()
        {
        }
    }
    /// workbookPivotTable
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet { get; set; }
    }
}