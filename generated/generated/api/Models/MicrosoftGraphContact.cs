namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphContact : Sample.API.Models.IMicrosoftGraphContact, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphContact" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphContactAllof1 _componentsSchemasMicrosoftGraphContactAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphContactAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphContact" /></summary>
        private Sample.API.Models.IMicrosoftGraphOutlookItem _microsoftGraphOutlookItem = new Sample.API.Models.MicrosoftGraphOutlookItem ();
        public string AssistantName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .AssistantName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .AssistantName = value;
            }
        }
        public System.DateTime? Birthday
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Birthday;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Birthday = value;
            }
        }
        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress BusinessAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddress = value;
            }
        }
        public string BusinessAddressCity
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressCity;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressCity = value;
            }
        }
        public string BusinessAddressCountryOrRegion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressCountryOrRegion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressCountryOrRegion = value;
            }
        }
        public string BusinessAddressPostalCode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressPostalCode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressPostalCode = value;
            }
        }
        public string BusinessAddressState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressState = value;
            }
        }
        public string BusinessAddressStreet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressStreet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessAddressStreet = value;
            }
        }
        public string BusinessHomePage
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessHomePage;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessHomePage = value;
            }
        }
        public string[] BusinessPhones
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .BusinessPhones;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .BusinessPhones = value;
            }
        }
        public string[] Categories
        {
            get
            {
                return _microsoftGraphOutlookItem .Categories;
            }
            set
            {
                _microsoftGraphOutlookItem .Categories = value;
            }
        }
        public string ChangeKey
        {
            get
            {
                return _microsoftGraphOutlookItem .ChangeKey;
            }
            set
            {
                _microsoftGraphOutlookItem .ChangeKey = value;
            }
        }
        public string[] Children
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Children;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Children = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .CompanyName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .CompanyName = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphOutlookItem .CreatedDateTime;
            }
            set
            {
                _microsoftGraphOutlookItem .CreatedDateTime = value;
            }
        }
        public string Department
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Department;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Department = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .DisplayName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphEmailAddress[] EmailAddresses
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .EmailAddresses;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .EmailAddresses = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphExtension[] Extensions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Extensions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Extensions = value;
            }
        }
        public string FileAs
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .FileAs;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .FileAs = value;
            }
        }
        public string Generation
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Generation;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Generation = value;
            }
        }
        public string GivenName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .GivenName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .GivenName = value;
            }
        }
        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress HomeAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddress = value;
            }
        }
        public string HomeAddressCity
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressCity;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressCity = value;
            }
        }
        public string HomeAddressCountryOrRegion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressCountryOrRegion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressCountryOrRegion = value;
            }
        }
        public string HomeAddressPostalCode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressPostalCode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressPostalCode = value;
            }
        }
        public string HomeAddressState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressState = value;
            }
        }
        public string HomeAddressStreet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressStreet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .HomeAddressStreet = value;
            }
        }
        public string[] HomePhones
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .HomePhones;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .HomePhones = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOutlookItem .Id;
            }
            set
            {
                _microsoftGraphOutlookItem .Id = value;
            }
        }
        public string[] ImAddresses
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .ImAddresses;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .ImAddresses = value;
            }
        }
        public string Initials
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Initials;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Initials = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .JobTitle;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .JobTitle = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _microsoftGraphOutlookItem .LastModifiedDateTime;
            }
            set
            {
                _microsoftGraphOutlookItem .LastModifiedDateTime = value;
            }
        }
        public string Manager
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Manager;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Manager = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .MiddleName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .MiddleName = value;
            }
        }
        public string MobilePhone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .MobilePhone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .MobilePhone = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .MultiValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .MultiValueExtendedProperties = value;
            }
        }
        public string NickName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .NickName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .NickName = value;
            }
        }
        public string OfficeLocation
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .OfficeLocation;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .OfficeLocation = value;
            }
        }
        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress OtherAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddress = value;
            }
        }
        public string OtherAddressCity
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressCity;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressCity = value;
            }
        }
        public string OtherAddressCountryOrRegion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressCountryOrRegion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressCountryOrRegion = value;
            }
        }
        public string OtherAddressPostalCode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressPostalCode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressPostalCode = value;
            }
        }
        public string OtherAddressState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressState = value;
            }
        }
        public string OtherAddressStreet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressStreet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .OtherAddressStreet = value;
            }
        }
        public string ParentFolderId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .ParentFolderId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .ParentFolderId = value;
            }
        }
        public string PersonalNotes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .PersonalNotes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .PersonalNotes = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphProfilePhoto Photo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Photo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Photo = value;
            }
        }
        public string Profession
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Profession;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Profession = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .SingleValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .SingleValueExtendedProperties = value;
            }
        }
        public string SpouseName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .SpouseName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .SpouseName = value;
            }
        }
        public string Surname
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Surname;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Surname = value;
            }
        }
        public string Title
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .Title;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .Title = value;
            }
        }
        public string YomiCompanyName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .YomiCompanyName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .YomiCompanyName = value;
            }
        }
        public string YomiGivenName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .YomiGivenName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .YomiGivenName = value;
            }
        }
        public string YomiSurname
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactAllof1 .YomiSurname;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactAllof1 .YomiSurname = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphContact" /> instance.</summary>
        public MicrosoftGraphContact()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOutlookItem ), _microsoftGraphOutlookItem );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOutlookItem ), _microsoftGraphOutlookItem );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphContactAllof1 ), _componentsSchemasMicrosoftGraphContactAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphContactAllof1 ), _componentsSchemasMicrosoftGraphContactAllof1 );
        }
    }
    public partial interface IMicrosoftGraphContact : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOutlookItem, Sample.API.Models.IComponentsSchemasMicrosoftGraphContactAllof1 {

    }
}