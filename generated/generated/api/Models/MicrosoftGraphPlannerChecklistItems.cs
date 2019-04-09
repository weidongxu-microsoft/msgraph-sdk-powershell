namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerChecklistItems</summary>
    public partial class MicrosoftGraphPlannerChecklistItems : Sample.API.Models.IMicrosoftGraphPlannerChecklistItems
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerChecklistItems" /> instance.</summary>
        public MicrosoftGraphPlannerChecklistItems()
        {
        }
    }
    /// plannerChecklistItems
    public partial interface IMicrosoftGraphPlannerChecklistItems : Sample.API.Runtime.IJsonSerializable {

    }
}