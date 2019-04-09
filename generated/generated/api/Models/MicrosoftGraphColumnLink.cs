namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphColumnLink : Sample.API.Models.IMicrosoftGraphColumnLink, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphColumnLink" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphColumnlinkAllof1 _componentsSchemasMicrosoftGraphColumnlinkAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphColumnlinkAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphColumnLink" /></summary>
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
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumnlinkAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumnlinkAllof1 .Name = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphColumnLink" /> instance.</summary>
        public MicrosoftGraphColumnLink()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphColumnlinkAllof1 ), _componentsSchemasMicrosoftGraphColumnlinkAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphColumnlinkAllof1 ), _componentsSchemasMicrosoftGraphColumnlinkAllof1 );
        }
    }
    public partial interface IMicrosoftGraphColumnLink : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphColumnlinkAllof1 {

    }
}