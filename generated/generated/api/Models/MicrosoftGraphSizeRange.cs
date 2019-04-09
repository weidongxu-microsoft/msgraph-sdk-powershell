namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sizeRange</summary>
    public partial class MicrosoftGraphSizeRange : Sample.API.Models.IMicrosoftGraphSizeRange
    {
        /// <summary>Backing field for <see cref="MaximumSize" /> property.</summary>
        private int? _maximumSize;

        public int? MaximumSize
        {
            get
            {
                return this._maximumSize;
            }
            set
            {
                this._maximumSize = value;
            }
        }
        /// <summary>Backing field for <see cref="MinimumSize" /> property.</summary>
        private int? _minimumSize;

        public int? MinimumSize
        {
            get
            {
                return this._minimumSize;
            }
            set
            {
                this._minimumSize = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSizeRange" /> instance.</summary>
        public MicrosoftGraphSizeRange()
        {
        }
    }
    /// sizeRange
    public partial interface IMicrosoftGraphSizeRange : Sample.API.Runtime.IJsonSerializable {
        int? MaximumSize { get; set; }
        int? MinimumSize { get; set; }
    }
}