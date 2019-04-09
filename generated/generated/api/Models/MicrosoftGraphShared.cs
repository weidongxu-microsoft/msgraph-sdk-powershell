namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>shared</summary>
    public partial class MicrosoftGraphShared : Sample.API.Models.IMicrosoftGraphShared
    {
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/SharedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return /*1*/SharedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/SharedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return /*1*/SharedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/Owner/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/Owner/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return /*1*/Owner/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return /*1*/Owner/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return /*1*/Owner/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return /*1*/Owner/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _owner;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication
        {
            get
            {
                return /*1*/Owner/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice
        {
            get
            {
                return /*1*/Owner/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerUser
        {
            get
            {
                return /*1*/Owner/*4*/.User/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.User/*3*/ = value;
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
        /// <summary>Backing field for <see cref="SharedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _sharedBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet SharedBy
        {
            get
            {
                return this._sharedBy;
            }
            set
            {
                this._sharedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByApplication
        {
            get
            {
                return /*1*/SharedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByDevice
        {
            get
            {
                return /*1*/SharedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByUser
        {
            get
            {
                return /*1*/SharedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.User/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SharedDateTime" /> property.</summary>
        private System.DateTime? _sharedDateTime;

        public System.DateTime? SharedDateTime
        {
            get
            {
                return this._sharedDateTime;
            }
            set
            {
                this._sharedDateTime = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return /*1*/SharedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return /*1*/SharedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphShared" /> instance.</summary>
        public MicrosoftGraphShared()
        {
        }
    }
    /// shared
    public partial interface IMicrosoftGraphShared : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayNameApplicationDisplayName { get; set; }
        string ApplicationIdApplicationId { get; set; }
        string DeviceDisplayNameDeviceDisplayName { get; set; }
        string DeviceIdDeviceId { get; set; }
        string DisplayNameApplicationDisplayName { get; set; }
        string DisplayNameDeviceDisplayName { get; set; }
        string DisplayNameUserDisplayName { get; set; }
        string IdApplicationId { get; set; }
        string IdDeviceId { get; set; }
        string IdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet Owner { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerUser { get; set; }
        string Scope { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet SharedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByUser { get; set; }
        System.DateTime? SharedDateTime { get; set; }
        string UserDisplayNameUserDisplayName { get; set; }
        string UserIdUserId { get; set; }
    }
}