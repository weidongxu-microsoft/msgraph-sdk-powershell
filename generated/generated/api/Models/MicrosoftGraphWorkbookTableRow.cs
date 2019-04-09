namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookTableRow : Sample.API.Models.IMicrosoftGraphWorkbookTableRow, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTableRow" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1 _componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTableRow" /></summary>
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
        public int? Index
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 .Index;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 .Index = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Values
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 .Values;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 .Values = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookTableRow" /> instance.</summary>
        public MicrosoftGraphWorkbookTableRow()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktablerowAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookTableRow : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablerowAllof1 {

    }
}