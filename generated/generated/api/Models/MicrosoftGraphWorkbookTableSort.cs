namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookTableSort : Sample.API.Models.IMicrosoftGraphWorkbookTableSort, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTableSort" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1 _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTableSort" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookSortField[] Fields
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 .Fields;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 .Fields = value;
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
        public bool? MatchCase
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 .MatchCase;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 .MatchCase = value;
            }
        }
        public string Method
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 .Method;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 .Method = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookTableSort" /> instance.</summary>
        public MicrosoftGraphWorkbookTableSort()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktablesortAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookTableSort : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablesortAllof1 {

    }
}