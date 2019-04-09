namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>location</summary>
    public partial class MicrosoftGraphLocation : Sample.API.Models.IMicrosoftGraphLocation
    {
        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPhysicalAddress _address;

        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        public string AddressCity
        {
            get
            {
                return /*1*/Address/*4*/.City/*3*/;
            }
            set
            {
                /*1*/Address/*4*/.City/*3*/ = value;
            }
        }
        public string AddressCountryOrRegion
        {
            get
            {
                return /*1*/Address/*4*/.CountryOrRegion/*3*/;
            }
            set
            {
                /*1*/Address/*4*/.CountryOrRegion/*3*/ = value;
            }
        }
        public string AddressPostalCode
        {
            get
            {
                return /*1*/Address/*4*/.PostalCode/*3*/;
            }
            set
            {
                /*1*/Address/*4*/.PostalCode/*3*/ = value;
            }
        }
        public string AddressState
        {
            get
            {
                return /*1*/Address/*4*/.State/*3*/;
            }
            set
            {
                /*1*/Address/*4*/.State/*3*/ = value;
            }
        }
        public string AddressStreet
        {
            get
            {
                return /*1*/Address/*4*/.Street/*3*/;
            }
            set
            {
                /*1*/Address/*4*/.Street/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Coordinates" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOutlookGeoCoordinates _coordinates;

        /// <summary>outlookGeoCoordinates</summary>
        public Sample.API.Models.IMicrosoftGraphOutlookGeoCoordinates Coordinates
        {
            get
            {
                return this._coordinates;
            }
            set
            {
                this._coordinates = value;
            }
        }
        public double? CoordinatesAccuracy
        {
            get
            {
                return /*1*/Coordinates/*4*/.Accuracy/*3*/;
            }
            set
            {
                /*1*/Coordinates/*4*/.Accuracy/*3*/ = value;
            }
        }
        public double? CoordinatesAltitude
        {
            get
            {
                return /*1*/Coordinates/*4*/.Altitude/*3*/;
            }
            set
            {
                /*1*/Coordinates/*4*/.Altitude/*3*/ = value;
            }
        }
        public double? CoordinatesAltitudeAccuracy
        {
            get
            {
                return /*1*/Coordinates/*4*/.AltitudeAccuracy/*3*/;
            }
            set
            {
                /*1*/Coordinates/*4*/.AltitudeAccuracy/*3*/ = value;
            }
        }
        public double? CoordinatesLatitude
        {
            get
            {
                return /*1*/Coordinates/*4*/.Latitude/*3*/;
            }
            set
            {
                /*1*/Coordinates/*4*/.Latitude/*3*/ = value;
            }
        }
        public double? CoordinatesLongitude
        {
            get
            {
                return /*1*/Coordinates/*4*/.Longitude/*3*/;
            }
            set
            {
                /*1*/Coordinates/*4*/.Longitude/*3*/ = value;
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
        /// <summary>Backing field for <see cref="LocationEmailAddress" /> property.</summary>
        private string _locationEmailAddress;

        public string LocationEmailAddress
        {
            get
            {
                return this._locationEmailAddress;
            }
            set
            {
                this._locationEmailAddress = value;
            }
        }
        /// <summary>Backing field for <see cref="LocationType" /> property.</summary>
        private string _locationType;

        /// <summary>locationType</summary>
        public string LocationType
        {
            get
            {
                return this._locationType;
            }
            set
            {
                this._locationType = value;
            }
        }
        /// <summary>Backing field for <see cref="LocationUri" /> property.</summary>
        private string _locationUri;

        public string LocationUri
        {
            get
            {
                return this._locationUri;
            }
            set
            {
                this._locationUri = value;
            }
        }
        /// <summary>Backing field for <see cref="UniqueId" /> property.</summary>
        private string _uniqueId;

        public string UniqueId
        {
            get
            {
                return this._uniqueId;
            }
            set
            {
                this._uniqueId = value;
            }
        }
        /// <summary>Backing field for <see cref="UniqueIdType" /> property.</summary>
        private string _uniqueIdType;

        /// <summary>locationUniqueIdType</summary>
        public string UniqueIdType
        {
            get
            {
                return this._uniqueIdType;
            }
            set
            {
                this._uniqueIdType = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphLocation" /> instance.</summary>
        public MicrosoftGraphLocation()
        {
        }
    }
    /// location
    public partial interface IMicrosoftGraphLocation : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphPhysicalAddress Address { get; set; }
        string AddressCity { get; set; }
        string AddressCountryOrRegion { get; set; }
        string AddressPostalCode { get; set; }
        string AddressState { get; set; }
        string AddressStreet { get; set; }
        Sample.API.Models.IMicrosoftGraphOutlookGeoCoordinates Coordinates { get; set; }
        double? CoordinatesAccuracy { get; set; }
        double? CoordinatesAltitude { get; set; }
        double? CoordinatesAltitudeAccuracy { get; set; }
        double? CoordinatesLatitude { get; set; }
        double? CoordinatesLongitude { get; set; }
        string DisplayName { get; set; }
        string LocationEmailAddress { get; set; }
        string LocationType { get; set; }
        string LocationUri { get; set; }
        string UniqueId { get; set; }
        string UniqueIdType { get; set; }
    }
}