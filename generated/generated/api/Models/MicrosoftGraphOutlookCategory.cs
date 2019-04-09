namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOutlookCategory : Sample.API.Models.IMicrosoftGraphOutlookCategory, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOutlookCategory" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookcategoryAllof1 _componentsSchemasMicrosoftGraphOutlookcategoryAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOutlookcategoryAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOutlookCategory" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>categoryColor</summary>
        public string Color
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOutlookcategoryAllof1 .Color;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOutlookcategoryAllof1 .Color = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOutlookcategoryAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOutlookcategoryAllof1 .DisplayName = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphOutlookCategory" /> instance.</summary>
        public MicrosoftGraphOutlookCategory()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOutlookcategoryAllof1 ), _componentsSchemasMicrosoftGraphOutlookcategoryAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOutlookcategoryAllof1 ), _componentsSchemasMicrosoftGraphOutlookcategoryAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOutlookCategory : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookcategoryAllof1 {

    }
}