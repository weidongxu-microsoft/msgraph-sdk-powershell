namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>usageDetails</summary>
    public partial class MicrosoftGraphUsageDetails : Sample.API.Models.IMicrosoftGraphUsageDetails
    {
        /// <summary>Backing field for <see cref="LastAccessedDateTime" /> property.</summary>
        private System.DateTime? _lastAccessedDateTime;

        public System.DateTime? LastAccessedDateTime
        {
            get
            {
                return this._lastAccessedDateTime;
            }
            set
            {
                this._lastAccessedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private System.DateTime? _lastModifiedDateTime;

        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return this._lastModifiedDateTime;
            }
            set
            {
                this._lastModifiedDateTime = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphUsageDetails" /> instance.</summary>
        public MicrosoftGraphUsageDetails()
        {
        }
    }
    /// usageDetails
    public partial interface IMicrosoftGraphUsageDetails : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? LastAccessedDateTime { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
    }
}