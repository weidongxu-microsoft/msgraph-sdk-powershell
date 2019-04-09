namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookTableSort</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1
    {
        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookSortField[] _fields;

        public Sample.API.Models.IMicrosoftGraphWorkbookSortField[] Fields
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
        /// <summary>Backing field for <see cref="MatchCase" /> property.</summary>
        private bool? _matchCase;

        public bool? MatchCase
        {
            get
            {
                return this._matchCase;
            }
            set
            {
                this._matchCase = value;
            }
        }
        /// <summary>Backing field for <see cref="Method" /> property.</summary>
        private string _method;

        public string Method
        {
            get
            {
                return this._method;
            }
            set
            {
                this._method = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1()
        {
        }
    }
    /// workbookTableSort
    public partial interface IComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookSortField[] Fields { get; set; }
        bool? MatchCase { get; set; }
        string Method { get; set; }
    }
}