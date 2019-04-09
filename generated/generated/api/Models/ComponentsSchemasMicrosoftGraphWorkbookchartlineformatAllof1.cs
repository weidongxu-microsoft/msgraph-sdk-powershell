namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartLineFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1
    {
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1()
        {
        }
    }
    /// workbookChartLineFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartlineformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Color { get; set; }
    }
}