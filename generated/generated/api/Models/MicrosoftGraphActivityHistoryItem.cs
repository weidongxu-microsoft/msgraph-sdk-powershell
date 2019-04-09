namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphActivityHistoryItem : Sample.API.Models.IMicrosoftGraphActivityHistoryItem, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphActivityHistoryItem" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1 _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphActivityHistoryItem" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public int? ActiveDurationSeconds
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .ActiveDurationSeconds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .ActiveDurationSeconds = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUserActivity Activity
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .Activity;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .Activity = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .CreatedDateTime = value;
            }
        }
        public System.DateTime? ExpirationDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .ExpirationDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .ExpirationDateTime = value;
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
        public System.DateTime? LastActiveDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .LastActiveDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .LastActiveDateTime = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .LastModifiedDateTime = value;
            }
        }
        public System.DateTime? StartedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .StartedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .StartedDateTime = value;
            }
        }
        /// <summary>status</summary>
        public string Status
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .Status;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .Status = value;
            }
        }
        public string UserTimezone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .UserTimezone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 .UserTimezone = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphActivityHistoryItem" /> instance.</summary>
        public MicrosoftGraphActivityHistoryItem()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 ), _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 ), _componentsSchemasMicrosoftGraphActivityhistoryitemAllof1 );
        }
    }
    public partial interface IMicrosoftGraphActivityHistoryItem : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1 {

    }
}