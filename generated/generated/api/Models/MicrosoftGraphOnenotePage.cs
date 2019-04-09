namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenotePage : Sample.API.Models.IMicrosoftGraphOnenotePage, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenotePage" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotepageAllof1 _componentsSchemasMicrosoftGraphOnenotepageAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenotepageAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenotePage" /></summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteEntitySchemaObjectModel _microsoftGraphOnenoteEntitySchemaObjectModel = new Sample.API.Models.MicrosoftGraphOnenoteEntitySchemaObjectModel ();
        public byte[] Content
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Content;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Content = value;
            }
        }
        public string ContentUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .ContentUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .ContentUrl = value;
            }
        }
        public string CreatedByAppId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .CreatedByAppId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .CreatedByAppId = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphOnenoteEntitySchemaObjectModel .CreatedDateTime;
            }
            set
            {
                _microsoftGraphOnenoteEntitySchemaObjectModel .CreatedDateTime = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOnenoteEntitySchemaObjectModel .Id;
            }
            set
            {
                _microsoftGraphOnenoteEntitySchemaObjectModel .Id = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .LastModifiedDateTime = value;
            }
        }
        public int? Level
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Level;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Level = value;
            }
        }
        /// <summary>pageLinks</summary>
        public Sample.API.Models.IMicrosoftGraphPageLinks Links
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Links;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Links = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteClientUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .LinksOneNoteClientUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .LinksOneNoteClientUrl = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .LinksOneNoteWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .LinksOneNoteWebUrl = value;
            }
        }
        public string OneNoteClientUrlHref
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .OneNoteClientUrlHref;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .OneNoteClientUrlHref = value;
            }
        }
        public string OneNoteWebUrlHref
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .OneNoteWebUrlHref;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .OneNoteWebUrlHref = value;
            }
        }
        public int? Order
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Order;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Order = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphNotebook ParentNotebook
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .ParentNotebook;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .ParentNotebook = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenoteSection ParentSection
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .ParentSection;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .ParentSection = value;
            }
        }
        public string Self
        {
            get
            {
                return _microsoftGraphOnenoteEntitySchemaObjectModel .Self;
            }
            set
            {
                _microsoftGraphOnenoteEntitySchemaObjectModel .Self = value;
            }
        }
        public string Title
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Title;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .Title = value;
            }
        }
        public string[] UserTags
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenotepageAllof1 .UserTags;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenotepageAllof1 .UserTags = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOnenotePage" /> instance.</summary>
        public MicrosoftGraphOnenotePage()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOnenoteEntitySchemaObjectModel ), _microsoftGraphOnenoteEntitySchemaObjectModel );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOnenoteEntitySchemaObjectModel ), _microsoftGraphOnenoteEntitySchemaObjectModel );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenotepageAllof1 ), _componentsSchemasMicrosoftGraphOnenotepageAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenotepageAllof1 ), _componentsSchemasMicrosoftGraphOnenotepageAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenotePage : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOnenoteEntitySchemaObjectModel, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotepageAllof1 {

    }
}