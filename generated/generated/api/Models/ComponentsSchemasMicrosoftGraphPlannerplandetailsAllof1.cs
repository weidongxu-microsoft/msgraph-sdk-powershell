namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerPlanDetails</summary>
    public partial class ComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1
    {
        /// <summary>Backing field for <see cref="CategoryDescriptions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerCategoryDescriptions _categoryDescriptions;

        /// <summary>plannerCategoryDescriptions</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerCategoryDescriptions CategoryDescriptions
        {
            get
            {
                return this._categoryDescriptions;
            }
            set
            {
                this._categoryDescriptions = value;
            }
        }
        public string CategoryDescriptionsCategory1
        {
            get
            {
                return /*1*/CategoryDescriptions/*4*/.Category1/*3*/;
            }
            set
            {
                /*1*/CategoryDescriptions/*4*/.Category1/*3*/ = value;
            }
        }
        public string CategoryDescriptionsCategory2
        {
            get
            {
                return /*1*/CategoryDescriptions/*4*/.Category2/*3*/;
            }
            set
            {
                /*1*/CategoryDescriptions/*4*/.Category2/*3*/ = value;
            }
        }
        public string CategoryDescriptionsCategory3
        {
            get
            {
                return /*1*/CategoryDescriptions/*4*/.Category3/*3*/;
            }
            set
            {
                /*1*/CategoryDescriptions/*4*/.Category3/*3*/ = value;
            }
        }
        public string CategoryDescriptionsCategory4
        {
            get
            {
                return /*1*/CategoryDescriptions/*4*/.Category4/*3*/;
            }
            set
            {
                /*1*/CategoryDescriptions/*4*/.Category4/*3*/ = value;
            }
        }
        public string CategoryDescriptionsCategory5
        {
            get
            {
                return /*1*/CategoryDescriptions/*4*/.Category5/*3*/;
            }
            set
            {
                /*1*/CategoryDescriptions/*4*/.Category5/*3*/ = value;
            }
        }
        public string CategoryDescriptionsCategory6
        {
            get
            {
                return /*1*/CategoryDescriptions/*4*/.Category6/*3*/;
            }
            set
            {
                /*1*/CategoryDescriptions/*4*/.Category6/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SharedWith" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerUserIds _sharedWith;

        /// <summary>plannerUserIds</summary>
        public Sample.API.Models.IMicrosoftGraphPlannerUserIds SharedWith
        {
            get
            {
                return this._sharedWith;
            }
            set
            {
                this._sharedWith = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1()
        {
        }
    }
    /// plannerPlanDetails
    public partial interface IComponentsSchemasMicrosoftGraphPlannerplandetailsAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphPlannerCategoryDescriptions CategoryDescriptions { get; set; }
        string CategoryDescriptionsCategory1 { get; set; }
        string CategoryDescriptionsCategory2 { get; set; }
        string CategoryDescriptionsCategory3 { get; set; }
        string CategoryDescriptionsCategory4 { get; set; }
        string CategoryDescriptionsCategory5 { get; set; }
        string CategoryDescriptionsCategory6 { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerUserIds SharedWith { get; set; }
    }
}