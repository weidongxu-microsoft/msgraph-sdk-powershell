namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharingDetail</summary>
    public partial class MicrosoftGraphSharingDetail : Sample.API.Models.IMicrosoftGraphSharingDetail
    {
        /// <summary>Backing field for <see cref="SharedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphInsightIdentity _sharedBy;

        /// <summary>insightIdentity</summary>
        public Sample.API.Models.IMicrosoftGraphInsightIdentity SharedBy
        {
            get
            {
                return this._sharedBy;
            }
            set
            {
                this._sharedBy = value;
            }
        }
        public string SharedByAddress
        {
            get
            {
                return /*1*/SharedBy/*4*/.Address/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.Address/*3*/ = value;
            }
        }
        public string SharedByDisplayName
        {
            get
            {
                return /*1*/SharedBy/*4*/.DisplayName/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.DisplayName/*3*/ = value;
            }
        }
        public string SharedById
        {
            get
            {
                return /*1*/SharedBy/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/SharedBy/*4*/.Id/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SharedDateTime" /> property.</summary>
        private System.DateTime? _sharedDateTime;

        public System.DateTime? SharedDateTime
        {
            get
            {
                return this._sharedDateTime;
            }
            set
            {
                this._sharedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="SharingReference" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphResourceReference _sharingReference;

        /// <summary>resourceReference</summary>
        public Sample.API.Models.IMicrosoftGraphResourceReference SharingReference
        {
            get
            {
                return this._sharingReference;
            }
            set
            {
                this._sharingReference = value;
            }
        }
        public string SharingReferenceId
        {
            get
            {
                return /*1*/SharingReference/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/SharingReference/*4*/.Id/*3*/ = value;
            }
        }
        public string SharingReferenceType
        {
            get
            {
                return /*1*/SharingReference/*4*/.Type/*3*/;
            }
            set
            {
                /*1*/SharingReference/*4*/.Type/*3*/ = value;
            }
        }
        public string SharingReferenceWebUrl
        {
            get
            {
                return /*1*/SharingReference/*4*/.WebUrl/*3*/;
            }
            set
            {
                /*1*/SharingReference/*4*/.WebUrl/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SharingSubject" /> property.</summary>
        private string _sharingSubject;

        public string SharingSubject
        {
            get
            {
                return this._sharingSubject;
            }
            set
            {
                this._sharingSubject = value;
            }
        }
        /// <summary>Backing field for <see cref="SharingType" /> property.</summary>
        private string _sharingType;

        public string SharingType
        {
            get
            {
                return this._sharingType;
            }
            set
            {
                this._sharingType = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSharingDetail" /> instance.</summary>
        public MicrosoftGraphSharingDetail()
        {
        }
    }
    /// sharingDetail
    public partial interface IMicrosoftGraphSharingDetail : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphInsightIdentity SharedBy { get; set; }
        string SharedByAddress { get; set; }
        string SharedByDisplayName { get; set; }
        string SharedById { get; set; }
        System.DateTime? SharedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphResourceReference SharingReference { get; set; }
        string SharingReferenceId { get; set; }
        string SharingReferenceType { get; set; }
        string SharingReferenceWebUrl { get; set; }
        string SharingSubject { get; set; }
        string SharingType { get; set; }
    }
}