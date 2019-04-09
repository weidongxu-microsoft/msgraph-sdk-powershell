namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>fileSystemInfo</summary>
    public partial class MicrosoftGraphFileSystemInfo : Sample.API.Models.IMicrosoftGraphFileSystemInfo
    {
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
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
        /// <summary>Creates an new <see cref="MicrosoftGraphFileSystemInfo" /> instance.</summary>
        public MicrosoftGraphFileSystemInfo()
        {
        }
    }
    /// fileSystemInfo
    public partial interface IMicrosoftGraphFileSystemInfo : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? CreatedDateTime { get; set; }
        System.DateTime? LastAccessedDateTime { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
    }
}