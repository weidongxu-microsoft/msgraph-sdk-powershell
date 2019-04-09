namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>usedInsight</summary>
    public partial class ComponentsSchemasMicrosoftGraphUsedinsightAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphUsedinsightAllof1
    {
        /// <summary>Backing field for <see cref="LastUsed" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphUsageDetails _lastUsed;

        /// <summary>usageDetails</summary>
        public Sample.API.Models.IMicrosoftGraphUsageDetails LastUsed
        {
            get
            {
                return this._lastUsed;
            }
            set
            {
                this._lastUsed = value;
            }
        }
        public System.DateTime? LastUsedLastAccessedDateTime
        {
            get
            {
                return /*1*/LastUsed/*4*/.LastAccessedDateTime/*3*/;
            }
            set
            {
                /*1*/LastUsed/*4*/.LastAccessedDateTime/*3*/ = value;
            }
        }
        public System.DateTime? LastUsedLastModifiedDateTime
        {
            get
            {
                return /*1*/LastUsed/*4*/.LastModifiedDateTime/*3*/;
            }
            set
            {
                /*1*/LastUsed/*4*/.LastModifiedDateTime/*3*/ = value;
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphUsedinsightAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphUsedinsightAllof1()
        {
        }
    }
    /// usedInsight
    public partial interface IComponentsSchemasMicrosoftGraphUsedinsightAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphUsageDetails LastUsed { get; set; }
        System.DateTime? LastUsedLastAccessedDateTime { get; set; }
        System.DateTime? LastUsedLastModifiedDateTime { get; set; }
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
    }
}