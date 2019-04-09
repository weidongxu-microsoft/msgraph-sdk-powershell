namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPerson : Sample.API.Models.IMicrosoftGraphPerson, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPerson" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPersonAllof1 _componentsSchemasMicrosoftGraphPersonAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPersonAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPerson" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string Birthday
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .Birthday;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .Birthday = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .CompanyName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .CompanyName = value;
            }
        }
        public string Department
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .Department;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .Department = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .DisplayName = value;
            }
        }
        public string GivenName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .GivenName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .GivenName = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        public string ImAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .ImAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .ImAddress = value;
            }
        }
        public bool? IsFavorite
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .IsFavorite;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .IsFavorite = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .JobTitle;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .JobTitle = value;
            }
        }
        public string OfficeLocation
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .OfficeLocation;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .OfficeLocation = value;
            }
        }
        public string PersonNotes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .PersonNotes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .PersonNotes = value;
            }
        }
        /// <summary>personType</summary>
        public Sample.API.Models.IMicrosoftGraphPersonType PersonType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .PersonType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .PersonType = value;
            }
        }
        public string PersonTypeClass
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .PersonTypeClass;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .PersonTypeClass = value;
            }
        }
        public string PersonTypeSubclass
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .PersonTypeSubclass;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .PersonTypeSubclass = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPhone[] Phones
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .Phones;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .Phones = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphLocation[] PostalAddresses
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .PostalAddresses;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .PostalAddresses = value;
            }
        }
        public string Profession
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .Profession;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .Profession = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphScoredEmailAddress[] ScoredEmailAddresses
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .ScoredEmailAddresses;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .ScoredEmailAddresses = value;
            }
        }
        public string Surname
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .Surname;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .Surname = value;
            }
        }
        public string UserPrincipalName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .UserPrincipalName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .UserPrincipalName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphWebsite[] Websites
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .Websites;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .Websites = value;
            }
        }
        public string YomiCompany
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPersonAllof1 .YomiCompany;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPersonAllof1 .YomiCompany = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPerson" /> instance.</summary>
        public MicrosoftGraphPerson()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPersonAllof1 ), _componentsSchemasMicrosoftGraphPersonAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPersonAllof1 ), _componentsSchemasMicrosoftGraphPersonAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPerson : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPersonAllof1 {

    }
}