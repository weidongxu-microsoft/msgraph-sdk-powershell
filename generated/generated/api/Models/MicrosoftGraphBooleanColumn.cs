namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>booleanColumn</summary>
    public partial class MicrosoftGraphBooleanColumn : Sample.API.Models.IMicrosoftGraphBooleanColumn
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphBooleanColumn" /> instance.</summary>
        public MicrosoftGraphBooleanColumn()
        {
        }
    }
    /// booleanColumn
    public partial interface IMicrosoftGraphBooleanColumn : Sample.API.Runtime.IJsonSerializable {

    }
}