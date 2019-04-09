namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphMessage : Sample.API.Models.IMicrosoftGraphMessage, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphMessage" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageAllof1 _componentsSchemasMicrosoftGraphMessageAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphMessageAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphMessage" /></summary>
        private Sample.API.Models.IMicrosoftGraphOutlookItem _microsoftGraphOutlookItem = new Sample.API.Models.MicrosoftGraphOutlookItem ();
        public string AddressEmailAddressAddressEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .AddressEmailAddressAddressEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .AddressEmailAddressAddressEmailAddress = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphAttachment[] Attachments
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .Attachments;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .Attachments = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] BccRecipients
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .BccRecipients;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .BccRecipients = value;
            }
        }
        /// <summary>itemBody</summary>
        public Sample.API.Models.IMicrosoftGraphItemBody Body
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .Body;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .Body = value;
            }
        }
        public string BodyContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .BodyContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .BodyContent = value;
            }
        }
        /// <summary>bodyType</summary>
        public string BodyContentType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .BodyContentType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .BodyContentType = value;
            }
        }
        public string BodyPreview
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .BodyPreview;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .BodyPreview = value;
            }
        }
        public string[] Categories
        {
            get
            {
                return _microsoftGraphOutlookItem .Categories;
            }
            set
            {
                _microsoftGraphOutlookItem .Categories = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] CcRecipients
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .CcRecipients;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .CcRecipients = value;
            }
        }
        public string ChangeKey
        {
            get
            {
                return _microsoftGraphOutlookItem .ChangeKey;
            }
            set
            {
                _microsoftGraphOutlookItem .ChangeKey = value;
            }
        }
        public string CompletedDateTimeDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .CompletedDateTimeDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .CompletedDateTimeDateTime = value;
            }
        }
        public string CompletedDateTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .CompletedDateTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .CompletedDateTimeZone = value;
            }
        }
        public string ConversationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .ConversationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .ConversationId = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphOutlookItem .CreatedDateTime;
            }
            set
            {
                _microsoftGraphOutlookItem .CreatedDateTime = value;
            }
        }
        public string DueDateTimeDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .DueDateTimeDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .DueDateTimeDateTime = value;
            }
        }
        public string DueDateTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .DueDateTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .DueDateTimeZone = value;
            }
        }
        public string EmailAddressAddressEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .EmailAddressAddressEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .EmailAddressAddressEmailAddress = value;
            }
        }
        public string EmailAddressNameEmailAddressName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .EmailAddressNameEmailAddressName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .EmailAddressNameEmailAddressName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphExtension[] Extensions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .Extensions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .Extensions = value;
            }
        }
        /// <summary>followupFlag</summary>
        public Sample.API.Models.IMicrosoftGraphFollowupFlag Flag
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .Flag;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .Flag = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone FlagCompletedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .FlagCompletedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .FlagCompletedDateTime = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone FlagDueDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .FlagDueDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .FlagDueDateTime = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone FlagStartDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .FlagStartDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .FlagStartDateTime = value;
            }
        }
        /// <summary>followupFlagStatus</summary>
        public string FlagStatus
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .FlagStatus;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .FlagStatus = value;
            }
        }
        /// <summary>recipient</summary>
        public Sample.API.Models.IMicrosoftGraphRecipient From
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .From;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .From = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress FromEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .FromEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .FromEmailAddress = value;
            }
        }
        public bool? HasAttachments
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .HasAttachments;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .HasAttachments = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOutlookItem .Id;
            }
            set
            {
                _microsoftGraphOutlookItem .Id = value;
            }
        }
        /// <summary>importance</summary>
        public string Importance
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .Importance;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .Importance = value;
            }
        }
        /// <summary>inferenceClassificationType</summary>
        public string InferenceClassification
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .InferenceClassification;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .InferenceClassification = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphInternetMessageHeader[] InternetMessageHeaders
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .InternetMessageHeaders;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .InternetMessageHeaders = value;
            }
        }
        public string InternetMessageId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .InternetMessageId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .InternetMessageId = value;
            }
        }
        public bool? IsDeliveryReceiptRequested
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .IsDeliveryReceiptRequested;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .IsDeliveryReceiptRequested = value;
            }
        }
        public bool? IsDraft
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .IsDraft;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .IsDraft = value;
            }
        }
        public bool? IsRead
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .IsRead;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .IsRead = value;
            }
        }
        public bool? IsReadReceiptRequested
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .IsReadReceiptRequested;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .IsReadReceiptRequested = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _microsoftGraphOutlookItem .LastModifiedDateTime;
            }
            set
            {
                _microsoftGraphOutlookItem .LastModifiedDateTime = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .MultiValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .MultiValueExtendedProperties = value;
            }
        }
        public string NameEmailAddressName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .NameEmailAddressName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .NameEmailAddressName = value;
            }
        }
        public string ParentFolderId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .ParentFolderId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .ParentFolderId = value;
            }
        }
        public System.DateTime? ReceivedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .ReceivedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .ReceivedDateTime = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ReplyTo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .ReplyTo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .ReplyTo = value;
            }
        }
        /// <summary>recipient</summary>
        public Sample.API.Models.IMicrosoftGraphRecipient Sender
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .Sender;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .Sender = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress SenderEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .SenderEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .SenderEmailAddress = value;
            }
        }
        public System.DateTime? SentDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .SentDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .SentDateTime = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .SingleValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .SingleValueExtendedProperties = value;
            }
        }
        public string StartDateTimeDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .StartDateTimeDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .StartDateTimeDateTime = value;
            }
        }
        public string StartDateTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .StartDateTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .StartDateTimeZone = value;
            }
        }
        public string Subject
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .Subject;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .Subject = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ToRecipients
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .ToRecipients;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .ToRecipients = value;
            }
        }
        /// <summary>itemBody</summary>
        public Sample.API.Models.IMicrosoftGraphItemBody UniqueBody
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .UniqueBody;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .UniqueBody = value;
            }
        }
        public string UniqueBodyContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .UniqueBodyContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .UniqueBodyContent = value;
            }
        }
        /// <summary>bodyType</summary>
        public string UniqueBodyContentType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .UniqueBodyContentType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .UniqueBodyContentType = value;
            }
        }
        public string WebLink
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageAllof1 .WebLink;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageAllof1 .WebLink = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphMessage" /> instance.</summary>
        public MicrosoftGraphMessage()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOutlookItem ), _microsoftGraphOutlookItem );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOutlookItem ), _microsoftGraphOutlookItem );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphMessageAllof1 ), _componentsSchemasMicrosoftGraphMessageAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphMessageAllof1 ), _componentsSchemasMicrosoftGraphMessageAllof1 );
        }
    }
    public partial interface IMicrosoftGraphMessage : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOutlookItem, Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageAllof1 {

    }
}