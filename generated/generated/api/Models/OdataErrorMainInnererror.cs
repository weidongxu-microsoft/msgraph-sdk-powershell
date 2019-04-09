namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>The structure of this object is service-specific</summary>
    public partial class OdataErrorMainInnererror : Sample.API.Models.IOdataErrorMainInnererror
    {

        /// <summary>Creates an new <see cref="OdataErrorMainInnererror" /> instance.</summary>
        public OdataErrorMainInnererror()
        {
        }
    }
    /// The structure of this object is service-specific
    public partial interface IOdataErrorMainInnererror : Sample.API.Runtime.IJsonSerializable {

    }
}