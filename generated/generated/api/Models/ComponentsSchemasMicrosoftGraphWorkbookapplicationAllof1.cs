namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookApplication</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1
    {
        /// <summary>Backing field for <see cref="CalculationMode" /> property.</summary>
        private string _calculationMode;

        public string CalculationMode
        {
            get
            {
                return this._calculationMode;
            }
            set
            {
                this._calculationMode = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1()
        {
        }
    }
    /// workbookApplication
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookapplicationAllof1 : Sample.API.Runtime.IJsonSerializable {
        string CalculationMode { get; set; }
    }
}