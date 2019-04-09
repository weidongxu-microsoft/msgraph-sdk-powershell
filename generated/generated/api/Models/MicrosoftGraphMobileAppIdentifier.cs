namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>mobileAppIdentifier</summary>
    public partial class MicrosoftGraphMobileAppIdentifier : Sample.API.Models.IMicrosoftGraphMobileAppIdentifier
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphMobileAppIdentifier" /> instance.</summary>
        public MicrosoftGraphMobileAppIdentifier()
        {
        }
    }
    /// mobileAppIdentifier
    public partial interface IMicrosoftGraphMobileAppIdentifier : Sample.API.Runtime.IJsonSerializable {

    }
}