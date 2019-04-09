namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphProfilePhoto : Sample.API.Models.IMicrosoftGraphProfilePhoto, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphProfilePhoto" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphProfilephotoAllof1 _componentsSchemasMicrosoftGraphProfilephotoAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphProfilephotoAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphProfilePhoto" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public int? Height
        {
            get
            {
                return _componentsSchemasMicrosoftGraphProfilephotoAllof1 .Height;
            }
            set
            {
                _componentsSchemasMicrosoftGraphProfilephotoAllof1 .Height = value;
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
        public int? Width
        {
            get
            {
                return _componentsSchemasMicrosoftGraphProfilephotoAllof1 .Width;
            }
            set
            {
                _componentsSchemasMicrosoftGraphProfilephotoAllof1 .Width = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphProfilePhoto" /> instance.</summary>
        public MicrosoftGraphProfilePhoto()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphProfilephotoAllof1 ), _componentsSchemasMicrosoftGraphProfilephotoAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphProfilephotoAllof1 ), _componentsSchemasMicrosoftGraphProfilephotoAllof1 );
        }
    }
    public partial interface IMicrosoftGraphProfilePhoto : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphProfilephotoAllof1 {

    }
}