namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookTableColumn</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1
    {
        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookFilter _filter;

        public Sample.API.Models.IMicrosoftGraphWorkbookFilter Filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                this._filter = value;
            }
        }
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1()
        {
        }
    }
    /// workbookTableColumn
    public partial interface IComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookFilter Filter { get; set; }
        int? Index { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Values { get; set; }
    }
}