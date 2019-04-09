namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sharingInvitation</summary>
    public partial class MicrosoftGraphSharingInvitation
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Sample.API.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Sample.API.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Sample.API.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Sample.API.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Sample.API.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphSharingInvitation.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphSharingInvitation.</returns>
        public static Sample.API.Models.IMicrosoftGraphSharingInvitation FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphSharingInvitation(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphSharingInvitation" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphSharingInvitation(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_invitedBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("invitedBy"), out var __jsonInvitedBy) ? Sample.API.Models.MicrosoftGraphIdentitySet.FromJson(__jsonInvitedBy) : InvitedBy;}
            {_email = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)Email;}
            {_redeemedBy = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("redeemedBy"), out var __jsonRedeemedBy) ? (string)__jsonRedeemedBy : (string)RedeemedBy;}
            {_signInRequired = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("signInRequired"), out var __jsonSignInRequired) ? (bool?)__jsonSignInRequired : SignInRequired;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphSharingInvitation" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphSharingInvitation" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </returns>
        public Sample.API.Runtime.Json.JsonNode ToJson(Sample.API.Runtime.Json.JsonObject container, Sample.API.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Sample.API.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != InvitedBy ? (Sample.API.Runtime.Json.JsonNode) InvitedBy.ToJson(null,serializationMode) : null, "invitedBy" ,container.Add );
            AddIf( null != (((object)Email)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Email.ToString()) : null, "email" ,container.Add );
            AddIf( null != (((object)RedeemedBy)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(RedeemedBy.ToString()) : null, "redeemedBy" ,container.Add );
            AddIf( null != SignInRequired ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)SignInRequired) : null, "signInRequired" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}