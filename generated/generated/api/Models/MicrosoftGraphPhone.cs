namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>phone</summary>
    public partial class MicrosoftGraphPhone : Sample.API.Models.IMicrosoftGraphPhone
    {
        /// <summary>Backing field for <see cref="Language" /> property.</summary>
        private string _language;

        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private string _number;

        public string Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        public string Region
        {
            get
            {
                return this._region;
            }
            set
            {
                this._region = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>phoneType</summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPhone" /> instance.</summary>
        public MicrosoftGraphPhone()
        {
        }
    }
    /// phone
    public partial interface IMicrosoftGraphPhone : Sample.API.Runtime.IJsonSerializable {
        string Language { get; set; }
        string Number { get; set; }
        string Region { get; set; }
        string Type { get; set; }
    }
}