namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharingLink</summary>
    public partial class MicrosoftGraphSharingLink : Sample.API.Models.IMicrosoftGraphSharingLink
    {
        /// <summary>Backing field for <see cref="Application" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentity _application;

        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity Application
        {
            get
            {
                return this._application;
            }
            set
            {
                this._application = value;
            }
        }
        public string ApplicationDisplayName
        {
            get
            {
                return /*1*/Application/*4*/.DisplayName/*3*/;
            }
            set
            {
                /*1*/Application/*4*/.DisplayName/*3*/ = value;
            }
        }
        public string ApplicationId
        {
            get
            {
                return /*1*/Application/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/Application/*4*/.Id/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        public string Scope
        {
            get
            {
                return this._scope;
            }
            set
            {
                this._scope = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Backing field for <see cref="WebUrl" /> property.</summary>
        private string _webUrl;

        public string WebUrl
        {
            get
            {
                return this._webUrl;
            }
            set
            {
                this._webUrl = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSharingLink" /> instance.</summary>
        public MicrosoftGraphSharingLink()
        {
        }
    }
    /// sharingLink
    public partial interface IMicrosoftGraphSharingLink : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphIdentity Application { get; set; }
        string ApplicationDisplayName { get; set; }
        string ApplicationId { get; set; }
        string Scope { get; set; }
        string Type { get; set; }
        string WebUrl { get; set; }
    }
}