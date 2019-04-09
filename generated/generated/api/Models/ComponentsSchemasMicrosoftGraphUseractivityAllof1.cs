namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>userActivity</summary>
    public partial class ComponentsSchemasMicrosoftGraphUseractivityAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphUseractivityAllof1
    {
        /// <summary>Backing field for <see cref="ActivationUrl" /> property.</summary>
        private string _activationUrl;

        public string ActivationUrl
        {
            get
            {
                return this._activationUrl;
            }
            set
            {
                this._activationUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="ActivitySourceHost" /> property.</summary>
        private string _activitySourceHost;

        public string ActivitySourceHost
        {
            get
            {
                return this._activitySourceHost;
            }
            set
            {
                this._activitySourceHost = value;
            }
        }
        /// <summary>Backing field for <see cref="AppActivityId" /> property.</summary>
        private string _appActivityId;

        public string AppActivityId
        {
            get
            {
                return this._appActivityId;
            }
            set
            {
                this._appActivityId = value;
            }
        }
        /// <summary>Backing field for <see cref="AppDisplayName" /> property.</summary>
        private string _appDisplayName;

        public string AppDisplayName
        {
            get
            {
                return this._appDisplayName;
            }
            set
            {
                this._appDisplayName = value;
            }
        }
        public bool? AttributionAddImageQuery
        {
            get
            {
                return /*1*/VisualElements/*4*/.AttributionAddImageQuery/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.AttributionAddImageQuery/*3*/ = value;
            }
        }
        public string AttributionAlternateText
        {
            get
            {
                return /*1*/VisualElements/*4*/.AttributionAlternateText/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.AttributionAlternateText/*3*/ = value;
            }
        }
        public string AttributionAlternativeText
        {
            get
            {
                return /*1*/VisualElements/*4*/.AttributionAlternativeText/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.AttributionAlternativeText/*3*/ = value;
            }
        }
        public string AttributionIconUrl
        {
            get
            {
                return /*1*/VisualElements/*4*/.AttributionIconUrl/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.AttributionIconUrl/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ContentInfo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _contentInfo;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson ContentInfo
        {
            get
            {
                return this._contentInfo;
            }
            set
            {
                this._contentInfo = value;
            }
        }
        /// <summary>Backing field for <see cref="ContentUrl" /> property.</summary>
        private string _contentUrl;

        public string ContentUrl
        {
            get
            {
                return this._contentUrl;
            }
            set
            {
                this._contentUrl = value;
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
        /// <summary>Backing field for <see cref="FallbackUrl" /> property.</summary>
        private string _fallbackUrl;

        public string FallbackUrl
        {
            get
            {
                return this._fallbackUrl;
            }
            set
            {
                this._fallbackUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="HistoryItems" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphActivityHistoryItem[] _historyItems;

        public Sample.API.Models.IMicrosoftGraphActivityHistoryItem[] HistoryItems
        {
            get
            {
                return this._historyItems;
            }
            set
            {
                this._historyItems = value;
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
        /// <summary>Backing field for <see cref="VisualElements" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphVisualInfo _visualElements;

        /// <summary>visualInfo</summary>
        public Sample.API.Models.IMicrosoftGraphVisualInfo VisualElements
        {
            get
            {
                return this._visualElements;
            }
            set
            {
                this._visualElements = value;
            }
        }
        /// <summary>imageInfo</summary>
        public Sample.API.Models.IMicrosoftGraphImageInfo VisualElementsAttribution
        {
            get
            {
                return /*1*/VisualElements/*4*/.Attribution/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.Attribution/*3*/ = value;
            }
        }
        public string VisualElementsBackgroundColor
        {
            get
            {
                return /*1*/VisualElements/*4*/.BackgroundColor/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.BackgroundColor/*3*/ = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson VisualElementsContent
        {
            get
            {
                return /*1*/VisualElements/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.Content/*3*/ = value;
            }
        }
        public string VisualElementsDescription
        {
            get
            {
                return /*1*/VisualElements/*4*/.Description/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.Description/*3*/ = value;
            }
        }
        public string VisualElementsDisplayText
        {
            get
            {
                return /*1*/VisualElements/*4*/.DisplayText/*3*/;
            }
            set
            {
                /*1*/VisualElements/*4*/.DisplayText/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphUseractivityAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphUseractivityAllof1()
        {
        }
    }
    /// userActivity
    public partial interface IComponentsSchemasMicrosoftGraphUseractivityAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ActivationUrl { get; set; }
        string ActivitySourceHost { get; set; }
        string AppActivityId { get; set; }
        string AppDisplayName { get; set; }
        bool? AttributionAddImageQuery { get; set; }
        string AttributionAlternateText { get; set; }
        string AttributionAlternativeText { get; set; }
        string AttributionIconUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphJson ContentInfo { get; set; }
        string ContentUrl { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        System.DateTime? ExpirationDateTime { get; set; }
        string FallbackUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphActivityHistoryItem[] HistoryItems { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        string Status { get; set; }
        string UserTimezone { get; set; }
        Sample.API.Models.IMicrosoftGraphVisualInfo VisualElements { get; set; }
        Sample.API.Models.IMicrosoftGraphImageInfo VisualElementsAttribution { get; set; }
        string VisualElementsBackgroundColor { get; set; }
        Sample.API.Models.IMicrosoftGraphJson VisualElementsContent { get; set; }
        string VisualElementsDescription { get; set; }
        string VisualElementsDisplayText { get; set; }
    }
}