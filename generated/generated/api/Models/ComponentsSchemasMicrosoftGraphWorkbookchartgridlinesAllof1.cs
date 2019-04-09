namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartGridlines</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartGridlinesFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartGridlinesFormat Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private bool? _visible;

        public bool? Visible
        {
            get
            {
                return this._visible;
            }
            set
            {
                this._visible = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1()
        {
        }
    }
    /// workbookChartGridlines
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartgridlinesAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartGridlinesFormat Format { get; set; }
        bool? Visible { get; set; }
    }
}