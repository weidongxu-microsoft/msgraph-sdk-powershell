namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>defaultColumnValue</summary>
    public partial class MicrosoftGraphDefaultColumnValue : Sample.API.Models.IMicrosoftGraphDefaultColumnValue
    {
        /// <summary>Backing field for <see cref="Formula" /> property.</summary>
        private string _formula;

        public string Formula
        {
            get
            {
                return this._formula;
            }
            set
            {
                this._formula = value;
            }
        }
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDefaultColumnValue" /> instance.</summary>
        public MicrosoftGraphDefaultColumnValue()
        {
        }
    }
    /// defaultColumnValue
    public partial interface IMicrosoftGraphDefaultColumnValue : Sample.API.Runtime.IJsonSerializable {
        string Formula { get; set; }
        string Value { get; set; }
    }
}