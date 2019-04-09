namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookIcon</summary>
    public partial class MicrosoftGraphWorkbookIcon : Sample.API.Models.IMicrosoftGraphWorkbookIcon
    {
        /// <summary>Backing field for <see cref="Index" /> property.</summary>
        private int? _index;

        public int? Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        /// <summary>Backing field for <see cref="Set" /> property.</summary>
        private string _set;

        public string Set
        {
            get
            {
                return this._set;
            }
            set
            {
                this._set = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookIcon" /> instance.</summary>
        public MicrosoftGraphWorkbookIcon()
        {
        }
    }
    /// workbookIcon
    public partial interface IMicrosoftGraphWorkbookIcon : Sample.API.Runtime.IJsonSerializable {
        int? Index { get; set; }
        string Set { get; set; }
    }
}