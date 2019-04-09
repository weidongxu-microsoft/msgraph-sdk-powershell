namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharedInsight</summary>
    public partial class ComponentsSchemasMicrosoftGraphSharedinsightAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphSharedinsightAllof1
    {
        /// <summary>Backing field for <see cref="LastShared" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharingDetail _lastShared;

        /// <summary>sharingDetail</summary>
        public Sample.API.Models.IMicrosoftGraphSharingDetail LastShared
        {
            get
            {
                return this._lastShared;
            }
            set
            {
                this._lastShared = value;
            }
        }
        /// <summary>insightIdentity</summary>
        public Sample.API.Models.IMicrosoftGraphInsightIdentity LastSharedBy
        {
            get
            {
                return /*1*/LastShared/*4*/.SharedBy/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharedBy/*3*/ = value;
            }
        }
        public System.DateTime? LastSharedDateTime
        {
            get
            {
                return /*1*/LastShared/*4*/.SharedDateTime/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharedDateTime/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="LastSharedMethod" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEntity _lastSharedMethod;

        /// <summary>entity</summary>
        public Sample.API.Models.IMicrosoftGraphEntity LastSharedMethod
        {
            get
            {
                return this._lastSharedMethod;
            }
            set
            {
                this._lastSharedMethod = value;
            }
        }
        public string LastSharedMethodId
        {
            get
            {
                return /*1*/LastSharedMethod/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/LastSharedMethod/*4*/.Id/*3*/ = value;
            }
        }
        /// <summary>resourceReference</summary>
        public Sample.API.Models.IMicrosoftGraphResourceReference LastSharedSharingReference
        {
            get
            {
                return /*1*/LastShared/*4*/.SharingReference/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharingReference/*3*/ = value;
            }
        }
        public string LastSharedSharingSubject
        {
            get
            {
                return /*1*/LastShared/*4*/.SharingSubject/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharingSubject/*3*/ = value;
            }
        }
        public string LastSharedSharingType
        {
            get
            {
                return /*1*/LastShared/*4*/.SharingType/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharingType/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEntity _resource;

        /// <summary>entity</summary>
        public Sample.API.Models.IMicrosoftGraphEntity Resource
        {
            get
            {
                return this._resource;
            }
            set
            {
                this._resource = value;
            }
        }
        public string ResourceId
        {
            get
            {
                return /*1*/Resource/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/Resource/*4*/.Id/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ResourceReference" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphResourceReference _resourceReference;

        /// <summary>resourceReference</summary>
        public Sample.API.Models.IMicrosoftGraphResourceReference ResourceReference
        {
            get
            {
                return this._resourceReference;
            }
            set
            {
                this._resourceReference = value;
            }
        }
        public string ResourceReferenceId
        {
            get
            {
                return /*1*/ResourceReference/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/ResourceReference/*4*/.Id/*3*/ = value;
            }
        }
        public string ResourceReferenceType
        {
            get
            {
                return /*1*/ResourceReference/*4*/.Type/*3*/;
            }
            set
            {
                /*1*/ResourceReference/*4*/.Type/*3*/ = value;
            }
        }
        public string ResourceReferenceWebUrl
        {
            get
            {
                return /*1*/ResourceReference/*4*/.WebUrl/*3*/;
            }
            set
            {
                /*1*/ResourceReference/*4*/.WebUrl/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ResourceVisualization" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphResourceVisualization _resourceVisualization;

        /// <summary>resourceVisualization</summary>
        public Sample.API.Models.IMicrosoftGraphResourceVisualization ResourceVisualization
        {
            get
            {
                return this._resourceVisualization;
            }
            set
            {
                this._resourceVisualization = value;
            }
        }
        public string ResourceVisualizationContainerDisplayName
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.ContainerDisplayName/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.ContainerDisplayName/*3*/ = value;
            }
        }
        public string ResourceVisualizationContainerType
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.ContainerType/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.ContainerType/*3*/ = value;
            }
        }
        public string ResourceVisualizationContainerWebUrl
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.ContainerWebUrl/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.ContainerWebUrl/*3*/ = value;
            }
        }
        public string ResourceVisualizationMediaType
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.MediaType/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.MediaType/*3*/ = value;
            }
        }
        public string ResourceVisualizationPreviewImageUrl
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.PreviewImageUrl/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.PreviewImageUrl/*3*/ = value;
            }
        }
        public string ResourceVisualizationPreviewText
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.PreviewText/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.PreviewText/*3*/ = value;
            }
        }
        public string ResourceVisualizationTitle
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.Title/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.Title/*3*/ = value;
            }
        }
        public string ResourceVisualizationType
        {
            get
            {
                return /*1*/ResourceVisualization/*4*/.Type/*3*/;
            }
            set
            {
                /*1*/ResourceVisualization/*4*/.Type/*3*/ = value;
            }
        }
        public string SharedByAddress
        {
            get
            {
                return /*1*/LastShared/*4*/.SharedByAddress/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharedByAddress/*3*/ = value;
            }
        }
        public string SharedByDisplayName
        {
            get
            {
                return /*1*/LastShared/*4*/.SharedByDisplayName/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharedByDisplayName/*3*/ = value;
            }
        }
        public string SharedById
        {
            get
            {
                return /*1*/LastShared/*4*/.SharedById/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharedById/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SharingHistory" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharingDetail[] _sharingHistory;

        public Sample.API.Models.IMicrosoftGraphSharingDetail[] SharingHistory
        {
            get
            {
                return this._sharingHistory;
            }
            set
            {
                this._sharingHistory = value;
            }
        }
        public string SharingReferenceId
        {
            get
            {
                return /*1*/LastShared/*4*/.SharingReferenceId/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharingReferenceId/*3*/ = value;
            }
        }
        public string SharingReferenceType
        {
            get
            {
                return /*1*/LastShared/*4*/.SharingReferenceType/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharingReferenceType/*3*/ = value;
            }
        }
        public string SharingReferenceWebUrl
        {
            get
            {
                return /*1*/LastShared/*4*/.SharingReferenceWebUrl/*3*/;
            }
            set
            {
                /*1*/LastShared/*4*/.SharingReferenceWebUrl/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphSharedinsightAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphSharedinsightAllof1()
        {
        }
    }
    /// sharedInsight
    public partial interface IComponentsSchemasMicrosoftGraphSharedinsightAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphSharingDetail LastShared { get; set; }
        Sample.API.Models.IMicrosoftGraphInsightIdentity LastSharedBy { get; set; }
        System.DateTime? LastSharedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphEntity LastSharedMethod { get; set; }
        string LastSharedMethodId { get; set; }
        Sample.API.Models.IMicrosoftGraphResourceReference LastSharedSharingReference { get; set; }
        string LastSharedSharingSubject { get; set; }
        string LastSharedSharingType { get; set; }
        Sample.API.Models.IMicrosoftGraphEntity Resource { get; set; }
        string ResourceId { get; set; }
        Sample.API.Models.IMicrosoftGraphResourceReference ResourceReference { get; set; }
        string ResourceReferenceId { get; set; }
        string ResourceReferenceType { get; set; }
        string ResourceReferenceWebUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphResourceVisualization ResourceVisualization { get; set; }
        string ResourceVisualizationContainerDisplayName { get; set; }
        string ResourceVisualizationContainerType { get; set; }
        string ResourceVisualizationContainerWebUrl { get; set; }
        string ResourceVisualizationMediaType { get; set; }
        string ResourceVisualizationPreviewImageUrl { get; set; }
        string ResourceVisualizationPreviewText { get; set; }
        string ResourceVisualizationTitle { get; set; }
        string ResourceVisualizationType { get; set; }
        string SharedByAddress { get; set; }
        string SharedByDisplayName { get; set; }
        string SharedById { get; set; }
        Sample.API.Models.IMicrosoftGraphSharingDetail[] SharingHistory { get; set; }
        string SharingReferenceId { get; set; }
        string SharingReferenceType { get; set; }
        string SharingReferenceWebUrl { get; set; }
    }
}