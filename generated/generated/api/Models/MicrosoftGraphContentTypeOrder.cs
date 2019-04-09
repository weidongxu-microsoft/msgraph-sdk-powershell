namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>contentTypeOrder</summary>
    public partial class MicrosoftGraphContentTypeOrder : Sample.API.Models.IMicrosoftGraphContentTypeOrder
    {
        /// <summary>Backing field for <see cref="Default" /> property.</summary>
        private bool? _default;

        public bool? Default
        {
            get
            {
                return this._default;
            }
            set
            {
                this._default = value;
            }
        }
        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private int? _position;

        public int? Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphContentTypeOrder" /> instance.</summary>
        public MicrosoftGraphContentTypeOrder()
        {
        }
    }
    /// contentTypeOrder
    public partial interface IMicrosoftGraphContentTypeOrder : Sample.API.Runtime.IJsonSerializable {
        bool? Default { get; set; }
        int? Position { get; set; }
    }
}