namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>personOrGroupColumn</summary>
    public partial class MicrosoftGraphPersonOrGroupColumn : Sample.API.Models.IMicrosoftGraphPersonOrGroupColumn
    {
        /// <summary>Backing field for <see cref="AllowMultipleSelection" /> property.</summary>
        private bool? _allowMultipleSelection;

        public bool? AllowMultipleSelection
        {
            get
            {
                return this._allowMultipleSelection;
            }
            set
            {
                this._allowMultipleSelection = value;
            }
        }
        /// <summary>Backing field for <see cref="ChooseFromType" /> property.</summary>
        private string _chooseFromType;

        public string ChooseFromType
        {
            get
            {
                return this._chooseFromType;
            }
            set
            {
                this._chooseFromType = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphPersonOrGroupColumn" /> instance.</summary>
        public MicrosoftGraphPersonOrGroupColumn()
        {
        }
    }
    /// personOrGroupColumn
    public partial interface IMicrosoftGraphPersonOrGroupColumn : Sample.API.Runtime.IJsonSerializable {
        bool? AllowMultipleSelection { get; set; }
        string ChooseFromType { get; set; }
        string DisplayAs { get; set; }
    }
}