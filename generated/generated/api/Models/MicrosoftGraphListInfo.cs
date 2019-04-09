namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>listInfo</summary>
    public partial class MicrosoftGraphListInfo : Sample.API.Models.IMicrosoftGraphListInfo
    {
        /// <summary>Backing field for <see cref="ContentTypesEnabled" /> property.</summary>
        private bool? _contentTypesEnabled;

        public bool? ContentTypesEnabled
        {
            get
            {
                return this._contentTypesEnabled;
            }
            set
            {
                this._contentTypesEnabled = value;
            }
        }
        /// <summary>Backing field for <see cref="Hidden" /> property.</summary>
        private bool? _hidden;

        public bool? Hidden
        {
            get
            {
                return this._hidden;
            }
            set
            {
                this._hidden = value;
            }
        }
        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        public string Template
        {
            get
            {
                return this._template;
            }
            set
            {
                this._template = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphListInfo" /> instance.</summary>
        public MicrosoftGraphListInfo()
        {
        }
    }
    /// listInfo
    public partial interface IMicrosoftGraphListInfo : Sample.API.Runtime.IJsonSerializable {
        bool? ContentTypesEnabled { get; set; }
        bool? Hidden { get; set; }
        string Template { get; set; }
    }
}