namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenote</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenoteAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteAllof1
    {
        /// <summary>Backing field for <see cref="Notebooks" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphNotebook[] _notebooks;

        public Sample.API.Models.IMicrosoftGraphNotebook[] Notebooks
        {
            get
            {
                return this._notebooks;
            }
            set
            {
                this._notebooks = value;
            }
        }
        /// <summary>Backing field for <see cref="Operations" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteOperation[] _operations;

        public Sample.API.Models.IMicrosoftGraphOnenoteOperation[] Operations
        {
            get
            {
                return this._operations;
            }
            set
            {
                this._operations = value;
            }
        }
        /// <summary>Backing field for <see cref="Pages" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenotePage[] _pages;

        public Sample.API.Models.IMicrosoftGraphOnenotePage[] Pages
        {
            get
            {
                return this._pages;
            }
            set
            {
                this._pages = value;
            }
        }
        /// <summary>Backing field for <see cref="Resources" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteResource[] _resources;

        public Sample.API.Models.IMicrosoftGraphOnenoteResource[] Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        /// <summary>Backing field for <see cref="SectionGroups" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSectionGroup[] _sectionGroups;

        public Sample.API.Models.IMicrosoftGraphSectionGroup[] SectionGroups
        {
            get
            {
                return this._sectionGroups;
            }
            set
            {
                this._sectionGroups = value;
            }
        }
        /// <summary>Backing field for <see cref="Sections" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteSection[] _sections;

        public Sample.API.Models.IMicrosoftGraphOnenoteSection[] Sections
        {
            get
            {
                return this._sections;
            }
            set
            {
                this._sections = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenoteAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenoteAllof1()
        {
        }
    }
    /// onenote
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphNotebook[] Notebooks { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenoteOperation[] Operations { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenotePage[] Pages { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenoteResource[] Resources { get; set; }
        Sample.API.Models.IMicrosoftGraphSectionGroup[] SectionGroups { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenoteSection[] Sections { get; set; }
    }
}