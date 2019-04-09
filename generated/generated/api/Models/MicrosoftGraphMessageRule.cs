namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphMessageRule : Sample.API.Models.IMicrosoftGraphMessageRule, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphMessageRule" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageruleAllof1 _componentsSchemasMicrosoftGraphMessageruleAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphMessageruleAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphMessageRule" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>messageRuleActions</summary>
        public Sample.API.Models.IMicrosoftGraphMessageRuleActions Actions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .Actions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .Actions = value;
            }
        }
        public string[] ActionsAssignCategories
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsAssignCategories;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsAssignCategories = value;
            }
        }
        public string ActionsCopyToFolder
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsCopyToFolder;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsCopyToFolder = value;
            }
        }
        public bool? ActionsDelete
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsDelete;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsDelete = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ActionsForwardAsAttachmentTo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsForwardAsAttachmentTo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsForwardAsAttachmentTo = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ActionsForwardTo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsForwardTo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsForwardTo = value;
            }
        }
        public bool? ActionsMarkAsRead
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsMarkAsRead;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsMarkAsRead = value;
            }
        }
        /// <summary>importance</summary>
        public string ActionsMarkImportance
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsMarkImportance;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsMarkImportance = value;
            }
        }
        public string ActionsMoveToFolder
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsMoveToFolder;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsMoveToFolder = value;
            }
        }
        public bool? ActionsPermanentDelete
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsPermanentDelete;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsPermanentDelete = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphRecipient[] ActionsRedirectTo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsRedirectTo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsRedirectTo = value;
            }
        }
        public bool? ActionsStopProcessingRules
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsStopProcessingRules;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .ActionsStopProcessingRules = value;
            }
        }
        /// <summary>messageRulePredicates</summary>
        public Sample.API.Models.IMicrosoftGraphMessageRulePredicates Conditions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .Conditions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .Conditions = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .DisplayName = value;
            }
        }
        /// <summary>messageRulePredicates</summary>
        public Sample.API.Models.IMicrosoftGraphMessageRulePredicates Exceptions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .Exceptions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .Exceptions = value;
            }
        }
        public bool? HasError
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .HasError;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .HasError = value;
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
        public bool? IsEnabled
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .IsEnabled;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .IsEnabled = value;
            }
        }
        public bool? IsReadOnly
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .IsReadOnly;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .IsReadOnly = value;
            }
        }
        public int? Sequence
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMessageruleAllof1 .Sequence;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMessageruleAllof1 .Sequence = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphMessageRule" /> instance.</summary>
        public MicrosoftGraphMessageRule()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphMessageruleAllof1 ), _componentsSchemasMicrosoftGraphMessageruleAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphMessageruleAllof1 ), _componentsSchemasMicrosoftGraphMessageruleAllof1 );
        }
    }
    public partial interface IMicrosoftGraphMessageRule : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphMessageruleAllof1 {

    }
}