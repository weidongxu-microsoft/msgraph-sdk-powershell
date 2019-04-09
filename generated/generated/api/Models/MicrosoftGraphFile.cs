namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>file</summary>
    public partial class MicrosoftGraphFile : Sample.API.Models.IMicrosoftGraphFile
    {
        /// <summary>Backing field for <see cref="Hashes" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphHashes _hashes;

        /// <summary>hashes</summary>
        public Sample.API.Models.IMicrosoftGraphHashes Hashes
        {
            get
            {
                return this._hashes;
            }
            set
            {
                this._hashes = value;
            }
        }
        public string HashesCrc32Hash
        {
            get
            {
                return /*1*/Hashes/*4*/.Crc32Hash/*3*/;
            }
            set
            {
                /*1*/Hashes/*4*/.Crc32Hash/*3*/ = value;
            }
        }
        public string HashesQuickXorHash
        {
            get
            {
                return /*1*/Hashes/*4*/.QuickXorHash/*3*/;
            }
            set
            {
                /*1*/Hashes/*4*/.QuickXorHash/*3*/ = value;
            }
        }
        public string HashesSha1Hash
        {
            get
            {
                return /*1*/Hashes/*4*/.Sha1Hash/*3*/;
            }
            set
            {
                /*1*/Hashes/*4*/.Sha1Hash/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="MimeType" /> property.</summary>
        private string _mimeType;

        public string MimeType
        {
            get
            {
                return this._mimeType;
            }
            set
            {
                this._mimeType = value;
            }
        }
        /// <summary>Backing field for <see cref="ProcessingMetadata" /> property.</summary>
        private bool? _processingMetadata;

        public bool? ProcessingMetadata
        {
            get
            {
                return this._processingMetadata;
            }
            set
            {
                this._processingMetadata = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphFile" /> instance.</summary>
        public MicrosoftGraphFile()
        {
        }
    }
    /// file
    public partial interface IMicrosoftGraphFile : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphHashes Hashes { get; set; }
        string HashesCrc32Hash { get; set; }
        string HashesQuickXorHash { get; set; }
        string HashesSha1Hash { get; set; }
        string MimeType { get; set; }
        bool? ProcessingMetadata { get; set; }
    }
}