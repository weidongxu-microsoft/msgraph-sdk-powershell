namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookFunctions : Sample.API.Models.IMicrosoftGraphWorkbookFunctions, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookFunctions" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 _componentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookFunctions" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookFunctions" /> instance.</summary>
        public MicrosoftGraphWorkbookFunctions()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 ), _componentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 ), _componentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookFunctions : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookfunctionsAllof1 {

    }
}