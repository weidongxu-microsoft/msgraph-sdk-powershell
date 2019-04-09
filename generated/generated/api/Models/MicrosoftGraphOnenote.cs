namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenote : Sample.API.Models.IMicrosoftGraphOnenote, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenote" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteAllof1 _componentsSchemasMicrosoftGraphOnenoteAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenoteAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenote" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphNotebook[] Notebooks
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteAllof1 .Notebooks;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteAllof1 .Notebooks = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenoteOperation[] Operations
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteAllof1 .Operations;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteAllof1 .Operations = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenotePage[] Pages
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteAllof1 .Pages;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteAllof1 .Pages = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenoteResource[] Resources
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteAllof1 .Resources;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteAllof1 .Resources = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSectionGroup[] SectionGroups
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteAllof1 .SectionGroups;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteAllof1 .SectionGroups = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenoteSection[] Sections
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteAllof1 .Sections;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteAllof1 .Sections = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOnenote" /> instance.</summary>
        public MicrosoftGraphOnenote()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenoteAllof1 ), _componentsSchemasMicrosoftGraphOnenoteAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenoteAllof1 ), _componentsSchemasMicrosoftGraphOnenoteAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenote : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteAllof1 {

    }
}