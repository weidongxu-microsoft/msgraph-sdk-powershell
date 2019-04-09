namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>userSettings</summary>
    public partial class ComponentsSchemasMicrosoftGraphUsersettingsAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphUsersettingsAllof1
    {
        /// <summary>
        /// Backing field for <see cref="ContributionToContentDiscoveryAsOrganizationDisabled" /> property.
        /// </summary>
        private bool? _contributionToContentDiscoveryAsOrganizationDisabled;

        public bool? ContributionToContentDiscoveryAsOrganizationDisabled
        {
            get
            {
                return this._contributionToContentDiscoveryAsOrganizationDisabled;
            }
            set
            {
                this._contributionToContentDiscoveryAsOrganizationDisabled = value;
            }
        }
        /// <summary>
        /// Backing field for <see cref="ContributionToContentDiscoveryDisabled" /> property.
        /// </summary>
        private bool? _contributionToContentDiscoveryDisabled;

        public bool? ContributionToContentDiscoveryDisabled
        {
            get
            {
                return this._contributionToContentDiscoveryDisabled;
            }
            set
            {
                this._contributionToContentDiscoveryDisabled = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphUsersettingsAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphUsersettingsAllof1()
        {
        }
    }
    /// userSettings
    public partial interface IComponentsSchemasMicrosoftGraphUsersettingsAllof1 : Sample.API.Runtime.IJsonSerializable {
        bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
        bool? ContributionToContentDiscoveryDisabled { get; set; }
    }
}