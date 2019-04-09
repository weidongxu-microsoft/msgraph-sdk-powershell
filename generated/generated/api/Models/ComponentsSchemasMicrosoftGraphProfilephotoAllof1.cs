namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>profilePhoto</summary>
    public partial class ComponentsSchemasMicrosoftGraphProfilephotoAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphProfilephotoAllof1
    {
        /// <summary>Backing field for <see cref="Height" /> property.</summary>
        private int? _height;

        public int? Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        /// <summary>Backing field for <see cref="Width" /> property.</summary>
        private int? _width;

        public int? Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphProfilephotoAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphProfilephotoAllof1()
        {
        }
    }
    /// profilePhoto
    public partial interface IComponentsSchemasMicrosoftGraphProfilephotoAllof1 : Sample.API.Runtime.IJsonSerializable {
        int? Height { get; set; }
        int? Width { get; set; }
    }
}