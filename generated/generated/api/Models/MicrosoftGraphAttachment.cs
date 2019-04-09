namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphAttachment : Sample.API.Models.IMicrosoftGraphAttachment, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphAttachment" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphAttachmentAllof1 _componentsSchemasMicrosoftGraphAttachmentAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphAttachmentAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphAttachment" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string ContentType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttachmentAllof1 .ContentType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttachmentAllof1 .ContentType = value;
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
        public bool? IsInline
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttachmentAllof1 .IsInline;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttachmentAllof1 .IsInline = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttachmentAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttachmentAllof1 .LastModifiedDateTime = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttachmentAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttachmentAllof1 .Name = value;
            }
        }
        public int? Size
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttachmentAllof1 .Size;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttachmentAllof1 .Size = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphAttachment" /> instance.</summary>
        public MicrosoftGraphAttachment()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphAttachmentAllof1 ), _componentsSchemasMicrosoftGraphAttachmentAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphAttachmentAllof1 ), _componentsSchemasMicrosoftGraphAttachmentAllof1 );
        }
    }
    public partial interface IMicrosoftGraphAttachment : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphAttachmentAllof1 {

    }
}