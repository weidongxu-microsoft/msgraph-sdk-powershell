namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerAssignments</summary>
    public partial class MicrosoftGraphPlannerAssignments : Sample.API.Models.IMicrosoftGraphPlannerAssignments
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerAssignments" /> instance.</summary>
        public MicrosoftGraphPlannerAssignments()
        {
        }
    }
    /// plannerAssignments
    public partial interface IMicrosoftGraphPlannerAssignments : Sample.API.Runtime.IJsonSerializable {

    }
}