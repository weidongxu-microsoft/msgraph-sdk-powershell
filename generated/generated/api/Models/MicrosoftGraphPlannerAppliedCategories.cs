namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerAppliedCategories</summary>
    public partial class MicrosoftGraphPlannerAppliedCategories : Sample.API.Models.IMicrosoftGraphPlannerAppliedCategories
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerAppliedCategories" /> instance.</summary>
        public MicrosoftGraphPlannerAppliedCategories()
        {
        }
    }
    /// plannerAppliedCategories
    public partial interface IMicrosoftGraphPlannerAppliedCategories : Sample.API.Runtime.IJsonSerializable {

    }
}