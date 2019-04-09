namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>publicationFacet</summary>
    public partial class MicrosoftGraphPublicationFacet : Sample.API.Models.IMicrosoftGraphPublicationFacet
    {
        /// <summary>Backing field for <see cref="Level" /> property.</summary>
        private string _level;

        public string Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }
        /// <summary>Backing field for <see cref="VersionId" /> property.</summary>
        private string _versionId;

        public string VersionId
        {
            get
            {
                return this._versionId;
            }
            set
            {
                this._versionId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPublicationFacet" /> instance.</summary>
        public MicrosoftGraphPublicationFacet()
        {
        }
    }
    /// publicationFacet
    public partial interface IMicrosoftGraphPublicationFacet : Sample.API.Runtime.IJsonSerializable {
        string Level { get; set; }
        string VersionId { get; set; }
    }
}