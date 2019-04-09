namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOfficeGraphInsights : Sample.API.Models.IMicrosoftGraphOfficeGraphInsights, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOfficeGraphInsights" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOfficeGraphInsights" /></summary>
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
        public Sample.API.Models.IMicrosoftGraphSharedInsight[] Shared
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 .Shared;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 .Shared = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphTrending[] Trending
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 .Trending;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 .Trending = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUsedInsight[] Used
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 .Used;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 .Used = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOfficeGraphInsights" /> instance.</summary>
        public MicrosoftGraphOfficeGraphInsights()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 ), _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 ), _componentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOfficeGraphInsights : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 {

    }
}