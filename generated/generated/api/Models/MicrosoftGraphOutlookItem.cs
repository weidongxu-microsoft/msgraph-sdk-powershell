namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOutlookItem : Sample.API.Models.IMicrosoftGraphOutlookItem, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOutlookItem" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookitemAllof1 _componentsSchemasMicrosoftGraphOutlookitemAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOutlookitemAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOutlookItem" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string[] Categories
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOutlookitemAllof1 .Categories;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOutlookitemAllof1 .Categories = value;
            }
        }
        public string ChangeKey
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOutlookitemAllof1 .ChangeKey;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOutlookitemAllof1 .ChangeKey = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOutlookitemAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOutlookitemAllof1 .CreatedDateTime = value;
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
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOutlookitemAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOutlookitemAllof1 .LastModifiedDateTime = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOutlookItem" /> instance.</summary>
        public MicrosoftGraphOutlookItem()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOutlookitemAllof1 ), _componentsSchemasMicrosoftGraphOutlookitemAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOutlookitemAllof1 ), _componentsSchemasMicrosoftGraphOutlookitemAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOutlookItem : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookitemAllof1 {

    }
}