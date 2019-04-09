namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookTableRow</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1
    {
        /// <summary>Backing field for <see cref="Index" /> property.</summary>
        private int? _index;

        public int? Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        /// <summary>Backing field for <see cref="Values" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _values;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Values
        {
            get
            {
                return this._values;
            }
            set
            {
                this._values = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1()
        {
        }
    }
    /// workbookTableRow
    public partial interface IComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1 : Sample.API.Runtime.IJsonSerializable {
        int? Index { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Values { get; set; }
    }
}