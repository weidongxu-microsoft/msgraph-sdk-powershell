namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>hashes</summary>
    public partial class MicrosoftGraphHashes : Sample.API.Models.IMicrosoftGraphHashes
    {
        /// <summary>Backing field for <see cref="Crc32Hash" /> property.</summary>
        private string _crc32Hash;

        public string Crc32Hash
        {
            get
            {
                return this._crc32Hash;
            }
            set
            {
                this._crc32Hash = value;
            }
        }
        /// <summary>Backing field for <see cref="QuickXorHash" /> property.</summary>
        private string _quickXorHash;

        public string QuickXorHash
        {
            get
            {
                return this._quickXorHash;
            }
            set
            {
                this._quickXorHash = value;
            }
        }
        /// <summary>Backing field for <see cref="Sha1Hash" /> property.</summary>
        private string _sha1Hash;

        public string Sha1Hash
        {
            get
            {
                return this._sha1Hash;
            }
            set
            {
                this._sha1Hash = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphHashes" /> instance.</summary>
        public MicrosoftGraphHashes()
        {
        }
    }
    /// hashes
    public partial interface IMicrosoftGraphHashes : Sample.API.Runtime.IJsonSerializable {
        string Crc32Hash { get; set; }
        string QuickXorHash { get; set; }
        string Sha1Hash { get; set; }
    }
}