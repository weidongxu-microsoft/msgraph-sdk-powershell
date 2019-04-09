namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>message</summary>
    public partial class ComponentsSchemasMicrosoftGraphMessageAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageAllof1
    {
        public string AddressEmailAddressAddressEmailAddress
        {
            get
            {
                return /*1*/Sender/*4*/.AddressEmailAddress/*3*/;
            }
            set
            {
                /*1*/Sender/*4*/.AddressEmailAddress/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Attachments" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphAttachment[] _attachments;

        public Sample.API.Models.IMicrosoftGraphAttachment[] Attachments
        {
            get
            {
                return this._attachments;
            }
            set
            {
                this._attachments = value;
            }
        }
        /// <summary>Backing field for <see cref="BccRecipients" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _bccRecipients;

        public Sample.API.Models.IMicrosoftGraphRecipient[] BccRecipients
        {
            get
            {
                return this._bccRecipients;
            }
            set
            {
                this._bccRecipients = value;
            }
        }
        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphItemBody _body;

        /// <summary>itemBody</summary>
        public Sample.API.Models.IMicrosoftGraphItemBody Body
        {
            get
            {
                return this._body;
            }
            set
            {
                this._body = value;
            }
        }
        public string BodyContent
        {
            get
            {
                return /*1*/Body/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/Body/*4*/.Content/*3*/ = value;
            }
        }
        /// <summary>bodyType</summary>
        public string BodyContentType
        {
            get
            {
                return /*1*/Body/*4*/.ContentType/*3*/;
            }
            set
            {
                /*1*/Body/*4*/.ContentType/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="BodyPreview" /> property.</summary>
        private string _bodyPreview;

        public string BodyPreview
        {
            get
            {
                return this._bodyPreview;
            }
            set
            {
                this._bodyPreview = value;
            }
        }
        /// <summary>Backing field for <see cref="CcRecipients" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _ccRecipients;

        public Sample.API.Models.IMicrosoftGraphRecipient[] CcRecipients
        {
            get
            {
                return this._ccRecipients;
            }
            set
            {
                this._ccRecipients = value;
            }
        }
        public string CompletedDateTimeDateTime
        {
            get
            {
                return /*1*/Flag/*4*/.CompletedDateTimeDateTime/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.CompletedDateTimeDateTime/*3*/ = value;
            }
        }
        public string CompletedDateTimeZone
        {
            get
            {
                return /*1*/Flag/*4*/.CompletedDateTimeZone/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.CompletedDateTimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ConversationId" /> property.</summary>
        private string _conversationId;

        public string ConversationId
        {
            get
            {
                return this._conversationId;
            }
            set
            {
                this._conversationId = value;
            }
        }
        public string DueDateTimeDateTime
        {
            get
            {
                return /*1*/Flag/*4*/.DueDateTimeDateTime/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.DueDateTimeDateTime/*3*/ = value;
            }
        }
        public string DueDateTimeZone
        {
            get
            {
                return /*1*/Flag/*4*/.DueDateTimeZone/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.DueDateTimeZone/*3*/ = value;
            }
        }
        public string EmailAddressAddressEmailAddress
        {
            get
            {
                return /*1*/From/*4*/.AddressEmailAddress/*3*/;
            }
            set
            {
                /*1*/From/*4*/.AddressEmailAddress/*3*/ = value;
            }
        }
        public string EmailAddressNameEmailAddressName
        {
            get
            {
                return /*1*/Sender/*4*/.EmailAddressName/*3*/;
            }
            set
            {
                /*1*/Sender/*4*/.EmailAddressName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Extensions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphExtension[] _extensions;

        public Sample.API.Models.IMicrosoftGraphExtension[] Extensions
        {
            get
            {
                return this._extensions;
            }
            set
            {
                this._extensions = value;
            }
        }
        /// <summary>Backing field for <see cref="Flag" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphFollowupFlag _flag;

        /// <summary>followupFlag</summary>
        public Sample.API.Models.IMicrosoftGraphFollowupFlag Flag
        {
            get
            {
                return this._flag;
            }
            set
            {
                this._flag = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone FlagCompletedDateTime
        {
            get
            {
                return /*1*/Flag/*4*/.CompletedDateTime/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.CompletedDateTime/*3*/ = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone FlagDueDateTime
        {
            get
            {
                return /*1*/Flag/*4*/.DueDateTime/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.DueDateTime/*3*/ = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone FlagStartDateTime
        {
            get
            {
                return /*1*/Flag/*4*/.StartDateTime/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.StartDateTime/*3*/ = value;
            }
        }
        /// <summary>followupFlagStatus</summary>
        public string FlagStatus
        {
            get
            {
                return /*1*/Flag/*4*/.FlagStatus/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.FlagStatus/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="From" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient _from;

        /// <summary>recipient</summary>
        public Sample.API.Models.IMicrosoftGraphRecipient From
        {
            get
            {
                return this._from;
            }
            set
            {
                this._from = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress FromEmailAddress
        {
            get
            {
                return /*1*/From/*4*/.EmailAddress/*3*/;
            }
            set
            {
                /*1*/From/*4*/.EmailAddress/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="HasAttachments" /> property.</summary>
        private bool? _hasAttachments;

        public bool? HasAttachments
        {
            get
            {
                return this._hasAttachments;
            }
            set
            {
                this._hasAttachments = value;
            }
        }
        /// <summary>Backing field for <see cref="Importance" /> property.</summary>
        private string _importance;

        /// <summary>importance</summary>
        public string Importance
        {
            get
            {
                return this._importance;
            }
            set
            {
                this._importance = value;
            }
        }
        /// <summary>Backing field for <see cref="InferenceClassification" /> property.</summary>
        private string _inferenceClassification;

        /// <summary>inferenceClassificationType</summary>
        public string InferenceClassification
        {
            get
            {
                return this._inferenceClassification;
            }
            set
            {
                this._inferenceClassification = value;
            }
        }
        /// <summary>Backing field for <see cref="InternetMessageHeaders" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphInternetMessageHeader[] _internetMessageHeaders;

        public Sample.API.Models.IMicrosoftGraphInternetMessageHeader[] InternetMessageHeaders
        {
            get
            {
                return this._internetMessageHeaders;
            }
            set
            {
                this._internetMessageHeaders = value;
            }
        }
        /// <summary>Backing field for <see cref="InternetMessageId" /> property.</summary>
        private string _internetMessageId;

        public string InternetMessageId
        {
            get
            {
                return this._internetMessageId;
            }
            set
            {
                this._internetMessageId = value;
            }
        }
        /// <summary>Backing field for <see cref="IsDeliveryReceiptRequested" /> property.</summary>
        private bool? _isDeliveryReceiptRequested;

        public bool? IsDeliveryReceiptRequested
        {
            get
            {
                return this._isDeliveryReceiptRequested;
            }
            set
            {
                this._isDeliveryReceiptRequested = value;
            }
        }
        /// <summary>Backing field for <see cref="IsDraft" /> property.</summary>
        private bool? _isDraft;

        public bool? IsDraft
        {
            get
            {
                return this._isDraft;
            }
            set
            {
                this._isDraft = value;
            }
        }
        /// <summary>Backing field for <see cref="IsRead" /> property.</summary>
        private bool? _isRead;

        public bool? IsRead
        {
            get
            {
                return this._isRead;
            }
            set
            {
                this._isRead = value;
            }
        }
        /// <summary>Backing field for <see cref="IsReadReceiptRequested" /> property.</summary>
        private bool? _isReadReceiptRequested;

        public bool? IsReadReceiptRequested
        {
            get
            {
                return this._isReadReceiptRequested;
            }
            set
            {
                this._isReadReceiptRequested = value;
            }
        }
        /// <summary>Backing field for <see cref="MultiValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] _multiValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return this._multiValueExtendedProperties;
            }
            set
            {
                this._multiValueExtendedProperties = value;
            }
        }
        public string NameEmailAddressName
        {
            get
            {
                return /*1*/From/*4*/.EmailAddressName/*3*/;
            }
            set
            {
                /*1*/From/*4*/.EmailAddressName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentFolderId" /> property.</summary>
        private string _parentFolderId;

        public string ParentFolderId
        {
            get
            {
                return this._parentFolderId;
            }
            set
            {
                this._parentFolderId = value;
            }
        }
        /// <summary>Backing field for <see cref="ReceivedDateTime" /> property.</summary>
        private System.DateTime? _receivedDateTime;

        public System.DateTime? ReceivedDateTime
        {
            get
            {
                return this._receivedDateTime;
            }
            set
            {
                this._receivedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="ReplyTo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _replyTo;

        public Sample.API.Models.IMicrosoftGraphRecipient[] ReplyTo
        {
            get
            {
                return this._replyTo;
            }
            set
            {
                this._replyTo = value;
            }
        }
        /// <summary>Backing field for <see cref="Sender" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient _sender;

        /// <summary>recipient</summary>
        public Sample.API.Models.IMicrosoftGraphRecipient Sender
        {
            get
            {
                return this._sender;
            }
            set
            {
                this._sender = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress SenderEmailAddress
        {
            get
            {
                return /*1*/Sender/*4*/.EmailAddress/*3*/;
            }
            set
            {
                /*1*/Sender/*4*/.EmailAddress/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SentDateTime" /> property.</summary>
        private System.DateTime? _sentDateTime;

        public System.DateTime? SentDateTime
        {
            get
            {
                return this._sentDateTime;
            }
            set
            {
                this._sentDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="SingleValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] _singleValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return this._singleValueExtendedProperties;
            }
            set
            {
                this._singleValueExtendedProperties = value;
            }
        }
        public string StartDateTimeDateTime
        {
            get
            {
                return /*1*/Flag/*4*/.StartDateTimeDateTime/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.StartDateTimeDateTime/*3*/ = value;
            }
        }
        public string StartDateTimeZone
        {
            get
            {
                return /*1*/Flag/*4*/.StartDateTimeZone/*3*/;
            }
            set
            {
                /*1*/Flag/*4*/.StartDateTimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        public string Subject
        {
            get
            {
                return this._subject;
            }
            set
            {
                this._subject = value;
            }
        }
        /// <summary>Backing field for <see cref="ToRecipients" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _toRecipients;

        public Sample.API.Models.IMicrosoftGraphRecipient[] ToRecipients
        {
            get
            {
                return this._toRecipients;
            }
            set
            {
                this._toRecipients = value;
            }
        }
        /// <summary>Backing field for <see cref="UniqueBody" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphItemBody _uniqueBody;

        /// <summary>itemBody</summary>
        public Sample.API.Models.IMicrosoftGraphItemBody UniqueBody
        {
            get
            {
                return this._uniqueBody;
            }
            set
            {
                this._uniqueBody = value;
            }
        }
        public string UniqueBodyContent
        {
            get
            {
                return /*1*/UniqueBody/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/UniqueBody/*4*/.Content/*3*/ = value;
            }
        }
        /// <summary>bodyType</summary>
        public string UniqueBodyContentType
        {
            get
            {
                return /*1*/UniqueBody/*4*/.ContentType/*3*/;
            }
            set
            {
                /*1*/UniqueBody/*4*/.ContentType/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="WebLink" /> property.</summary>
        private string _webLink;

        public string WebLink
        {
            get
            {
                return this._webLink;
            }
            set
            {
                this._webLink = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphMessageAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphMessageAllof1()
        {
        }
    }
    /// message
    public partial interface IComponentsSchemasMicrosoftGraphMessageAllof1 : Sample.API.Runtime.IJsonSerializable {
        string AddressEmailAddressAddressEmailAddress { get; set; }
        Sample.API.Models.IMicrosoftGraphAttachment[] Attachments { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] BccRecipients { get; set; }
        Sample.API.Models.IMicrosoftGraphItemBody Body { get; set; }
        string BodyContent { get; set; }
        string BodyContentType { get; set; }
        string BodyPreview { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] CcRecipients { get; set; }
        string CompletedDateTimeDateTime { get; set; }
        string CompletedDateTimeZone { get; set; }
        string ConversationId { get; set; }
        string DueDateTimeDateTime { get; set; }
        string DueDateTimeZone { get; set; }
        string EmailAddressAddressEmailAddress { get; set; }
        string EmailAddressNameEmailAddressName { get; set; }
        Sample.API.Models.IMicrosoftGraphExtension[] Extensions { get; set; }
        Sample.API.Models.IMicrosoftGraphFollowupFlag Flag { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone FlagCompletedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone FlagDueDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone FlagStartDateTime { get; set; }
        string FlagStatus { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient From { get; set; }
        Sample.API.Models.IMicrosoftGraphEmailAddress FromEmailAddress { get; set; }
        bool? HasAttachments { get; set; }
        string Importance { get; set; }
        string InferenceClassification { get; set; }
        Sample.API.Models.IMicrosoftGraphInternetMessageHeader[] InternetMessageHeaders { get; set; }
        string InternetMessageId { get; set; }
        bool? IsDeliveryReceiptRequested { get; set; }
        bool? IsDraft { get; set; }
        bool? IsRead { get; set; }
        bool? IsReadReceiptRequested { get; set; }
        Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties { get; set; }
        string NameEmailAddressName { get; set; }
        string ParentFolderId { get; set; }
        System.DateTime? ReceivedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] ReplyTo { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient Sender { get; set; }
        Sample.API.Models.IMicrosoftGraphEmailAddress SenderEmailAddress { get; set; }
        System.DateTime? SentDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties { get; set; }
        string StartDateTimeDateTime { get; set; }
        string StartDateTimeZone { get; set; }
        string Subject { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] ToRecipients { get; set; }
        Sample.API.Models.IMicrosoftGraphItemBody UniqueBody { get; set; }
        string UniqueBodyContent { get; set; }
        string UniqueBodyContentType { get; set; }
        string WebLink { get; set; }
    }
}