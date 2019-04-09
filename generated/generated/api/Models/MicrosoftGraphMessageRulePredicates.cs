namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>messageRulePredicates</summary>
    public partial class MicrosoftGraphMessageRulePredicates : Sample.API.Models.IMicrosoftGraphMessageRulePredicates
    {
        /// <summary>Backing field for <see cref="BodyContains" /> property.</summary>
        private string[] _bodyContains;

        public string[] BodyContains
        {
            get
            {
                return this._bodyContains;
            }
            set
            {
                this._bodyContains = value;
            }
        }
        /// <summary>Backing field for <see cref="BodyOrSubjectContains" /> property.</summary>
        private string[] _bodyOrSubjectContains;

        public string[] BodyOrSubjectContains
        {
            get
            {
                return this._bodyOrSubjectContains;
            }
            set
            {
                this._bodyOrSubjectContains = value;
            }
        }
        /// <summary>Backing field for <see cref="Categories" /> property.</summary>
        private string[] _categories;

        public string[] Categories
        {
            get
            {
                return this._categories;
            }
            set
            {
                this._categories = value;
            }
        }
        /// <summary>Backing field for <see cref="FromAddresses" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _fromAddresses;

        public Sample.API.Models.IMicrosoftGraphRecipient[] FromAddresses
        {
            get
            {
                return this._fromAddresses;
            }
            set
            {
                this._fromAddresses = value;
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
        /// <summary>Backing field for <see cref="HeaderContains" /> property.</summary>
        private string[] _headerContains;

        public string[] HeaderContains
        {
            get
            {
                return this._headerContains;
            }
            set
            {
                this._headerContains = value;
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
        /// <summary>Backing field for <see cref="IsApprovalRequest" /> property.</summary>
        private bool? _isApprovalRequest;

        public bool? IsApprovalRequest
        {
            get
            {
                return this._isApprovalRequest;
            }
            set
            {
                this._isApprovalRequest = value;
            }
        }
        /// <summary>Backing field for <see cref="IsAutomaticForward" /> property.</summary>
        private bool? _isAutomaticForward;

        public bool? IsAutomaticForward
        {
            get
            {
                return this._isAutomaticForward;
            }
            set
            {
                this._isAutomaticForward = value;
            }
        }
        /// <summary>Backing field for <see cref="IsAutomaticReply" /> property.</summary>
        private bool? _isAutomaticReply;

        public bool? IsAutomaticReply
        {
            get
            {
                return this._isAutomaticReply;
            }
            set
            {
                this._isAutomaticReply = value;
            }
        }
        /// <summary>Backing field for <see cref="IsEncrypted" /> property.</summary>
        private bool? _isEncrypted;

        public bool? IsEncrypted
        {
            get
            {
                return this._isEncrypted;
            }
            set
            {
                this._isEncrypted = value;
            }
        }
        /// <summary>Backing field for <see cref="IsMeetingRequest" /> property.</summary>
        private bool? _isMeetingRequest;

        public bool? IsMeetingRequest
        {
            get
            {
                return this._isMeetingRequest;
            }
            set
            {
                this._isMeetingRequest = value;
            }
        }
        /// <summary>Backing field for <see cref="IsMeetingResponse" /> property.</summary>
        private bool? _isMeetingResponse;

        public bool? IsMeetingResponse
        {
            get
            {
                return this._isMeetingResponse;
            }
            set
            {
                this._isMeetingResponse = value;
            }
        }
        /// <summary>Backing field for <see cref="IsNonDeliveryReport" /> property.</summary>
        private bool? _isNonDeliveryReport;

        public bool? IsNonDeliveryReport
        {
            get
            {
                return this._isNonDeliveryReport;
            }
            set
            {
                this._isNonDeliveryReport = value;
            }
        }
        /// <summary>Backing field for <see cref="IsPermissionControlled" /> property.</summary>
        private bool? _isPermissionControlled;

        public bool? IsPermissionControlled
        {
            get
            {
                return this._isPermissionControlled;
            }
            set
            {
                this._isPermissionControlled = value;
            }
        }
        /// <summary>Backing field for <see cref="IsReadReceipt" /> property.</summary>
        private bool? _isReadReceipt;

        public bool? IsReadReceipt
        {
            get
            {
                return this._isReadReceipt;
            }
            set
            {
                this._isReadReceipt = value;
            }
        }
        /// <summary>Backing field for <see cref="IsSigned" /> property.</summary>
        private bool? _isSigned;

        public bool? IsSigned
        {
            get
            {
                return this._isSigned;
            }
            set
            {
                this._isSigned = value;
            }
        }
        /// <summary>Backing field for <see cref="IsVoicemail" /> property.</summary>
        private bool? _isVoicemail;

        public bool? IsVoicemail
        {
            get
            {
                return this._isVoicemail;
            }
            set
            {
                this._isVoicemail = value;
            }
        }
        /// <summary>Backing field for <see cref="MessageActionFlag" /> property.</summary>
        private string _messageActionFlag;

        /// <summary>messageActionFlag</summary>
        public string MessageActionFlag
        {
            get
            {
                return this._messageActionFlag;
            }
            set
            {
                this._messageActionFlag = value;
            }
        }
        /// <summary>Backing field for <see cref="NotSentToMe" /> property.</summary>
        private bool? _notSentToMe;

        public bool? NotSentToMe
        {
            get
            {
                return this._notSentToMe;
            }
            set
            {
                this._notSentToMe = value;
            }
        }
        /// <summary>Backing field for <see cref="RecipientContains" /> property.</summary>
        private string[] _recipientContains;

        public string[] RecipientContains
        {
            get
            {
                return this._recipientContains;
            }
            set
            {
                this._recipientContains = value;
            }
        }
        /// <summary>Backing field for <see cref="SenderContains" /> property.</summary>
        private string[] _senderContains;

        public string[] SenderContains
        {
            get
            {
                return this._senderContains;
            }
            set
            {
                this._senderContains = value;
            }
        }
        /// <summary>Backing field for <see cref="Sensitivity" /> property.</summary>
        private string _sensitivity;

        /// <summary>sensitivity</summary>
        public string Sensitivity
        {
            get
            {
                return this._sensitivity;
            }
            set
            {
                this._sensitivity = value;
            }
        }
        /// <summary>Backing field for <see cref="SentCcMe" /> property.</summary>
        private bool? _sentCcMe;

        public bool? SentCcMe
        {
            get
            {
                return this._sentCcMe;
            }
            set
            {
                this._sentCcMe = value;
            }
        }
        /// <summary>Backing field for <see cref="SentOnlyToMe" /> property.</summary>
        private bool? _sentOnlyToMe;

        public bool? SentOnlyToMe
        {
            get
            {
                return this._sentOnlyToMe;
            }
            set
            {
                this._sentOnlyToMe = value;
            }
        }
        /// <summary>Backing field for <see cref="SentToAddresses" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _sentToAddresses;

        public Sample.API.Models.IMicrosoftGraphRecipient[] SentToAddresses
        {
            get
            {
                return this._sentToAddresses;
            }
            set
            {
                this._sentToAddresses = value;
            }
        }
        /// <summary>Backing field for <see cref="SentToMe" /> property.</summary>
        private bool? _sentToMe;

        public bool? SentToMe
        {
            get
            {
                return this._sentToMe;
            }
            set
            {
                this._sentToMe = value;
            }
        }
        /// <summary>Backing field for <see cref="SentToOrCcMe" /> property.</summary>
        private bool? _sentToOrCcMe;

        public bool? SentToOrCcMe
        {
            get
            {
                return this._sentToOrCcMe;
            }
            set
            {
                this._sentToOrCcMe = value;
            }
        }
        /// <summary>Backing field for <see cref="SubjectContains" /> property.</summary>
        private string[] _subjectContains;

        public string[] SubjectContains
        {
            get
            {
                return this._subjectContains;
            }
            set
            {
                this._subjectContains = value;
            }
        }
        /// <summary>Backing field for <see cref="WithinSizeRange" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSizeRange _withinSizeRange;

        /// <summary>sizeRange</summary>
        public Sample.API.Models.IMicrosoftGraphSizeRange WithinSizeRange
        {
            get
            {
                return this._withinSizeRange;
            }
            set
            {
                this._withinSizeRange = value;
            }
        }
        public int? WithinSizeRangeMaximumSize
        {
            get
            {
                return /*1*/WithinSizeRange/*4*/.MaximumSize/*3*/;
            }
            set
            {
                /*1*/WithinSizeRange/*4*/.MaximumSize/*3*/ = value;
            }
        }
        public int? WithinSizeRangeMinimumSize
        {
            get
            {
                return /*1*/WithinSizeRange/*4*/.MinimumSize/*3*/;
            }
            set
            {
                /*1*/WithinSizeRange/*4*/.MinimumSize/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphMessageRulePredicates" /> instance.</summary>
        public MicrosoftGraphMessageRulePredicates()
        {
        }
    }
    /// messageRulePredicates
    public partial interface IMicrosoftGraphMessageRulePredicates : Sample.API.Runtime.IJsonSerializable {
        string[] BodyContains { get; set; }
        string[] BodyOrSubjectContains { get; set; }
        string[] Categories { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] FromAddresses { get; set; }
        bool? HasAttachments { get; set; }
        string[] HeaderContains { get; set; }
        string Importance { get; set; }
        bool? IsApprovalRequest { get; set; }
        bool? IsAutomaticForward { get; set; }
        bool? IsAutomaticReply { get; set; }
        bool? IsEncrypted { get; set; }
        bool? IsMeetingRequest { get; set; }
        bool? IsMeetingResponse { get; set; }
        bool? IsNonDeliveryReport { get; set; }
        bool? IsPermissionControlled { get; set; }
        bool? IsReadReceipt { get; set; }
        bool? IsSigned { get; set; }
        bool? IsVoicemail { get; set; }
        string MessageActionFlag { get; set; }
        bool? NotSentToMe { get; set; }
        string[] RecipientContains { get; set; }
        string[] SenderContains { get; set; }
        string Sensitivity { get; set; }
        bool? SentCcMe { get; set; }
        bool? SentOnlyToMe { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] SentToAddresses { get; set; }
        bool? SentToMe { get; set; }
        bool? SentToOrCcMe { get; set; }
        string[] SubjectContains { get; set; }
        Sample.API.Models.IMicrosoftGraphSizeRange WithinSizeRange { get; set; }
        int? WithinSizeRangeMaximumSize { get; set; }
        int? WithinSizeRangeMinimumSize { get; set; }
    }
}