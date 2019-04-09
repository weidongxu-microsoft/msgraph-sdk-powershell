namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartTitle</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartTitleFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartTitleFormat Format
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
        /// <summary>Backing field for <see cref="Text" /> property.</summary>
        private string _text;

        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1()
        {
        }
    }
    /// workbookChartTitle
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookcharttitleAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartTitleFormat Format { get; set; }
        bool? Overlay { get; set; }
        string Text { get; set; }
        bool? Visible { get; set; }
    }
}