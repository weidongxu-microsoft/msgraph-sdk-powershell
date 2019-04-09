namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>contact</summary>
    public partial class ComponentsSchemasMicrosoftGraphContactAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphContactAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphContactAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_businessAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("businessAddress"), out var __jsonBusinessAddress) ? Sample.API.Models.MicrosoftGraphPhysicalAddress.FromJson(__jsonBusinessAddress) : BusinessAddress;}
            {_homeAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("homeAddress"), out var __jsonHomeAddress) ? Sample.API.Models.MicrosoftGraphPhysicalAddress.FromJson(__jsonHomeAddress) : HomeAddress;}
            {_otherAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("otherAddress"), out var __jsonOtherAddress) ? Sample.API.Models.MicrosoftGraphPhysicalAddress.FromJson(__jsonOtherAddress) : OtherAddress;}
            {_assistantName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("assistantName"), out var __jsonAssistantName) ? (string)__jsonAssistantName : (string)AssistantName;}
            {_birthday = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("birthday"), out var __jsonBirthday) ? System.DateTime.TryParse((string)__jsonBirthday, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonBirthdayValue) ? __jsonBirthdayValue : Birthday : Birthday;}
            {_businessHomePage = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("businessHomePage"), out var __jsonBusinessHomePage) ? (string)__jsonBusinessHomePage : (string)BusinessHomePage;}
            {_businessPhones = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("businessPhones"), out var __jsonBusinessPhones) ? If( __jsonBusinessPhones as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Sample.API.Runtime.Json.JsonString __t ? (string)__t : null)) ))() : null : BusinessPhones;}
            {_children = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("children"), out var __jsonChildren) ? If( __jsonChildren as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Sample.API.Runtime.Json.JsonString __o ? (string)__o : null)) ))() : null : Children;}
            {_companyName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("companyName"), out var __jsonCompanyName) ? (string)__jsonCompanyName : (string)CompanyName;}
            {_department = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("department"), out var __jsonDepartment) ? (string)__jsonDepartment : (string)Department;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_emailAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("emailAddresses"), out var __jsonEmailAddresses) ? If( __jsonEmailAddresses as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphEmailAddress[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphEmailAddress) (Sample.API.Models.MicrosoftGraphEmailAddress.FromJson(__k) )) ))() : null : EmailAddresses;}
            {_fileAs = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("fileAs"), out var __jsonFileAs) ? (string)__jsonFileAs : (string)FileAs;}
            {_generation = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("generation"), out var __jsonGeneration) ? (string)__jsonGeneration : (string)Generation;}
            {_givenName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("givenName"), out var __jsonGivenName) ? (string)__jsonGivenName : (string)GivenName;}
            {_homePhones = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("homePhones"), out var __jsonHomePhones) ? If( __jsonHomePhones as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(string) (__f is Sample.API.Runtime.Json.JsonString __e ? (string)__e : null)) ))() : null : HomePhones;}
            {_imAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("imAddresses"), out var __jsonImAddresses) ? If( __jsonImAddresses as Sample.API.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(string) (__a is Sample.API.Runtime.Json.JsonString ___z ? (string)___z : null)) ))() : null : ImAddresses;}
            {_initials = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("initials"), out var __jsonInitials) ? (string)__jsonInitials : (string)Initials;}
            {_jobTitle = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("jobTitle"), out var __jsonJobTitle) ? (string)__jsonJobTitle : (string)JobTitle;}
            {_manager = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("manager"), out var __jsonManager) ? (string)__jsonManager : (string)Manager;}
            {_middleName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("middleName"), out var __jsonMiddleName) ? (string)__jsonMiddleName : (string)MiddleName;}
            {_mobilePhone = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("mobilePhone"), out var __jsonMobilePhone) ? (string)__jsonMobilePhone : (string)MobilePhone;}
            {_multiValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("multiValueExtendedProperties"), out var __jsonMultiValueExtendedProperties) ? If( __jsonMultiValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphMultiValueLegacyExtendedProperty.FromJson(___v) )) ))() : null : MultiValueExtendedProperties;}
            {_nickName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("nickName"), out var __jsonNickName) ? (string)__jsonNickName : (string)NickName;}
            {_officeLocation = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("officeLocation"), out var __jsonOfficeLocation) ? (string)__jsonOfficeLocation : (string)OfficeLocation;}
            {_parentFolderId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("parentFolderId"), out var __jsonParentFolderId) ? (string)__jsonParentFolderId : (string)ParentFolderId;}
            {_personalNotes = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("personalNotes"), out var __jsonPersonalNotes) ? (string)__jsonPersonalNotes : (string)PersonalNotes;}
            {_photo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("photo"), out var __jsonPhoto) ? Sample.API.Models.MicrosoftGraphProfilePhoto.FromJson(__jsonPhoto) : Photo;}
            {_profession = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("profession"), out var __jsonProfession) ? (string)__jsonProfession : (string)Profession;}
            {_singleValueExtendedProperties = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("singleValueExtendedProperties"), out var __jsonSingleValueExtendedProperties) ? If( __jsonSingleValueExtendedProperties as Sample.API.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___r, (___q)=>(Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty) (Sample.API.Models.MicrosoftGraphSingleValueLegacyExtendedProperty.FromJson(___q) )) ))() : null : SingleValueExtendedProperties;}
            {_spouseName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("spouseName"), out var __jsonSpouseName) ? (string)__jsonSpouseName : (string)SpouseName;}
            {_surname = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("surname"), out var __jsonSurname) ? (string)__jsonSurname : (string)Surname;}
            {_title = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            {_yomiCompanyName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("yomiCompanyName"), out var __jsonYomiCompanyName) ? (string)__jsonYomiCompanyName : (string)YomiCompanyName;}
            {_yomiGivenName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("yomiGivenName"), out var __jsonYomiGivenName) ? (string)__jsonYomiGivenName : (string)YomiGivenName;}
            {_yomiSurname = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("yomiSurname"), out var __jsonYomiSurname) ? (string)__jsonYomiSurname : (string)YomiSurname;}
            {_extensions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("extensions"), out var __jsonExtensions) ? If( __jsonExtensions as Sample.API.Runtime.Json.JsonArray, out var ___m) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphExtension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___m, (___l)=>(Sample.API.Models.IMicrosoftGraphExtension) (Sample.API.Models.MicrosoftGraphExtension.FromJson(___l) )) ))() : null : Extensions;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphContactAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphContactAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphContactAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphContactAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphContactAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphContactAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            AddIf( null != BusinessAddress ? (Sample.API.Runtime.Json.JsonNode) BusinessAddress.ToJson(null,serializationMode) : null, "businessAddress" ,container.Add );
            AddIf( null != HomeAddress ? (Sample.API.Runtime.Json.JsonNode) HomeAddress.ToJson(null,serializationMode) : null, "homeAddress" ,container.Add );
            AddIf( null != OtherAddress ? (Sample.API.Runtime.Json.JsonNode) OtherAddress.ToJson(null,serializationMode) : null, "otherAddress" ,container.Add );
            AddIf( null != (((object)AssistantName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AssistantName.ToString()) : null, "assistantName" ,container.Add );
            AddIf( null != Birthday ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Birthday?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "birthday" ,container.Add );
            AddIf( null != (((object)BusinessHomePage)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(BusinessHomePage.ToString()) : null, "businessHomePage" ,container.Add );
            if (null != BusinessPhones)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in BusinessPhones )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("businessPhones",__w);
            }
            if (null != Children)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Children )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("children",__r);
            }
            AddIf( null != (((object)CompanyName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CompanyName.ToString()) : null, "companyName" ,container.Add );
            AddIf( null != (((object)Department)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Department.ToString()) : null, "department" ,container.Add );
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            if (null != EmailAddresses)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in EmailAddresses )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("emailAddresses",__m);
            }
            AddIf( null != (((object)FileAs)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(FileAs.ToString()) : null, "fileAs" ,container.Add );
            AddIf( null != (((object)Generation)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Generation.ToString()) : null, "generation" ,container.Add );
            AddIf( null != (((object)GivenName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(GivenName.ToString()) : null, "givenName" ,container.Add );
            if (null != HomePhones)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in HomePhones )
                {
                    AddIf(null != (((object)__i)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__i.ToString()) : null ,__h.Add);
                }
                container.Add("homePhones",__h);
            }
            if (null != ImAddresses)
            {
                var __c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __d in ImAddresses )
                {
                    AddIf(null != (((object)__d)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__d.ToString()) : null ,__c.Add);
                }
                container.Add("imAddresses",__c);
            }
            AddIf( null != (((object)Initials)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Initials.ToString()) : null, "initials" ,container.Add );
            AddIf( null != (((object)JobTitle)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(JobTitle.ToString()) : null, "jobTitle" ,container.Add );
            AddIf( null != (((object)Manager)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Manager.ToString()) : null, "manager" ,container.Add );
            AddIf( null != (((object)MiddleName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MiddleName.ToString()) : null, "middleName" ,container.Add );
            AddIf( null != (((object)MobilePhone)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MobilePhone.ToString()) : null, "mobilePhone" ,container.Add );
            if (null != MultiValueExtendedProperties)
            {
                var ___x = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___y in MultiValueExtendedProperties )
                {
                    AddIf(___y?.ToJson(null, serializationMode) ,___x.Add);
                }
                container.Add("multiValueExtendedProperties",___x);
            }
            AddIf( null != (((object)NickName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(NickName.ToString()) : null, "nickName" ,container.Add );
            AddIf( null != (((object)OfficeLocation)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OfficeLocation.ToString()) : null, "officeLocation" ,container.Add );
            AddIf( null != (((object)ParentFolderId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ParentFolderId.ToString()) : null, "parentFolderId" ,container.Add );
            AddIf( null != (((object)PersonalNotes)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PersonalNotes.ToString()) : null, "personalNotes" ,container.Add );
            AddIf( null != Photo ? (Sample.API.Runtime.Json.JsonNode) Photo.ToJson(null,serializationMode) : null, "photo" ,container.Add );
            AddIf( null != (((object)Profession)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Profession.ToString()) : null, "profession" ,container.Add );
            if (null != SingleValueExtendedProperties)
            {
                var ___s = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___t in SingleValueExtendedProperties )
                {
                    AddIf(___t?.ToJson(null, serializationMode) ,___s.Add);
                }
                container.Add("singleValueExtendedProperties",___s);
            }
            AddIf( null != (((object)SpouseName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(SpouseName.ToString()) : null, "spouseName" ,container.Add );
            AddIf( null != (((object)Surname)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Surname.ToString()) : null, "surname" ,container.Add );
            AddIf( null != (((object)Title)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Title.ToString()) : null, "title" ,container.Add );
            AddIf( null != (((object)YomiCompanyName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(YomiCompanyName.ToString()) : null, "yomiCompanyName" ,container.Add );
            AddIf( null != (((object)YomiGivenName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(YomiGivenName.ToString()) : null, "yomiGivenName" ,container.Add );
            AddIf( null != (((object)YomiSurname)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(YomiSurname.ToString()) : null, "yomiSurname" ,container.Add );
            if (null != Extensions)
            {
                var ___n = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___o in Extensions )
                {
                    AddIf(___o?.ToJson(null, serializationMode) ,___n.Add);
                }
                container.Add("extensions",___n);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}