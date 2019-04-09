namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbook</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookAllof1
    {
        /// <summary>Backing field for <see cref="Application" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookApplication _application;

        public Sample.API.Models.IMicrosoftGraphWorkbookApplication Application
        {
            get
            {
                return this._application;
            }
            set
            {
                this._application = value;
            }
        }
        /// <summary>Backing field for <see cref="Functions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookFunctions _functions;

        public Sample.API.Models.IMicrosoftGraphWorkbookFunctions Functions
        {
            get
            {
                return this._functions;
            }
            set
            {
                this._functions = value;
            }
        }
        /// <summary>Backing field for <see cref="Names" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] _names;

        public Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] Names
        {
            get
            {
                return this._names;
            }
            set
            {
                this._names = value;
            }
        }
        /// <summary>Backing field for <see cref="Tables" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookTable[] _tables;

        public Sample.API.Models.IMicrosoftGraphWorkbookTable[] Tables
        {
            get
            {
                return this._tables;
            }
            set
            {
                this._tables = value;
            }
        }
        /// <summary>Backing field for <see cref="Worksheets" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookWorksheet[] _worksheets;

        public Sample.API.Models.IMicrosoftGraphWorkbookWorksheet[] Worksheets
        {
            get
            {
                return this._worksheets;
            }
            set
            {
                this._worksheets = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookAllof1()
        {
        }
    }
    /// workbook
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookApplication Application { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookFunctions Functions { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookNamedItem[] Names { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookTable[] Tables { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookWorksheet[] Worksheets { get; set; }
    }
}