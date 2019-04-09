namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>physicalAddress</summary>
    public partial class MicrosoftGraphPhysicalAddress : Sample.API.Models.IMicrosoftGraphPhysicalAddress
    {
        /// <summary>Backing field for <see cref="City" /> property.</summary>
        private string _city;

        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }
        /// <summary>Backing field for <see cref="CountryOrRegion" /> property.</summary>
        private string _countryOrRegion;

        public string CountryOrRegion
        {
            get
            {
                return this._countryOrRegion;
            }
            set
            {
                this._countryOrRegion = value;
            }
        }
        /// <summary>Backing field for <see cref="PostalCode" /> property.</summary>
        private string _postalCode;

        public string PostalCode
        {
            get
            {
                return this._postalCode;
            }
            set
            {
                this._postalCode = value;
            }
        }
        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Backing field for <see cref="Street" /> property.</summary>
        private string _street;

        public string Street
        {
            get
            {
                return this._street;
            }
            set
            {
                this._street = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPhysicalAddress" /> instance.</summary>
        public MicrosoftGraphPhysicalAddress()
        {
        }
    }
    /// physicalAddress
    public partial interface IMicrosoftGraphPhysicalAddress : Sample.API.Runtime.IJsonSerializable {
        string City { get; set; }
        string CountryOrRegion { get; set; }
        string PostalCode { get; set; }
        string State { get; set; }
        string Street { get; set; }
    }
}