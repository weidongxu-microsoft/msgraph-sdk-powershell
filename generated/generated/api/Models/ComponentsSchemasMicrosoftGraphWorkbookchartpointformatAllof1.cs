namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartPointFormat</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1()
        {
        }
    }
    /// workbookChartPointFormat
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartpointformatAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartFill Fill { get; set; }
    }
}