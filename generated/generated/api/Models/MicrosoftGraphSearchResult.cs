namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>searchResult</summary>
    public partial class MicrosoftGraphSearchResult : Sample.API.Models.IMicrosoftGraphSearchResult
    {
        /// <summary>Backing field for <see cref="OnClickTelemetryUrl" /> property.</summary>
        private string _onClickTelemetryUrl;

        public string OnClickTelemetryUrl
        {
            get
            {
                return this._onClickTelemetryUrl;
            }
            set
            {
                this._onClickTelemetryUrl = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSearchResult" /> instance.</summary>
        public MicrosoftGraphSearchResult()
        {
        }
    }
    /// searchResult
    public partial interface IMicrosoftGraphSearchResult : Sample.API.Runtime.IJsonSerializable {
        string OnClickTelemetryUrl { get; set; }
    }
}