namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>outlookCategory</summary>
    public partial class ComponentsSchemasMicrosoftGraphOutlookcategoryAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookcategoryAllof1
    {
        /// <summary>Backing field for <see cref="Color" /> property.</summary>
        private string _color;

        /// <summary>categoryColor</summary>
        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOutlookcategoryAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOutlookcategoryAllof1()
        {
        }
    }
    /// outlookCategory
    public partial interface IComponentsSchemasMicrosoftGraphOutlookcategoryAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Color { get; set; }
        string DisplayName { get; set; }
    }
}