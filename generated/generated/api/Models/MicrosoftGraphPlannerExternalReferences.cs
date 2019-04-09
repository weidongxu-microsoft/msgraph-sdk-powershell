namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerExternalReferences</summary>
    public partial class MicrosoftGraphPlannerExternalReferences : Sample.API.Models.IMicrosoftGraphPlannerExternalReferences
    {

        /// <summary>Creates an new <see cref="MicrosoftGraphPlannerExternalReferences" /> instance.</summary>
        public MicrosoftGraphPlannerExternalReferences()
        {
        }
    }
    /// plannerExternalReferences
    public partial interface IMicrosoftGraphPlannerExternalReferences : Sample.API.Runtime.IJsonSerializable {

    }
}