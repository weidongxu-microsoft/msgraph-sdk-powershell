namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>settingSource</summary>
    public partial class MicrosoftGraphSettingSource : Sample.API.Models.IMicrosoftGraphSettingSource
    {
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSettingSource" /> instance.</summary>
        public MicrosoftGraphSettingSource()
        {
        }
    }
    /// settingSource
    public partial interface IMicrosoftGraphSettingSource : Sample.API.Runtime.IJsonSerializable {
        string DisplayName { get; set; }
        string Id { get; set; }
    }
}