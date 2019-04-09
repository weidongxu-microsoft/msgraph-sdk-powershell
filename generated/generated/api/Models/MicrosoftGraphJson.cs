namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>Json</summary>
    public partial class MicrosoftGraphJson : Sample.API.Models.IMicrosoftGraphJson
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphJson" /> instance.</summary>
        public MicrosoftGraphJson()
        {
        }
    }
    /// Json
    public partial interface IMicrosoftGraphJson : Sample.API.Runtime.IJsonSerializable {

    }
}