namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>outlookUser</summary>
    public partial class ComponentsSchemasMicrosoftGraphOutlookuserAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOutlookuserAllof1
    {
        /// <summary>Backing field for <see cref="MasterCategories" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOutlookCategory[] _masterCategories;

        public Sample.API.Models.IMicrosoftGraphOutlookCategory[] MasterCategories
        {
            get
            {
                return this._masterCategories;
            }
            set
            {
                this._masterCategories = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOutlookuserAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOutlookuserAllof1()
        {
        }
    }
    /// outlookUser
    public partial interface IComponentsSchemasMicrosoftGraphOutlookuserAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphOutlookCategory[] MasterCategories { get; set; }
    }
}