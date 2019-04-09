namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbook : Sample.API.Models.IMicrosoftGraphWorkbook, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbook" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookAllof1 _componentsSchemasMicrosoftGraphWorkbookAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbook" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookApplication Application
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookAllof1 .Application;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookAllof1 .Application = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookFunctions Functions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookAllof1 .Functions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookAllof1 .Functions = value;
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
        public Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] Names
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookAllof1 .Names;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookAllof1 .Names = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookTable[] Tables
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookAllof1 .Tables;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookAllof1 .Tables = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet[] Worksheets
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookAllof1 .Worksheets;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookAllof1 .Worksheets = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbook" /> instance.</summary>
        public MicrosoftGraphWorkbook()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookAllof1 ), _componentsSchemasMicrosoftGraphWorkbookAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookAllof1 ), _componentsSchemasMicrosoftGraphWorkbookAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbook : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookAllof1 {

    }
}