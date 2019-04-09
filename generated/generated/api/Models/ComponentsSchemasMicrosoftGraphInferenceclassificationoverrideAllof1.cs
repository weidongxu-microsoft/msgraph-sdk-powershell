namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>inferenceClassificationOverride</summary>
    public partial class ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1
    {
        public string AddressSenderEmailAddress
        {
            get
            {
                return /*1*/SenderEmailAddress/*4*/.Address/*3*/;
            }
            set
            {
                /*1*/SenderEmailAddress/*4*/.Address/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ClassifyAs" /> property.</summary>
        private string _classifyAs;

        /// <summary>inferenceClassificationType</summary>
        public string ClassifyAs
        {
            get
            {
                return this._classifyAs;
            }
            set
            {
                this._classifyAs = value;
            }
        }
        /// <summary>Backing field for <see cref="SenderEmailAddress" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEmailAddress _senderEmailAddress;

        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress SenderEmailAddress
        {
            get
            {
                return this._senderEmailAddress;
            }
            set
            {
                this._senderEmailAddress = value;
            }
        }
        public string SenderEmailAddressName
        {
            get
            {
                return /*1*/SenderEmailAddress/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/SenderEmailAddress/*4*/.Name/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1()
        {
        }
    }
    /// inferenceClassificationOverride
    public partial interface IComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 : Sample.API.Runtime.IJsonSerializable {
        string AddressSenderEmailAddress { get; set; }
        string ClassifyAs { get; set; }
        Sample.API.Models.IMicrosoftGraphEmailAddress SenderEmailAddress { get; set; }
        string SenderEmailAddressName { get; set; }
    }
}