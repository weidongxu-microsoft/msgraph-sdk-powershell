namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>dateTimeColumn</summary>
    public partial class MicrosoftGraphDateTimeColumn : Sample.API.Models.IMicrosoftGraphDateTimeColumn
    {
        /// <summary>Backing field for <see cref="DisplayAs" /> property.</summary>
        private string _displayAs;

        public string DisplayAs
        {
            get
            {
                return this._displayAs;
            }
            set
            {
                this._displayAs = value;
            }
        }
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private string _format;

        public string Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDateTimeColumn" /> instance.</summary>
        public MicrosoftGraphDateTimeColumn()
        {
        }
    }
    /// dateTimeColumn
    public partial interface IMicrosoftGraphDateTimeColumn : Sample.API.Runtime.IJsonSerializable {
        string DisplayAs { get; set; }
        string Format { get; set; }
    }
}