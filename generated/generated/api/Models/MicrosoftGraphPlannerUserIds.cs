namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerUserIds</summary>
    public partial class MicrosoftGraphPlannerUserIds : Sample.API.Models.IMicrosoftGraphPlannerUserIds
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerUserIds" /> instance.</summary>
        public MicrosoftGraphPlannerUserIds()
        {
        }
    }
    /// plannerUserIds
    public partial interface IMicrosoftGraphPlannerUserIds : Sample.API.Runtime.IJsonSerializable {

    }
}