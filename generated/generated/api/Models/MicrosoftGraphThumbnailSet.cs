namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphThumbnailSet : Sample.API.Models.IMicrosoftGraphThumbnailSet, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphThumbnailSet" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphThumbnailsetAllof1 _componentsSchemasMicrosoftGraphThumbnailsetAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphThumbnailsetAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphThumbnailSet" /></summary>
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
        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Large
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Large;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Large = value;
            }
        }
        public byte[] LargeContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeContent = value;
            }
        }
        public int? LargeHeight
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeHeight;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeHeight = value;
            }
        }
        public string LargeSourceItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeSourceItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeSourceItemId = value;
            }
        }
        public string LargeUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeUrl = value;
            }
        }
        public int? LargeWidth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeWidth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .LargeWidth = value;
            }
        }
        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Medium
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Medium;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Medium = value;
            }
        }
        public byte[] MediumContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumContent = value;
            }
        }
        public int? MediumHeight
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumHeight;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumHeight = value;
            }
        }
        public string MediumSourceItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumSourceItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumSourceItemId = value;
            }
        }
        public string MediumUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumUrl = value;
            }
        }
        public int? MediumWidth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumWidth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .MediumWidth = value;
            }
        }
        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Small
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Small;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Small = value;
            }
        }
        public byte[] SmallContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallContent = value;
            }
        }
        public int? SmallHeight
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallHeight;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallHeight = value;
            }
        }
        public string SmallSourceItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallSourceItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallSourceItemId = value;
            }
        }
        public string SmallUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallUrl = value;
            }
        }
        public int? SmallWidth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallWidth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SmallWidth = value;
            }
        }
        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Source
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Source;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .Source = value;
            }
        }
        public byte[] SourceContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceContent = value;
            }
        }
        public int? SourceHeight
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceHeight;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceHeight = value;
            }
        }
        public string SourceItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceItemId = value;
            }
        }
        public string SourceUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceUrl = value;
            }
        }
        public int? SourceWidth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceWidth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphThumbnailsetAllof1 .SourceWidth = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphThumbnailSet" /> instance.</summary>
        public MicrosoftGraphThumbnailSet()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphThumbnailsetAllof1 ), _componentsSchemasMicrosoftGraphThumbnailsetAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphThumbnailsetAllof1 ), _componentsSchemasMicrosoftGraphThumbnailsetAllof1 );
        }
    }
    public partial interface IMicrosoftGraphThumbnailSet : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphThumbnailsetAllof1 {

    }
}