namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>systemFacet</summary>
    public partial class MicrosoftGraphSystemFacet : Sample.API.Models.IMicrosoftGraphSystemFacet
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphSystemFacet" /> instance.</summary>
        public MicrosoftGraphSystemFacet()
        {
        }
    }
    /// systemFacet
    public partial interface IMicrosoftGraphSystemFacet : Sample.API.Runtime.IJsonSerializable {

    }
}