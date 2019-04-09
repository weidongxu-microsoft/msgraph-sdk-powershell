namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>choiceColumn</summary>
    public partial class MicrosoftGraphChoiceColumn : Sample.API.Models.IMicrosoftGraphChoiceColumn
    {
        /// <summary>Backing field for <see cref="AllowTextEntry" /> property.</summary>
        private bool? _allowTextEntry;

        public bool? AllowTextEntry
        {
            get
            {
                return this._allowTextEntry;
            }
            set
            {
                this._allowTextEntry = value;
            }
        }
        /// <summary>Backing field for <see cref="Choices" /> property.</summary>
        private string[] _choices;

        public string[] Choices
        {
            get
            {
                return this._choices;
            }
            set
            {
                this._choices = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayAs" /> property.</summary>
        private string _displayAs;

        public string DisplayAs
        {
            get
            {
                return this._displayAs;
            }
            set
            {
                this._displayAs = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphChoiceColumn" /> instance.</summary>
        public MicrosoftGraphChoiceColumn()
        {
        }
    }
    /// choiceColumn
    public partial interface IMicrosoftGraphChoiceColumn : Sample.API.Runtime.IJsonSerializable {
        bool? AllowTextEntry { get; set; }
        string[] Choices { get; set; }
        string DisplayAs { get; set; }
    }
}