namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>passwordProfile</summary>
    public partial class MicrosoftGraphPasswordProfile : Sample.API.Models.IMicrosoftGraphPasswordProfile
    {
        /// <summary>Backing field for <see cref="ForceChangePasswordNextSignIn" /> property.</summary>
        private bool? _forceChangePasswordNextSignIn;

        public bool? ForceChangePasswordNextSignIn
        {
            get
            {
                return this._forceChangePasswordNextSignIn;
            }
            set
            {
                this._forceChangePasswordNextSignIn = value;
            }
        }
        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPasswordProfile" /> instance.</summary>
        public MicrosoftGraphPasswordProfile()
        {
        }
    }
    /// passwordProfile
    public partial interface IMicrosoftGraphPasswordProfile : Sample.API.Runtime.IJsonSerializable {
        bool? ForceChangePasswordNextSignIn { get; set; }
        string Password { get; set; }
    }
}