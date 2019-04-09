namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>textColumn</summary>
    public partial class MicrosoftGraphTextColumn : Sample.API.Models.IMicrosoftGraphTextColumn
    {
        /// <summary>Backing field for <see cref="AllowMultipleLines" /> property.</summary>
        private bool? _allowMultipleLines;

        public bool? AllowMultipleLines
        {
            get
            {
                return this._allowMultipleLines;
            }
            set
            {
                this._allowMultipleLines = value;
            }
        }
        /// <summary>Backing field for <see cref="AppendChangesToExistingText" /> property.</summary>
        private bool? _appendChangesToExistingText;

        public bool? AppendChangesToExistingText
        {
            get
            {
                return this._appendChangesToExistingText;
            }
            set
            {
                this._appendChangesToExistingText = value;
            }
        }
        /// <summary>Backing field for <see cref="LinesForEditing" /> property.</summary>
        private int? _linesForEditing;

        public int? LinesForEditing
        {
            get
            {
                return this._linesForEditing;
            }
            set
            {
                this._linesForEditing = value;
            }
        }
        /// <summary>Backing field for <see cref="MaxLength" /> property.</summary>
        private int? _maxLength;

        public int? MaxLength
        {
            get
            {
                return this._maxLength;
            }
            set
            {
                this._maxLength = value;
            }
        }
        /// <summary>Backing field for <see cref="TextType" /> property.</summary>
        private string _textType;

        public string TextType
        {
            get
            {
                return this._textType;
            }
            set
            {
                this._textType = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphTextColumn" /> instance.</summary>
        public MicrosoftGraphTextColumn()
        {
        }
    }
    /// textColumn
    public partial interface IMicrosoftGraphTextColumn : Sample.API.Runtime.IJsonSerializable {
        bool? AllowMultipleLines { get; set; }
        bool? AppendChangesToExistingText { get; set; }
        int? LinesForEditing { get; set; }
        int? MaxLength { get; set; }
        string TextType { get; set; }
    }
}