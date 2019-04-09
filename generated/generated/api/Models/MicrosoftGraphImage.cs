namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>image</summary>
    public partial class MicrosoftGraphImage : Sample.API.Models.IMicrosoftGraphImage
    {
        /// <summary>Backing field for <see cref="Height" /> property.</summary>
        private int? _height;

        public int? Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        /// <summary>Backing field for <see cref="Width" /> property.</summary>
        private int? _width;

        public int? Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphImage" /> instance.</summary>
        public MicrosoftGraphImage()
        {
        }
    }
    /// image
    public partial interface IMicrosoftGraphImage : Sample.API.Runtime.IJsonSerializable {
        int? Height { get; set; }
        int? Width { get; set; }
    }
}