namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>externalLink</summary>
    public partial class MicrosoftGraphExternalLink : Sample.API.Models.IMicrosoftGraphExternalLink
    {
        /// <summary>Backing field for <see cref="Href" /> property.</summary>
        private string _href;

        public string Href
        {
            get
            {
                return this._href;
            }
            set
            {
                this._href = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphExternalLink" /> instance.</summary>
        public MicrosoftGraphExternalLink()
        {
        }
    }
    /// externalLink
    public partial interface IMicrosoftGraphExternalLink : Sample.API.Runtime.IJsonSerializable {
        string Href { get; set; }
    }
}