namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>identitySet</summary>
    public partial class MicrosoftGraphIdentitySet : Sample.API.Models.IMicrosoftGraphIdentitySet
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
        /// <summary>Backing field for <see cref="Device" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentity _device;

        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity Device
        {
            get
            {
                return this._device;
            }
            set
            {
                this._device = value;
            }
        }
        public string DeviceDisplayName
        {
            get
            {
                return /*1*/Device/*4*/.DisplayName/*3*/;
            }
            set
            {
                /*1*/Device/*4*/.DisplayName/*3*/ = value;
            }
        }
        public string DeviceId
        {
            get
            {
                return /*1*/Device/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/Device/*4*/.Id/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentity _user;

        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity User
        {
            get
            {
                return this._user;
            }
            set
            {
                this._user = value;
            }
        }
        public string UserDisplayName
        {
            get
            {
                return /*1*/User/*4*/.DisplayName/*3*/;
            }
            set
            {
                /*1*/User/*4*/.DisplayName/*3*/ = value;
            }
        }
        public string UserId
        {
            get
            {
                return /*1*/User/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/User/*4*/.Id/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphIdentitySet" /> instance.</summary>
        public MicrosoftGraphIdentitySet()
        {
        }
    }
    /// identitySet
    public partial interface IMicrosoftGraphIdentitySet : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphIdentity Application { get; set; }
        string ApplicationDisplayName { get; set; }
        string ApplicationId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity Device { get; set; }
        string DeviceDisplayName { get; set; }
        string DeviceId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity User { get; set; }
        string UserDisplayName { get; set; }
        string UserId { get; set; }
    }
}