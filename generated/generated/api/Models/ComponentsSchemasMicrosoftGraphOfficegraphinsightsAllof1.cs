namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>officeGraphInsights</summary>
    public partial class ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1
    {
        /// <summary>Backing field for <see cref="Shared" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharedInsight[] _shared;

        public Sample.API.Models.IMicrosoftGraphSharedInsight[] Shared
        {
            get
            {
                return this._shared;
            }
            set
            {
                this._shared = value;
            }
        }
        /// <summary>Backing field for <see cref="Trending" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphTrending[] _trending;

        public Sample.API.Models.IMicrosoftGraphTrending[] Trending
        {
            get
            {
                return this._trending;
            }
            set
            {
                this._trending = value;
            }
        }
        /// <summary>Backing field for <see cref="Used" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphUsedInsight[] _used;

        public Sample.API.Models.IMicrosoftGraphUsedInsight[] Used
        {
            get
            {
                return this._used;
            }
            set
            {
                this._used = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1()
        {
        }
    }
    /// officeGraphInsights
    public partial interface IComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphSharedInsight[] Shared { get; set; }
        Sample.API.Models.IMicrosoftGraphTrending[] Trending { get; set; }
        Sample.API.Models.IMicrosoftGraphUsedInsight[] Used { get; set; }
    }
}