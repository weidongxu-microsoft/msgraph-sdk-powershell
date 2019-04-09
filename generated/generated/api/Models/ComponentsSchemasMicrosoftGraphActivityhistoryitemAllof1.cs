namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>activityHistoryItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1
    {
        /// <summary>Backing field for <see cref="ActiveDurationSeconds" /> property.</summary>
        private int? _activeDurationSeconds;

        public int? ActiveDurationSeconds
        {
            get
            {
                return this._activeDurationSeconds;
            }
            set
            {
                this._activeDurationSeconds = value;
            }
        }
        /// <summary>Backing field for <see cref="Activity" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphUserActivity _activity;

        public Sample.API.Models.IMicrosoftGraphUserActivity Activity
        {
            get
            {
                return this._activity;
            }
            set
            {
                this._activity = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="ExpirationDateTime" /> property.</summary>
        private System.DateTime? _expirationDateTime;

        public System.DateTime? ExpirationDateTime
        {
            get
            {
                return this._expirationDateTime;
            }
            set
            {
                this._expirationDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="LastActiveDateTime" /> property.</summary>
        private System.DateTime? _lastActiveDateTime;

        public System.DateTime? LastActiveDateTime
        {
            get
            {
                return this._lastActiveDateTime;
            }
            set
            {
                this._lastActiveDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private System.DateTime? _lastModifiedDateTime;

        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return this._lastModifiedDateTime;
            }
            set
            {
                this._lastModifiedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="StartedDateTime" /> property.</summary>
        private System.DateTime? _startedDateTime;

        public System.DateTime? StartedDateTime
        {
            get
            {
                return this._startedDateTime;
            }
            set
            {
                this._startedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>status</summary>
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Backing field for <see cref="UserTimezone" /> property.</summary>
        private string _userTimezone;

        public string UserTimezone
        {
            get
            {
                return this._userTimezone;
            }
            set
            {
                this._userTimezone = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1()
        {
        }
    }
    /// activityHistoryItem
    public partial interface IComponentsSchemasMicrosoftGraphActivityhistoryitemAllof1 : Sample.API.Runtime.IJsonSerializable {
        int? ActiveDurationSeconds { get; set; }
        Sample.API.Models.IMicrosoftGraphUserActivity Activity { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        System.DateTime? ExpirationDateTime { get; set; }
        System.DateTime? LastActiveDateTime { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        System.DateTime? StartedDateTime { get; set; }
        string Status { get; set; }
        string UserTimezone { get; set; }
    }
}