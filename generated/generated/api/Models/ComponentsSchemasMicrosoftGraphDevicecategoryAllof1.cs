namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>deviceCategory</summary>
    public partial class ComponentsSchemasMicrosoftGraphDevicecategoryAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecategoryAllof1
    {
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Optional description for the device category.</summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name for the device category.</summary>
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphDevicecategoryAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphDevicecategoryAllof1()
        {
        }
    }
    /// deviceCategory
    public partial interface IComponentsSchemasMicrosoftGraphDevicecategoryAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Description { get; set; }
        string DisplayName { get; set; }
    }
}