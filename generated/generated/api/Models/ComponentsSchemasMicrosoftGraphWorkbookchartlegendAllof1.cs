namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartLegend</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartLegendFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartLegendFormat Format
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
        /// <summary>Backing field for <see cref="Overlay" /> property.</summary>
        private bool? _overlay;

        public bool? Overlay
        {
            get
            {
                return this._overlay;
            }
            set
            {
                this._overlay = value;
            }
        }
        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private string _position;

        public string Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1()
        {
        }
    }
    /// workbookChartLegend
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartlegendAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartLegendFormat Format { get; set; }
        bool? Overlay { get; set; }
        string Position { get; set; }
        bool? Visible { get; set; }
    }
}