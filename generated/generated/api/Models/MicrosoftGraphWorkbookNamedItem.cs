namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookNamedItem : Sample.API.Models.IMicrosoftGraphWorkbookNamedItem, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookNamedItem" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1 _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookNamedItem" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string Comment
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Comment;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Comment = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Name = value;
            }
        }
        public string Scope
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Scope;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Scope = value;
            }
        }
        public string Type
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Type;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Type = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Value
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Value;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Value = value;
            }
        }
        public bool? Visible
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Visible;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Visible = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Worksheet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 .Worksheet = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookNamedItem" /> instance.</summary>
        public MicrosoftGraphWorkbookNamedItem()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 ), _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 ), _componentsSchemasMicrosoftGraphWorkbooknameditemAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookNamedItem : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooknameditemAllof1 {

    }
}