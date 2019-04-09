namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerOrderHintsByAssignee</summary>
    public partial class MicrosoftGraphPlannerOrderHintsByAssignee : Sample.API.Models.IMicrosoftGraphPlannerOrderHintsByAssignee
    {

        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphPlannerOrderHintsByAssignee" /> instance.
        /// </summary>
        public MicrosoftGraphPlannerOrderHintsByAssignee()
        {
        }
    }
    /// plannerOrderHintsByAssignee
    public partial interface IMicrosoftGraphPlannerOrderHintsByAssignee : Sample.API.Runtime.IJsonSerializable {

    }
}