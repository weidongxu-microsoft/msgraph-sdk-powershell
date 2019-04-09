namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartFont</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1
    {
        /// <summary>Backing field for <see cref="Bold" /> property.</summary>
        private bool? _bold;

        public bool? Bold
        {
            get
            {
                return this._bold;
            }
            set
            {
                this._bold = value;
            }
        }
        /// <summary>Backing field for <see cref="Color" /> property.</summary>
        private string _color;

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
        /// <summary>Backing field for <see cref="Italic" /> property.</summary>
        private bool? _italic;

        public bool? Italic
        {
            get
            {
                return this._italic;
            }
            set
            {
                this._italic = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private double? _size;

        public double? Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        /// <summary>Backing field for <see cref="Underline" /> property.</summary>
        private string _underline;

        public string Underline
        {
            get
            {
                return this._underline;
            }
            set
            {
                this._underline = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1()
        {
        }
    }
    /// workbookChartFont
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartfontAllof1 : Sample.API.Runtime.IJsonSerializable {
        bool? Bold { get; set; }
        string Color { get; set; }
        bool? Italic { get; set; }
        string Name { get; set; }
        double? Size { get; set; }
        string Underline { get; set; }
    }
}