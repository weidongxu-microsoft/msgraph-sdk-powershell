namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartDataLabelFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1()
        {
        }
    }
    /// workbookChartDataLabelFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartdatalabelformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookChartFont Font { get; set; }
    }
}