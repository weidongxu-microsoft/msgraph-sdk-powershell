namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>messageRule</summary>
    public partial class ComponentsSchemasMicrosoftGraphMessageruleAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageruleAllof1
    {
        /// <summary>Backing field for <see cref="Actions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMessageRuleActions _actions;

        /// <summary>messageRuleActions</summary>
        public Sample.API.Models.IMicrosoftGraphMessageRuleActions Actions
        {
            get
            {
                return this._actions;
            }
            set
            {
                this._actions = value;
            }
        }
        public string[] ActionsAssignCategories
        {
            get
            {
                return /*1*/Actions/*4*/.AssignCategories/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.AssignCategories/*3*/ = value;
            }
        }
        public string ActionsCopyToFolder
        {
            get
            {
                return /*1*/Actions/*4*/.CopyToFolder/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.CopyToFolder/*3*/ = value;
            }
        }
        public bool? ActionsDelete
        {
            get
            {
                return /*1*/Actions/*4*/.Delete/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.Delete/*3*/ = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ActionsForwardAsAttachmentTo
        {
            get
            {
                return /*1*/Actions/*4*/.ForwardAsAttachmentTo/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.ForwardAsAttachmentTo/*3*/ = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ActionsForwardTo
        {
            get
            {
                return /*1*/Actions/*4*/.ForwardTo/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.ForwardTo/*3*/ = value;
            }
        }
        public bool? ActionsMarkAsRead
        {
            get
            {
                return /*1*/Actions/*4*/.MarkAsRead/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.MarkAsRead/*3*/ = value;
            }
        }
        /// <summary>importance</summary>
        public string ActionsMarkImportance
        {
            get
            {
                return /*1*/Actions/*4*/.MarkImportance/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.MarkImportance/*3*/ = value;
            }
        }
        public string ActionsMoveToFolder
        {
            get
            {
                return /*1*/Actions/*4*/.MoveToFolder/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.MoveToFolder/*3*/ = value;
            }
        }
        public bool? ActionsPermanentDelete
        {
            get
            {
                return /*1*/Actions/*4*/.PermanentDelete/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.PermanentDelete/*3*/ = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ActionsRedirectTo
        {
            get
            {
                return /*1*/Actions/*4*/.RedirectTo/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.RedirectTo/*3*/ = value;
            }
        }
        public bool? ActionsStopProcessingRules
        {
            get
            {
                return /*1*/Actions/*4*/.StopProcessingRules/*3*/;
            }
            set
            {
                /*1*/Actions/*4*/.StopProcessingRules/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Conditions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMessageRulePredicates _conditions;

        /// <summary>messageRulePredicates</summary>
        public Sample.API.Models.IMicrosoftGraphMessageRulePredicates Conditions
        {
            get
            {
                return this._conditions;
            }
            set
            {
                this._conditions = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="Exceptions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMessageRulePredicates _exceptions;

        /// <summary>messageRulePredicates</summary>
        public Sample.API.Models.IMicrosoftGraphMessageRulePredicates Exceptions
        {
            get
            {
                return this._exceptions;
            }
            set
            {
                this._exceptions = value;
            }
        }
        /// <summary>Backing field for <see cref="HasError" /> property.</summary>
        private bool? _hasError;

        public bool? HasError
        {
            get
            {
                return this._hasError;
            }
            set
            {
                this._hasError = value;
            }
        }
        /// <summary>Backing field for <see cref="IsEnabled" /> property.</summary>
        private bool? _isEnabled;

        public bool? IsEnabled
        {
            get
            {
                return this._isEnabled;
            }
            set
            {
                this._isEnabled = value;
            }
        }
        /// <summary>Backing field for <see cref="IsReadOnly" /> property.</summary>
        private bool? _isReadOnly;

        public bool? IsReadOnly
        {
            get
            {
                return this._isReadOnly;
            }
            set
            {
                this._isReadOnly = value;
            }
        }
        /// <summary>Backing field for <see cref="Sequence" /> property.</summary>
        private int? _sequence;

        public int? Sequence
        {
            get
            {
                return this._sequence;
            }
            set
            {
                this._sequence = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphMessageruleAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphMessageruleAllof1()
        {
        }
    }
    /// messageRule
    public partial interface IComponentsSchemasMicrosoftGraphMessageruleAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphMessageRuleActions Actions { get; set; }
        string[] ActionsAssignCategories { get; set; }
        string ActionsCopyToFolder { get; set; }
        bool? ActionsDelete { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] ActionsForwardAsAttachmentTo { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] ActionsForwardTo { get; set; }
        bool? ActionsMarkAsRead { get; set; }
        string ActionsMarkImportance { get; set; }
        string ActionsMoveToFolder { get; set; }
        bool? ActionsPermanentDelete { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient[] ActionsRedirectTo { get; set; }
        bool? ActionsStopProcessingRules { get; set; }
        Sample.API.Models.IMicrosoftGraphMessageRulePredicates Conditions { get; set; }
        string DisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphMessageRulePredicates Exceptions { get; set; }
        bool? HasError { get; set; }
        bool? IsEnabled { get; set; }
        bool? IsReadOnly { get; set; }
        int? Sequence { get; set; }
    }
}