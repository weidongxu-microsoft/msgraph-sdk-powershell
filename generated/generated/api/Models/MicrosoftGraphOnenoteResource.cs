namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenoteResource : Sample.API.Models.IMicrosoftGraphOnenoteResource, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteResource" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteresourceAllof1 _componentsSchemasMicrosoftGraphOnenoteresourceAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenoteresourceAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteResource" /></summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteEntityBaseModel _microsoftGraphOnenoteEntityBaseModel = new Sample.API.Models.MicrosoftGraphOnenoteEntityBaseModel ();
        public byte[] Content
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteresourceAllof1 .Content;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteresourceAllof1 .Content = value;
            }
        }
        public string ContentUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteresourceAllof1 .ContentUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteresourceAllof1 .ContentUrl = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOnenoteEntityBaseModel .Id;
            }
            set
            {
                _microsoftGraphOnenoteEntityBaseModel .Id = value;
            }
        }
        public string Self
        {
            get
            {
                return _microsoftGraphOnenoteEntityBaseModel .Self;
            }
            set
            {
                _microsoftGraphOnenoteEntityBaseModel .Self = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOnenoteResource" /> instance.</summary>
        public MicrosoftGraphOnenoteResource()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOnenoteEntityBaseModel ), _microsoftGraphOnenoteEntityBaseModel );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOnenoteEntityBaseModel ), _microsoftGraphOnenoteEntityBaseModel );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenoteresourceAllof1 ), _componentsSchemasMicrosoftGraphOnenoteresourceAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenoteresourceAllof1 ), _componentsSchemasMicrosoftGraphOnenoteresourceAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenoteResource : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOnenoteEntityBaseModel, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteresourceAllof1 {

    }
}