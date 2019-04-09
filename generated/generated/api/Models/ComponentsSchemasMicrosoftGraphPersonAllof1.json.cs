namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>person</summary>
    public partial class ComponentsSchemasMicrosoftGraphPersonAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphPersonAllof1" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphPersonAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_personType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("personType"), out var __jsonPersonType) ? Sample.API.Models.MicrosoftGraphPersonType.FromJson(__jsonPersonType) : PersonType;}
            {_birthday = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("birthday"), out var __jsonBirthday) ? (string)__jsonBirthday : (string)Birthday;}
            {_companyName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("companyName"), out var __jsonCompanyName) ? (string)__jsonCompanyName : (string)CompanyName;}
            {_department = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("department"), out var __jsonDepartment) ? (string)__jsonDepartment : (string)Department;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_givenName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("givenName"), out var __jsonGivenName) ? (string)__jsonGivenName : (string)GivenName;}
            {_imAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("imAddress"), out var __jsonImAddress) ? (string)__jsonImAddress : (string)ImAddress;}
            {_isFavorite = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isFavorite"), out var __jsonIsFavorite) ? (bool?)__jsonIsFavorite : IsFavorite;}
            {_jobTitle = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("jobTitle"), out var __jsonJobTitle) ? (string)__jsonJobTitle : (string)JobTitle;}
            {_officeLocation = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("officeLocation"), out var __jsonOfficeLocation) ? (string)__jsonOfficeLocation : (string)OfficeLocation;}
            {_personNotes = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("personNotes"), out var __jsonPersonNotes) ? (string)__jsonPersonNotes : (string)PersonNotes;}
            {_phones = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("phones"), out var __jsonPhones) ? If( __jsonPhones as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphPhone[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphPhone) (Sample.API.Models.MicrosoftGraphPhone.FromJson(__u) )) ))() : null : Phones;}
            {_postalAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("postalAddresses"), out var __jsonPostalAddresses) ? If( __jsonPostalAddresses as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphLocation[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphLocation) (Sample.API.Models.MicrosoftGraphLocation.FromJson(__p) )) ))() : null : PostalAddresses;}
            {_profession = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("profession"), out var __jsonProfession) ? (string)__jsonProfession : (string)Profession;}
            {_scoredEmailAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("scoredEmailAddresses"), out var __jsonScoredEmailAddresses) ? If( __jsonScoredEmailAddresses as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphScoredEmailAddress[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphScoredEmailAddress) (Sample.API.Models.MicrosoftGraphScoredEmailAddress.FromJson(__k) )) ))() : null : ScoredEmailAddresses;}
            {_surname = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("surname"), out var __jsonSurname) ? (string)__jsonSurname : (string)Surname;}
            {_userPrincipalName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userPrincipalName"), out var __jsonUserPrincipalName) ? (string)__jsonUserPrincipalName : (string)UserPrincipalName;}
            {_websites = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("websites"), out var __jsonWebsites) ? If( __jsonWebsites as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphWebsite[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Sample.API.Models.IMicrosoftGraphWebsite) (Sample.API.Models.MicrosoftGraphWebsite.FromJson(__f) )) ))() : null : Websites;}
            {_yomiCompany = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("yomiCompany"), out var __jsonYomiCompany) ? (string)__jsonYomiCompany : (string)YomiCompany;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPersonAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphPersonAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphPersonAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphPersonAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphPersonAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphPersonAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
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
            AddIf( null != PersonType ? (Sample.API.Runtime.Json.JsonNode) PersonType.ToJson(null,serializationMode) : null, "personType" ,container.Add );
            AddIf( null != (((object)Birthday)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Birthday.ToString()) : null, "birthday" ,container.Add );
            AddIf( null != (((object)CompanyName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CompanyName.ToString()) : null, "companyName" ,container.Add );
            AddIf( null != (((object)Department)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Department.ToString()) : null, "department" ,container.Add );
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)GivenName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(GivenName.ToString()) : null, "givenName" ,container.Add );
            AddIf( null != (((object)ImAddress)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ImAddress.ToString()) : null, "imAddress" ,container.Add );
            AddIf( null != IsFavorite ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsFavorite) : null, "isFavorite" ,container.Add );
            AddIf( null != (((object)JobTitle)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(JobTitle.ToString()) : null, "jobTitle" ,container.Add );
            AddIf( null != (((object)OfficeLocation)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OfficeLocation.ToString()) : null, "officeLocation" ,container.Add );
            AddIf( null != (((object)PersonNotes)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PersonNotes.ToString()) : null, "personNotes" ,container.Add );
            if (null != Phones)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Phones )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("phones",__w);
            }
            if (null != PostalAddresses)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in PostalAddresses )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("postalAddresses",__r);
            }
            AddIf( null != (((object)Profession)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Profession.ToString()) : null, "profession" ,container.Add );
            if (null != ScoredEmailAddresses)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in ScoredEmailAddresses )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("scoredEmailAddresses",__m);
            }
            AddIf( null != (((object)Surname)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Surname.ToString()) : null, "surname" ,container.Add );
            AddIf( null != (((object)UserPrincipalName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserPrincipalName.ToString()) : null, "userPrincipalName" ,container.Add );
            if (null != Websites)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in Websites )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("websites",__h);
            }
            AddIf( null != (((object)YomiCompany)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(YomiCompany.ToString()) : null, "yomiCompany" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}