namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookApplication : Sample.API.Models.IMicrosoftGraphWorkbookApplication, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookApplication" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1 _componentsSchemasMicrosoftGraphWorkbookapplicationAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookApplication" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string CalculationMode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookapplicationAllof1 .CalculationMode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookapplicationAllof1 .CalculationMode = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookApplication" /> instance.</summary>
        public MicrosoftGraphWorkbookApplication()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookapplicationAllof1 ), _componentsSchemasMicrosoftGraphWorkbookapplicationAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookapplicationAllof1 ), _componentsSchemasMicrosoftGraphWorkbookapplicationAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookApplication : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1 {

    }
}