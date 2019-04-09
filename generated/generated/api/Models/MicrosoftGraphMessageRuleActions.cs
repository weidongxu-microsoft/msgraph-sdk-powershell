namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>messageRuleActions</summary>
    public partial class MicrosoftGraphMessageRuleActions : Sample.API.Models.IMicrosoftGraphMessageRuleActions
    {
        /// <summary>Backing field for <see cref="AssignCategories" /> property.</summary>
        private string[] _assignCategories;

        public string[] AssignCategories
        {
            get
            {
                return this._assignCategories;
            }
            set
            {
                this._assignCategories = value;
            }
        }
        /// <summary>Backing field for <see cref="CopyToFolder" /> property.</summary>
        private string _copyToFolder;

        public string CopyToFolder
        {
            get
            {
                return this._copyToFolder;
            }
            set
            {
                this._copyToFolder = value;
            }
        }
        /// <summary>Backing field for <see cref="Delete" /> property.</summary>
        private bool? _delete;

        public bool? Delete
        {
            get
            {
                return this._delete;
            }
            set
            {
                this._delete = value;
            }
        }
        /// <summary>Backing field for <see cref="ForwardAsAttachmentTo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _forwardAsAttachmentTo;

        public Sample.API.Models.IMicrosoftGraphRecipient[] ForwardAsAttachmentTo
        {
            get
            {
                return this._forwardAsAttachmentTo;
            }
            set
            {
                this._forwardAsAttachmentTo = value;
            }
        }
        /// <summary>Backing field for <see cref="ForwardTo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _forwardTo;

        public Sample.API.Models.IMicrosoftGraphRecipient[] ForwardTo
        {
            get
            {
                return this._forwardTo;
            }
            set
            {
                this._forwardTo = value;
            }
        }
        /// <summary>Backing field for <see cref="MarkAsRead" /> property.</summary>
        private bool? _markAsRead;

        public bool? MarkAsRead
        {
            get
            {
                return this._markAsRead;
            }
            set
            {
                this._markAsRead = value;
            }
        }
        /// <summary>Backing field for <see cref="MarkImportance" /> property.</summary>
        private string _markImportance;

        /// <summary>importance</summary>
        public string MarkImportance
        {
            get
            {
                return this._markImportance;
            }
            set
            {
                this._markImportance = value;
            }
        }
        /// <summary>Backing field for <see cref="MoveToFolder" /> property.</summary>
        private string _moveToFolder;

        public string MoveToFolder
        {
            get
            {
                return this._moveToFolder;
            }
            set
            {
                this._moveToFolder = value;
            }
        }
        /// <summary>Backing field for <see cref="PermanentDelete" /> property.</summary>
        private bool? _permanentDelete;

        public bool? PermanentDelete
        {
            get
            {
                return this._permanentDelete;
            }
            set
            {
                this._permanentDelete = value;
            }
        }
        /// <summary>Backing field for <see cref="RedirectTo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient[] _redirectTo;

        public Sample.API.Models.IMicrosoftGraphRecipient[] RedirectTo
        {
            get
            {
                return this._redirectTo;
            }
            set
            {
                this._redirectTo = value;
            }
        }
        /// <summary>Backing field for <see cref="StopProcessingRules" /> property.</summary>
        private bool? _stopProcessingRules;

        public bool? StopProcessingRules
        {
            get
            {
                return this._stopProcessingRules;
            }
            set
            {
                this._stopProcessingRules = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphMessageRuleActions" /> instance.</summary>
        public MicrosoftGraphMessageRuleActions()
        {
        }
    }
    /// messageRuleActions
    public partial interface IMicrosoftGraphMessageRuleActions : Sample.API.Runtime.IJsonSerializable {
        string[] AssignCategories { get; set; }
        string CopyToFolder { get; set; }
        bool? Delete { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] ForwardAsAttachmentTo { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] ForwardTo { get; set; }
        bool? MarkAsRead { get; set; }
        string MarkImportance { get; set; }
        string MoveToFolder { get; set; }
        bool? PermanentDelete { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] RedirectTo { get; set; }
        bool? StopProcessingRules { get; set; }
    }
}