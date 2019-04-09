namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>outlookItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphOutlookitemAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookitemAllof1
    {
        /// <summary>Backing field for <see cref="Categories" /> property.</summary>
        private string[] _categories;

        public string[] Categories
        {
            get
            {
                return this._categories;
            }
            set
            {
                this._categories = value;
            }
        }
        /// <summary>Backing field for <see cref="ChangeKey" /> property.</summary>
        private string _changeKey;

        public string ChangeKey
        {
            get
            {
                return this._changeKey;
            }
            set
            {
                this._changeKey = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private System.DateTime? _lastModifiedDateTime;

        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return this._lastModifiedDateTime;
            }
            set
            {
                this._lastModifiedDateTime = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOutlookitemAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOutlookitemAllof1()
        {
        }
    }
    /// outlookItem
    public partial interface IComponentsSchemasMicrosoftGraphOutlookitemAllof1 : Sample.API.Runtime.IJsonSerializable {
        string[] Categories { get; set; }
        string ChangeKey { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
    }
}