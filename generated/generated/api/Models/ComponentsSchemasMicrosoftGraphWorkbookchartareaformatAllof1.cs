namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartAreaFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartareaformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartareaformatAllof1
    {
        /// <summary>Backing field for <see cref="Fill" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartFill _fill;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill
        {
            get
            {
                return this._fill;
            }
            set
            {
                this._fill = value;
            }
        }
        /// <summary>Backing field for <see cref="Font" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartFont _font;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font
        {
            get
            {
                return this._font;
            }
            set
            {
                this._font = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartareaformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartareaformatAllof1()
        {
        }
    }
    /// workbookChartAreaFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartareaformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font { get; set; }
    }
}