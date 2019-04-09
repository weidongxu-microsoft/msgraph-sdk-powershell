namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>baseItemVersion</summary>
    public partial class ComponentsSchemasMicrosoftGraphBaseitemversionAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphBaseitemversionAllof1
    {
        public string ApplicationDisplayName
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
        public string ApplicationId
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
        public string DeviceDisplayName
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
        public string DeviceId
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
        /// <summary>Backing field for <see cref="Publication" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPublicationFacet _publication;

        /// <summary>publicationFacet</summary>
        public Sample.API.Models.IMicrosoftGraphPublicationFacet Publication
        {
            get
            {
                return this._publication;
            }
            set
            {
                this._publication = value;
            }
        }
        public string PublicationLevel
        {
            get
            {
                return /*1*/Publication/*4*/.Level/*3*/;
            }
            set
            {
                /*1*/Publication/*4*/.Level/*3*/ = value;
            }
        }
        public string PublicationVersionId
        {
            get
            {
                return /*1*/Publication/*4*/.VersionId/*3*/;
            }
            set
            {
                /*1*/Publication/*4*/.VersionId/*3*/ = value;
            }
        }
        public string UserDisplayName
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
        public string UserId
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphBaseitemversionAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphBaseitemversionAllof1()
        {
        }
    }
    /// baseItemVersion
    public partial interface IComponentsSchemasMicrosoftGraphBaseitemversionAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayName { get; set; }
        string ApplicationId { get; set; }
        string DeviceDisplayName { get; set; }
        string DeviceId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphPublicationFacet Publication { get; set; }
        string PublicationLevel { get; set; }
        string PublicationVersionId { get; set; }
        string UserDisplayName { get; set; }
        string UserId { get; set; }
    }
}