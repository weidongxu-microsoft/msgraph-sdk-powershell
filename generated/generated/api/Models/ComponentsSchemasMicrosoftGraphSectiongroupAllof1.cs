namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sectionGroup</summary>
    public partial class ComponentsSchemasMicrosoftGraphSectiongroupAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphSectiongroupAllof1
    {
        /// <summary>Backing field for <see cref="ParentNotebook" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphNotebook _parentNotebook;

        public Sample.API.Models.IMicrosoftGraphNotebook ParentNotebook
        {
            get
            {
                return this._parentNotebook;
            }
            set
            {
                this._parentNotebook = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentSectionGroup" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSectionGroup _parentSectionGroup;

        public Sample.API.Models.IMicrosoftGraphSectionGroup ParentSectionGroup
        {
            get
            {
                return this._parentSectionGroup;
            }
            set
            {
                this._parentSectionGroup = value;
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
        /// <summary>Backing field for <see cref="SectionGroupsUrl" /> property.</summary>
        private string _sectionGroupsUrl;

        public string SectionGroupsUrl
        {
            get
            {
                return this._sectionGroupsUrl;
            }
            set
            {
                this._sectionGroupsUrl = value;
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
        /// <summary>Backing field for <see cref="SectionsUrl" /> property.</summary>
        private string _sectionsUrl;

        public string SectionsUrl
        {
            get
            {
                return this._sectionsUrl;
            }
            set
            {
                this._sectionsUrl = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphSectiongroupAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphSectiongroupAllof1()
        {
        }
    }
    /// sectionGroup
    public partial interface IComponentsSchemasMicrosoftGraphSectiongroupAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphNotebook ParentNotebook { get; set; }
        Sample.API.Models.IMicrosoftGraphSectionGroup ParentSectionGroup { get; set; }
        Sample.API.Models.IMicrosoftGraphSectionGroup[] SectionGroups { get; set; }
        string SectionGroupsUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenoteSection[] Sections { get; set; }
        string SectionsUrl { get; set; }
    }
}