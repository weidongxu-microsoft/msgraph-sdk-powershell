namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>localeInfo</summary>
    public partial class MicrosoftGraphLocaleInfo : Sample.API.Models.IMicrosoftGraphLocaleInfo
    {
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="Locale" /> property.</summary>
        private string _locale;

        public string Locale
        {
            get
            {
                return this._locale;
            }
            set
            {
                this._locale = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphLocaleInfo" /> instance.</summary>
        public MicrosoftGraphLocaleInfo()
        {
        }
    }
    /// localeInfo
    public partial interface IMicrosoftGraphLocaleInfo : Sample.API.Runtime.IJsonSerializable {
        string DisplayName { get; set; }
        string Locale { get; set; }
    }
}