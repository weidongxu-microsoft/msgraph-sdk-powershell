namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharingInvitation</summary>
    public partial class MicrosoftGraphSharingInvitation : Sample.API.Models.IMicrosoftGraphSharingInvitation
    {
        public string ApplicationDisplayName
        {
            get
            {
                return /*1*/InvitedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationId
        {
            get
            {
                return /*1*/InvitedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string DeviceDisplayName
        {
            get
            {
                return /*1*/InvitedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceId
        {
            get
            {
                return /*1*/InvitedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.DeviceId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        /// <summary>Backing field for <see cref="InvitedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _invitedBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet InvitedBy
        {
            get
            {
                return this._invitedBy;
            }
            set
            {
                this._invitedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByApplication
        {
            get
            {
                return /*1*/InvitedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByDevice
        {
            get
            {
                return /*1*/InvitedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByUser
        {
            get
            {
                return /*1*/InvitedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.User/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="RedeemedBy" /> property.</summary>
        private string _redeemedBy;

        public string RedeemedBy
        {
            get
            {
                return this._redeemedBy;
            }
            set
            {
                this._redeemedBy = value;
            }
        }
        /// <summary>Backing field for <see cref="SignInRequired" /> property.</summary>
        private bool? _signInRequired;

        public bool? SignInRequired
        {
            get
            {
                return this._signInRequired;
            }
            set
            {
                this._signInRequired = value;
            }
        }
        public string UserDisplayName
        {
            get
            {
                return /*1*/InvitedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string UserId
        {
            get
            {
                return /*1*/InvitedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/InvitedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSharingInvitation" /> instance.</summary>
        public MicrosoftGraphSharingInvitation()
        {
        }
    }
    /// sharingInvitation
    public partial interface IMicrosoftGraphSharingInvitation : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayName { get; set; }
        string ApplicationId { get; set; }
        string DeviceDisplayName { get; set; }
        string DeviceId { get; set; }
        string Email { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet InvitedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity InvitedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity InvitedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity InvitedByUser { get; set; }
        string RedeemedBy { get; set; }
        bool? SignInRequired { get; set; }
        string UserDisplayName { get; set; }
        string UserId { get; set; }
    }
}