namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>thumbnailSet</summary>
    public partial class ComponentsSchemasMicrosoftGraphThumbnailsetAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphThumbnailsetAllof1
    {
        /// <summary>Backing field for <see cref="Large" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphThumbnail _large;

        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Large
        {
            get
            {
                return this._large;
            }
            set
            {
                this._large = value;
            }
        }
        public byte[] LargeContent
        {
            get
            {
                return /*1*/Large/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/Large/*4*/.Content/*3*/ = value;
            }
        }
        public int? LargeHeight
        {
            get
            {
                return /*1*/Large/*4*/.Height/*3*/;
            }
            set
            {
                /*1*/Large/*4*/.Height/*3*/ = value;
            }
        }
        public string LargeSourceItemId
        {
            get
            {
                return /*1*/Large/*4*/.SourceItemId/*3*/;
            }
            set
            {
                /*1*/Large/*4*/.SourceItemId/*3*/ = value;
            }
        }
        public string LargeUrl
        {
            get
            {
                return /*1*/Large/*4*/.Url/*3*/;
            }
            set
            {
                /*1*/Large/*4*/.Url/*3*/ = value;
            }
        }
        public int? LargeWidth
        {
            get
            {
                return /*1*/Large/*4*/.Width/*3*/;
            }
            set
            {
                /*1*/Large/*4*/.Width/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Medium" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphThumbnail _medium;

        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Medium
        {
            get
            {
                return this._medium;
            }
            set
            {
                this._medium = value;
            }
        }
        public byte[] MediumContent
        {
            get
            {
                return /*1*/Medium/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/Medium/*4*/.Content/*3*/ = value;
            }
        }
        public int? MediumHeight
        {
            get
            {
                return /*1*/Medium/*4*/.Height/*3*/;
            }
            set
            {
                /*1*/Medium/*4*/.Height/*3*/ = value;
            }
        }
        public string MediumSourceItemId
        {
            get
            {
                return /*1*/Medium/*4*/.SourceItemId/*3*/;
            }
            set
            {
                /*1*/Medium/*4*/.SourceItemId/*3*/ = value;
            }
        }
        public string MediumUrl
        {
            get
            {
                return /*1*/Medium/*4*/.Url/*3*/;
            }
            set
            {
                /*1*/Medium/*4*/.Url/*3*/ = value;
            }
        }
        public int? MediumWidth
        {
            get
            {
                return /*1*/Medium/*4*/.Width/*3*/;
            }
            set
            {
                /*1*/Medium/*4*/.Width/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Small" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphThumbnail _small;

        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Small
        {
            get
            {
                return this._small;
            }
            set
            {
                this._small = value;
            }
        }
        public byte[] SmallContent
        {
            get
            {
                return /*1*/Small/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/Small/*4*/.Content/*3*/ = value;
            }
        }
        public int? SmallHeight
        {
            get
            {
                return /*1*/Small/*4*/.Height/*3*/;
            }
            set
            {
                /*1*/Small/*4*/.Height/*3*/ = value;
            }
        }
        public string SmallSourceItemId
        {
            get
            {
                return /*1*/Small/*4*/.SourceItemId/*3*/;
            }
            set
            {
                /*1*/Small/*4*/.SourceItemId/*3*/ = value;
            }
        }
        public string SmallUrl
        {
            get
            {
                return /*1*/Small/*4*/.Url/*3*/;
            }
            set
            {
                /*1*/Small/*4*/.Url/*3*/ = value;
            }
        }
        public int? SmallWidth
        {
            get
            {
                return /*1*/Small/*4*/.Width/*3*/;
            }
            set
            {
                /*1*/Small/*4*/.Width/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphThumbnail _source;

        /// <summary>thumbnail</summary>
        public Sample.API.Models.IMicrosoftGraphThumbnail Source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }
        public byte[] SourceContent
        {
            get
            {
                return /*1*/Source/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/Source/*4*/.Content/*3*/ = value;
            }
        }
        public int? SourceHeight
        {
            get
            {
                return /*1*/Source/*4*/.Height/*3*/;
            }
            set
            {
                /*1*/Source/*4*/.Height/*3*/ = value;
            }
        }
        public string SourceItemId
        {
            get
            {
                return /*1*/Source/*4*/.SourceItemId/*3*/;
            }
            set
            {
                /*1*/Source/*4*/.SourceItemId/*3*/ = value;
            }
        }
        public string SourceUrl
        {
            get
            {
                return /*1*/Source/*4*/.Url/*3*/;
            }
            set
            {
                /*1*/Source/*4*/.Url/*3*/ = value;
            }
        }
        public int? SourceWidth
        {
            get
            {
                return /*1*/Source/*4*/.Width/*3*/;
            }
            set
            {
                /*1*/Source/*4*/.Width/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphThumbnailsetAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphThumbnailsetAllof1()
        {
        }
    }
    /// thumbnailSet
    public partial interface IComponentsSchemasMicrosoftGraphThumbnailsetAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphThumbnail Large { get; set; }
        byte[] LargeContent { get; set; }
        int? LargeHeight { get; set; }
        string LargeSourceItemId { get; set; }
        string LargeUrl { get; set; }
        int? LargeWidth { get; set; }
        Sample.API.Models.IMicrosoftGraphThumbnail Medium { get; set; }
        byte[] MediumContent { get; set; }
        int? MediumHeight { get; set; }
        string MediumSourceItemId { get; set; }
        string MediumUrl { get; set; }
        int? MediumWidth { get; set; }
        Sample.API.Models.IMicrosoftGraphThumbnail Small { get; set; }
        byte[] SmallContent { get; set; }
        int? SmallHeight { get; set; }
        string SmallSourceItemId { get; set; }
        string SmallUrl { get; set; }
        int? SmallWidth { get; set; }
        Sample.API.Models.IMicrosoftGraphThumbnail Source { get; set; }
        byte[] SourceContent { get; set; }
        int? SourceHeight { get; set; }
        string SourceItemId { get; set; }
        string SourceUrl { get; set; }
        int? SourceWidth { get; set; }
    }
}