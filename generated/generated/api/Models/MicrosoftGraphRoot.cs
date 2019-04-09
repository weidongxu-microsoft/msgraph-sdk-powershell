namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>root</summary>
    public partial class MicrosoftGraphRoot : Sample.API.Models.IMicrosoftGraphRoot
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphRoot" /> instance.</summary>
        public MicrosoftGraphRoot()
        {
        }
    }
    /// root
    public partial interface IMicrosoftGraphRoot : Sample.API.Runtime.IJsonSerializable {

    }
}