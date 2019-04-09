namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>currencyColumn</summary>
    public partial class MicrosoftGraphCurrencyColumn : Sample.API.Models.IMicrosoftGraphCurrencyColumn
    {
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
        /// <summary>Creates an new <see cref="MicrosoftGraphCurrencyColumn" /> instance.</summary>
        public MicrosoftGraphCurrencyColumn()
        {
        }
    }
    /// currencyColumn
    public partial interface IMicrosoftGraphCurrencyColumn : Sample.API.Runtime.IJsonSerializable {
        string Locale { get; set; }
    }
}