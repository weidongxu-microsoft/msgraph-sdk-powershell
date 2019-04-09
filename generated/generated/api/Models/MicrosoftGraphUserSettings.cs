namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphUserSettings : Sample.API.Models.IMicrosoftGraphUserSettings, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphUserSettings" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphUsersettingsAllof1 _componentsSchemasMicrosoftGraphUsersettingsAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphUsersettingsAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphUserSettings" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsersettingsAllof1 .ContributionToContentDiscoveryAsOrganizationDisabled;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsersettingsAllof1 .ContributionToContentDiscoveryAsOrganizationDisabled = value;
            }
        }
        public bool? ContributionToContentDiscoveryDisabled
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUsersettingsAllof1 .ContributionToContentDiscoveryDisabled;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUsersettingsAllof1 .ContributionToContentDiscoveryDisabled = value;
            }
        }
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
        /// <summary>Creates an new <see cref="MicrosoftGraphUserSettings" /> instance.</summary>
        public MicrosoftGraphUserSettings()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphUsersettingsAllof1 ), _componentsSchemasMicrosoftGraphUsersettingsAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphUsersettingsAllof1 ), _componentsSchemasMicrosoftGraphUsersettingsAllof1 );
        }
    }
    public partial interface IMicrosoftGraphUserSettings : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphUsersettingsAllof1 {

    }
}