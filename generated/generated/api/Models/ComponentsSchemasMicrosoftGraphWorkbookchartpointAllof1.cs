namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartPoint</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartPointFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartPointFormat Format
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
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _value;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1()
        {
        }
    }
    /// workbookChartPoint
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartpointAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartPointFormat Format { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Value { get; set; }
    }
}