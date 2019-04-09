namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookChartAxisTitle</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1
    {
        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitleFormat _format;

        public Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitleFormat Format
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1()
        {
        }
    }
    /// workbookChartAxisTitle
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookchartaxistitleAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookChartAxisTitleFormat Format { get; set; }
        string Text { get; set; }
        bool? Visible { get; set; }
    }
}