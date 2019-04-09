namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOutlookUser : Sample.API.Models.IMicrosoftGraphOutlookUser, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOutlookUser" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookuserAllof1 _componentsSchemasMicrosoftGraphOutlookuserAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOutlookuserAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOutlookUser" /></summary>
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
        public Sample.API.Models.IMicrosoftGraphOutlookCategory[] MasterCategories
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOutlookuserAllof1 .MasterCategories;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOutlookuserAllof1 .MasterCategories = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOutlookUser" /> instance.</summary>
        public MicrosoftGraphOutlookUser()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOutlookuserAllof1 ), _componentsSchemasMicrosoftGraphOutlookuserAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOutlookuserAllof1 ), _componentsSchemasMicrosoftGraphOutlookuserAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOutlookUser : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookuserAllof1 {

    }
}