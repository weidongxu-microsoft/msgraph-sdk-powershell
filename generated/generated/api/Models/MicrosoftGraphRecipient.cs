namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>recipient</summary>
    public partial class MicrosoftGraphRecipient : Sample.API.Models.IMicrosoftGraphRecipient
    {
        public string AddressEmailAddress
        {
            get
            {
                return /*1*/EmailAddress/*4*/.Address/*3*/;
            }
            set
            {
                /*1*/EmailAddress/*4*/.Address/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="EmailAddress" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEmailAddress _emailAddress;

        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress EmailAddress
        {
            get
            {
                return this._emailAddress;
            }
            set
            {
                this._emailAddress = value;
            }
        }
        public string EmailAddressName
        {
            get
            {
                return /*1*/EmailAddress/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/EmailAddress/*4*/.Name/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphRecipient" /> instance.</summary>
        public MicrosoftGraphRecipient()
        {
        }
    }
    /// recipient
    public partial interface IMicrosoftGraphRecipient : Sample.API.Runtime.IJsonSerializable {
        string AddressEmailAddress { get; set; }
        Sample.API.Models.IMicrosoftGraphEmailAddress EmailAddress { get; set; }
        string EmailAddressName { get; set; }
    }
}