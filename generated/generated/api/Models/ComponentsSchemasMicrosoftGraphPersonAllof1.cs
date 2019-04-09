namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>person</summary>
    public partial class ComponentsSchemasMicrosoftGraphPersonAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPersonAllof1
    {
        /// <summary>Backing field for <see cref="Birthday" /> property.</summary>
        private string _birthday;

        public string Birthday
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
        /// <summary>Backing field for <see cref="ImAddress" /> property.</summary>
        private string _imAddress;

        public string ImAddress
        {
            get
            {
                return this._imAddress;
            }
            set
            {
                this._imAddress = value;
            }
        }
        /// <summary>Backing field for <see cref="IsFavorite" /> property.</summary>
        private bool? _isFavorite;

        public bool? IsFavorite
        {
            get
            {
                return this._isFavorite;
            }
            set
            {
                this._isFavorite = value;
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
        /// <summary>Backing field for <see cref="PersonNotes" /> property.</summary>
        private string _personNotes;

        public string PersonNotes
        {
            get
            {
                return this._personNotes;
            }
            set
            {
                this._personNotes = value;
            }
        }
        /// <summary>Backing field for <see cref="PersonType" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPersonType _personType;

        /// <summary>personType</summary>
        public Sample.API.Models.IMicrosoftGraphPersonType PersonType
        {
            get
            {
                return this._personType;
            }
            set
            {
                this._personType = value;
            }
        }
        public string PersonTypeClass
        {
            get
            {
                return /*1*/PersonType/*4*/.Class/*3*/;
            }
            set
            {
                /*1*/PersonType/*4*/.Class/*3*/ = value;
            }
        }
        public string PersonTypeSubclass
        {
            get
            {
                return /*1*/PersonType/*4*/.Subclass/*3*/;
            }
            set
            {
                /*1*/PersonType/*4*/.Subclass/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Phones" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPhone[] _phones;

        public Sample.API.Models.IMicrosoftGraphPhone[] Phones
        {
            get
            {
                return this._phones;
            }
            set
            {
                this._phones = value;
            }
        }
        /// <summary>Backing field for <see cref="PostalAddresses" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphLocation[] _postalAddresses;

        public Sample.API.Models.IMicrosoftGraphLocation[] PostalAddresses
        {
            get
            {
                return this._postalAddresses;
            }
            set
            {
                this._postalAddresses = value;
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
        /// <summary>Backing field for <see cref="ScoredEmailAddresses" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphScoredEmailAddress[] _scoredEmailAddresses;

        public Sample.API.Models.IMicrosoftGraphScoredEmailAddress[] ScoredEmailAddresses
        {
            get
            {
                return this._scoredEmailAddresses;
            }
            set
            {
                this._scoredEmailAddresses = value;
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
        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        public string UserPrincipalName
        {
            get
            {
                return this._userPrincipalName;
            }
            set
            {
                this._userPrincipalName = value;
            }
        }
        /// <summary>Backing field for <see cref="Websites" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWebsite[] _websites;

        public Sample.API.Models.IMicrosoftGraphWebsite[] Websites
        {
            get
            {
                return this._websites;
            }
            set
            {
                this._websites = value;
            }
        }
        /// <summary>Backing field for <see cref="YomiCompany" /> property.</summary>
        private string _yomiCompany;

        public string YomiCompany
        {
            get
            {
                return this._yomiCompany;
            }
            set
            {
                this._yomiCompany = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPersonAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPersonAllof1()
        {
        }
    }
    /// person
    public partial interface IComponentsSchemasMicrosoftGraphPersonAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Birthday { get; set; }
        string CompanyName { get; set; }
        string Department { get; set; }
        string DisplayName { get; set; }
        string GivenName { get; set; }
        string ImAddress { get; set; }
        bool? IsFavorite { get; set; }
        string JobTitle { get; set; }
        string OfficeLocation { get; set; }
        string PersonNotes { get; set; }
        Sample.API.Models.IMicrosoftGraphPersonType PersonType { get; set; }
        string PersonTypeClass { get; set; }
        string PersonTypeSubclass { get; set; }
        Sample.API.Models.IMicrosoftGraphPhone[] Phones { get; set; }
        Sample.API.Models.IMicrosoftGraphLocation[] PostalAddresses { get; set; }
        string Profession { get; set; }
        Sample.API.Models.IMicrosoftGraphScoredEmailAddress[] ScoredEmailAddresses { get; set; }
        string Surname { get; set; }
        string UserPrincipalName { get; set; }
        Sample.API.Models.IMicrosoftGraphWebsite[] Websites { get; set; }
        string YomiCompany { get; set; }
    }
}