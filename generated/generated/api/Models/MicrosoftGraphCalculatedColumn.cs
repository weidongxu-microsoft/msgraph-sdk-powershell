namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>calculatedColumn</summary>
    public partial class MicrosoftGraphCalculatedColumn : Sample.API.Models.IMicrosoftGraphCalculatedColumn
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private string _format;

        public string Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
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
        /// <summary>Backing field for <see cref="OutputType" /> property.</summary>
        private string _outputType;

        public string OutputType
        {
            get
            {
                return this._outputType;
            }
            set
            {
                this._outputType = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphCalculatedColumn" /> instance.</summary>
        public MicrosoftGraphCalculatedColumn()
        {
        }
    }
    /// calculatedColumn
    public partial interface IMicrosoftGraphCalculatedColumn : Sample.API.Runtime.IJsonSerializable {
        string Format { get; set; }
        string Formula { get; set; }
        string OutputType { get; set; }
    }
}