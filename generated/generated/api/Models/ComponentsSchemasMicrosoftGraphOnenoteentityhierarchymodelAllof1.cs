namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenoteEntityHierarchyModel</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1
    {
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _createdBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return this._createdBy;
            }
            set
            {
                this._createdBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return /*1*/CreatedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return /*1*/CreatedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser
        {
            get
            {
                return /*1*/CreatedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.User/*3*/ = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.DeviceId/*3*/ = value;
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
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _lastModifiedBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return this._lastModifiedBy;
            }
            set
            {
                this._lastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.User/*3*/ = value;
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
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1()
        {
        }
    }
    /// onenoteEntityHierarchyModel
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayNameApplicationDisplayName { get; set; }
        string ApplicationIdApplicationId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser { get; set; }
        string DeviceDisplayNameDeviceDisplayName { get; set; }
        string DeviceIdDeviceId { get; set; }
        string DisplayName { get; set; }
        string DisplayNameApplicationDisplayName { get; set; }
        string DisplayNameDeviceDisplayName { get; set; }
        string DisplayNameUserDisplayName { get; set; }
        string IdApplicationId { get; set; }
        string IdDeviceId { get; set; }
        string IdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        string UserDisplayNameUserDisplayName { get; set; }
        string UserIdUserId { get; set; }
    }
}