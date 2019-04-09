namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookPivotTable : Sample.API.Models.IMicrosoftGraphWorkbookPivotTable, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookPivotTable" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1 _componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookPivotTable" /></summary>
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
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 .Name = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet Worksheet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 .Worksheet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 .Worksheet = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookPivotTable" /> instance.</summary>
        public MicrosoftGraphWorkbookPivotTable()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 ), _componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 ), _componentsSchemasMicrosoftGraphWorkbookpivottableAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookPivotTable : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookpivottableAllof1 {

    }
}