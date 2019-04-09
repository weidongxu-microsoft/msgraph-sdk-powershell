namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>contact</summary>
    public partial class ComponentsSchemasMicrosoftGraphContactAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphContactAllof1
    {
        /// <summary>Backing field for <see cref="AssistantName" /> property.</summary>
        private string _assistantName;

        public string AssistantName
        {
            get
            {
                return this._assistantName;
            }
            set
            {
                this._assistantName = value;
            }
        }
        /// <summary>Backing field for <see cref="Birthday" /> property.</summary>
        private System.DateTime? _birthday;

        public System.DateTime? Birthday
        {
            get
            {
                return this._birthday;
            }
            set
            {
                this._birthday = value;
            }
        }
        /// <summary>Backing field for <see cref="BusinessAddress" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPhysicalAddress _businessAddress;

        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress BusinessAddress
        {
            get
            {
                return this._businessAddress;
            }
            set
            {
                this._businessAddress = value;
            }
        }
        public string BusinessAddressCity
        {
            get
            {
                return /*1*/BusinessAddress/*4*/.City/*3*/;
            }
            set
            {
                /*1*/BusinessAddress/*4*/.City/*3*/ = value;
            }
        }
        public string BusinessAddressCountryOrRegion
        {
            get
            {
                return /*1*/BusinessAddress/*4*/.CountryOrRegion/*3*/;
            }
            set
            {
                /*1*/BusinessAddress/*4*/.CountryOrRegion/*3*/ = value;
            }
        }
        public string BusinessAddressPostalCode
        {
            get
            {
                return /*1*/BusinessAddress/*4*/.PostalCode/*3*/;
            }
            set
            {
                /*1*/BusinessAddress/*4*/.PostalCode/*3*/ = value;
            }
        }
        public string BusinessAddressState
        {
            get
            {
                return /*1*/BusinessAddress/*4*/.State/*3*/;
            }
            set
            {
                /*1*/BusinessAddress/*4*/.State/*3*/ = value;
            }
        }
        public string BusinessAddressStreet
        {
            get
            {
                return /*1*/BusinessAddress/*4*/.Street/*3*/;
            }
            set
            {
                /*1*/BusinessAddress/*4*/.Street/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="BusinessHomePage" /> property.</summary>
        private string _businessHomePage;

        public string BusinessHomePage
        {
            get
            {
                return this._businessHomePage;
            }
            set
            {
                this._businessHomePage = value;
            }
        }
        /// <summary>Backing field for <see cref="BusinessPhones" /> property.</summary>
        private string[] _businessPhones;

        public string[] BusinessPhones
        {
            get
            {
                return this._businessPhones;
            }
            set
            {
                this._businessPhones = value;
            }
        }
        /// <summary>Backing field for <see cref="Children" /> property.</summary>
        private string[] _children;

        public string[] Children
        {
            get
            {
                return this._children;
            }
            set
            {
                this._children = value;
            }
        }
        /// <summary>Backing field for <see cref="CompanyName" /> property.</summary>
        private string _companyName;

        public string CompanyName
        {
            get
            {
                return this._companyName;
            }
            set
            {
                this._companyName = value;
            }
        }
        /// <summary>Backing field for <see cref="Department" /> property.</summary>
        private string _department;

        public string Department
        {
            get
            {
                return this._department;
            }
            set
            {
                this._department = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="EmailAddresses" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEmailAddress[] _emailAddresses;

        public Sample.API.Models.IMicrosoftGraphEmailAddress[] EmailAddresses
        {
            get
            {
                return this._emailAddresses;
            }
            set
            {
                this._emailAddresses = value;
            }
        }
        /// <summary>Backing field for <see cref="Extensions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphExtension[] _extensions;

        public Sample.API.Models.IMicrosoftGraphExtension[] Extensions
        {
            get
            {
                return this._extensions;
            }
            set
            {
                this._extensions = value;
            }
        }
        /// <summary>Backing field for <see cref="FileAs" /> property.</summary>
        private string _fileAs;

        public string FileAs
        {
            get
            {
                return this._fileAs;
            }
            set
            {
                this._fileAs = value;
            }
        }
        /// <summary>Backing field for <see cref="Generation" /> property.</summary>
        private string _generation;

        public string Generation
        {
            get
            {
                return this._generation;
            }
            set
            {
                this._generation = value;
            }
        }
        /// <summary>Backing field for <see cref="GivenName" /> property.</summary>
        private string _givenName;

        public string GivenName
        {
            get
            {
                return this._givenName;
            }
            set
            {
                this._givenName = value;
            }
        }
        /// <summary>Backing field for <see cref="HomeAddress" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPhysicalAddress _homeAddress;

        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress HomeAddress
        {
            get
            {
                return this._homeAddress;
            }
            set
            {
                this._homeAddress = value;
            }
        }
        public string HomeAddressCity
        {
            get
            {
                return /*1*/HomeAddress/*4*/.City/*3*/;
            }
            set
            {
                /*1*/HomeAddress/*4*/.City/*3*/ = value;
            }
        }
        public string HomeAddressCountryOrRegion
        {
            get
            {
                return /*1*/HomeAddress/*4*/.CountryOrRegion/*3*/;
            }
            set
            {
                /*1*/HomeAddress/*4*/.CountryOrRegion/*3*/ = value;
            }
        }
        public string HomeAddressPostalCode
        {
            get
            {
                return /*1*/HomeAddress/*4*/.PostalCode/*3*/;
            }
            set
            {
                /*1*/HomeAddress/*4*/.PostalCode/*3*/ = value;
            }
        }
        public string HomeAddressState
        {
            get
            {
                return /*1*/HomeAddress/*4*/.State/*3*/;
            }
            set
            {
                /*1*/HomeAddress/*4*/.State/*3*/ = value;
            }
        }
        public string HomeAddressStreet
        {
            get
            {
                return /*1*/HomeAddress/*4*/.Street/*3*/;
            }
            set
            {
                /*1*/HomeAddress/*4*/.Street/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="HomePhones" /> property.</summary>
        private string[] _homePhones;

        public string[] HomePhones
        {
            get
            {
                return this._homePhones;
            }
            set
            {
                this._homePhones = value;
            }
        }
        /// <summary>Backing field for <see cref="ImAddresses" /> property.</summary>
        private string[] _imAddresses;

        public string[] ImAddresses
        {
            get
            {
                return this._imAddresses;
            }
            set
            {
                this._imAddresses = value;
            }
        }
        /// <summary>Backing field for <see cref="Initials" /> property.</summary>
        private string _initials;

        public string Initials
        {
            get
            {
                return this._initials;
            }
            set
            {
                this._initials = value;
            }
        }
        /// <summary>Backing field for <see cref="JobTitle" /> property.</summary>
        private string _jobTitle;

        public string JobTitle
        {
            get
            {
                return this._jobTitle;
            }
            set
            {
                this._jobTitle = value;
            }
        }
        /// <summary>Backing field for <see cref="Manager" /> property.</summary>
        private string _manager;

        public string Manager
        {
            get
            {
                return this._manager;
            }
            set
            {
                this._manager = value;
            }
        }
        /// <summary>Backing field for <see cref="MiddleName" /> property.</summary>
        private string _middleName;

        public string MiddleName
        {
            get
            {
                return this._middleName;
            }
            set
            {
                this._middleName = value;
            }
        }
        /// <summary>Backing field for <see cref="MobilePhone" /> property.</summary>
        private string _mobilePhone;

        public string MobilePhone
        {
            get
            {
                return this._mobilePhone;
            }
            set
            {
                this._mobilePhone = value;
            }
        }
        /// <summary>Backing field for <see cref="MultiValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] _multiValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return this._multiValueExtendedProperties;
            }
            set
            {
                this._multiValueExtendedProperties = value;
            }
        }
        /// <summary>Backing field for <see cref="NickName" /> property.</summary>
        private string _nickName;

        public string NickName
        {
            get
            {
                return this._nickName;
            }
            set
            {
                this._nickName = value;
            }
        }
        /// <summary>Backing field for <see cref="OfficeLocation" /> property.</summary>
        private string _officeLocation;

        public string OfficeLocation
        {
            get
            {
                return this._officeLocation;
            }
            set
            {
                this._officeLocation = value;
            }
        }
        /// <summary>Backing field for <see cref="OtherAddress" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPhysicalAddress _otherAddress;

        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress OtherAddress
        {
            get
            {
                return this._otherAddress;
            }
            set
            {
                this._otherAddress = value;
            }
        }
        public string OtherAddressCity
        {
            get
            {
                return /*1*/OtherAddress/*4*/.City/*3*/;
            }
            set
            {
                /*1*/OtherAddress/*4*/.City/*3*/ = value;
            }
        }
        public string OtherAddressCountryOrRegion
        {
            get
            {
                return /*1*/OtherAddress/*4*/.CountryOrRegion/*3*/;
            }
            set
            {
                /*1*/OtherAddress/*4*/.CountryOrRegion/*3*/ = value;
            }
        }
        public string OtherAddressPostalCode
        {
            get
            {
                return /*1*/OtherAddress/*4*/.PostalCode/*3*/;
            }
            set
            {
                /*1*/OtherAddress/*4*/.PostalCode/*3*/ = value;
            }
        }
        public string OtherAddressState
        {
            get
            {
                return /*1*/OtherAddress/*4*/.State/*3*/;
            }
            set
            {
                /*1*/OtherAddress/*4*/.State/*3*/ = value;
            }
        }
        public string OtherAddressStreet
        {
            get
            {
                return /*1*/OtherAddress/*4*/.Street/*3*/;
            }
            set
            {
                /*1*/OtherAddress/*4*/.Street/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentFolderId" /> property.</summary>
        private string _parentFolderId;

        public string ParentFolderId
        {
            get
            {
                return this._parentFolderId;
            }
            set
            {
                this._parentFolderId = value;
            }
        }
        /// <summary>Backing field for <see cref="PersonalNotes" /> property.</summary>
        private string _personalNotes;

        public string PersonalNotes
        {
            get
            {
                return this._personalNotes;
            }
            set
            {
                this._personalNotes = value;
            }
        }
        /// <summary>Backing field for <see cref="Photo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphProfilePhoto _photo;

        public Sample.API.Models.IMicrosoftGraphProfilePhoto Photo
        {
            get
            {
                return this._photo;
            }
            set
            {
                this._photo = value;
            }
        }
        /// <summary>Backing field for <see cref="Profession" /> property.</summary>
        private string _profession;

        public string Profession
        {
            get
            {
                return this._profession;
            }
            set
            {
                this._profession = value;
            }
        }
        /// <summary>Backing field for <see cref="SingleValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] _singleValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return this._singleValueExtendedProperties;
            }
            set
            {
                this._singleValueExtendedProperties = value;
            }
        }
        /// <summary>Backing field for <see cref="SpouseName" /> property.</summary>
        private string _spouseName;

        public string SpouseName
        {
            get
            {
                return this._spouseName;
            }
            set
            {
                this._spouseName = value;
            }
        }
        /// <summary>Backing field for <see cref="Surname" /> property.</summary>
        private string _surname;

        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
            }
        }
        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        /// <summary>Backing field for <see cref="YomiCompanyName" /> property.</summary>
        private string _yomiCompanyName;

        public string YomiCompanyName
        {
            get
            {
                return this._yomiCompanyName;
            }
            set
            {
                this._yomiCompanyName = value;
            }
        }
        /// <summary>Backing field for <see cref="YomiGivenName" /> property.</summary>
        private string _yomiGivenName;

        public string YomiGivenName
        {
            get
            {
                return this._yomiGivenName;
            }
            set
            {
                this._yomiGivenName = value;
            }
        }
        /// <summary>Backing field for <see cref="YomiSurname" /> property.</summary>
        private string _yomiSurname;

        public string YomiSurname
        {
            get
            {
                return this._yomiSurname;
            }
            set
            {
                this._yomiSurname = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphContactAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphContactAllof1()
        {
        }
    }
    /// contact
    public partial interface IComponentsSchemasMicrosoftGraphContactAllof1 : Sample.API.Runtime.IJsonSerializable {
        string AssistantName { get; set; }
        System.DateTime? Birthday { get; set; }
        Sample.API.Models.IMicrosoftGraphPhysicalAddress BusinessAddress { get; set; }
        string BusinessAddressCity { get; set; }
        string BusinessAddressCountryOrRegion { get; set; }
        string BusinessAddressPostalCode { get; set; }
        string BusinessAddressState { get; set; }
        string BusinessAddressStreet { get; set; }
        string BusinessHomePage { get; set; }
        string[] BusinessPhones { get; set; }
        string[] Children { get; set; }
        string CompanyName { get; set; }
        string Department { get; set; }
        string DisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphEmailAddress[] EmailAddresses { get; set; }
        Sample.API.Models.IMicrosoftGraphExtension[] Extensions { get; set; }
        string FileAs { get; set; }
        string Generation { get; set; }
        string GivenName { get; set; }
        Sample.API.Models.IMicrosoftGraphPhysicalAddress HomeAddress { get; set; }
        string HomeAddressCity { get; set; }
        string HomeAddressCountryOrRegion { get; set; }
        string HomeAddressPostalCode { get; set; }
        string HomeAddressState { get; set; }
        string HomeAddressStreet { get; set; }
        string[] HomePhones { get; set; }
        string[] ImAddresses { get; set; }
        string Initials { get; set; }
        string JobTitle { get; set; }
        string Manager { get; set; }
        string MiddleName { get; set; }
        string MobilePhone { get; set; }
        Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties { get; set; }
        string NickName { get; set; }
        string OfficeLocation { get; set; }
        Sample.API.Models.IMicrosoftGraphPhysicalAddress OtherAddress { get; set; }
        string OtherAddressCity { get; set; }
        string OtherAddressCountryOrRegion { get; set; }
        string OtherAddressPostalCode { get; set; }
        string OtherAddressState { get; set; }
        string OtherAddressStreet { get; set; }
        string ParentFolderId { get; set; }
        string PersonalNotes { get; set; }
        Sample.API.Models.IMicrosoftGraphProfilePhoto Photo { get; set; }
        string Profession { get; set; }
        Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties { get; set; }
        string SpouseName { get; set; }
        string Surname { get; set; }
        string Title { get; set; }
        string YomiCompanyName { get; set; }
        string YomiGivenName { get; set; }
        string YomiSurname { get; set; }
    }
}