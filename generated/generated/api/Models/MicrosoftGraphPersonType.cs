namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>personType</summary>
    public partial class MicrosoftGraphPersonType : Sample.API.Models.IMicrosoftGraphPersonType
    {
        /// <summary>Backing field for <see cref="Class" /> property.</summary>
        private string _class;

        public string Class
        {
            get
            {
                return this._class;
            }
            set
            {
                this._class = value;
            }
        }
        /// <summary>Backing field for <see cref="Subclass" /> property.</summary>
        private string _subclass;

        public string Subclass
        {
            get
            {
                return this._subclass;
            }
            set
            {
                this._subclass = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPersonType" /> instance.</summary>
        public MicrosoftGraphPersonType()
        {
        }
    }
    /// personType
    public partial interface IMicrosoftGraphPersonType : Sample.API.Runtime.IJsonSerializable {
        string Class { get; set; }
        string Subclass { get; set; }
    }
}