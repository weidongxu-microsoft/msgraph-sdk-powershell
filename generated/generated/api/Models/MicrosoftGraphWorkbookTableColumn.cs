namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookTableColumn : Sample.API.Models.IMicrosoftGraphWorkbookTableColumn, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTableColumn" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookTableColumn" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphWorkbookFilter Filter
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Filter;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Filter = value;
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
        public int? Index
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Index;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Index = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Name = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Values
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Values;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 .Values = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookTableColumn" /> instance.</summary>
        public MicrosoftGraphWorkbookTableColumn()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 ), _componentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookTableColumn : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbooktablecolumnAllof1 {

    }
}