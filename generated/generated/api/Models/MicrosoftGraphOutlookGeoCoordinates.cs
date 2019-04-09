namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>outlookGeoCoordinates</summary>
    public partial class MicrosoftGraphOutlookGeoCoordinates : Sample.API.Models.IMicrosoftGraphOutlookGeoCoordinates
    {
        /// <summary>Backing field for <see cref="Accuracy" /> property.</summary>
        private double? _accuracy;

        public double? Accuracy
        {
            get
            {
                return this._accuracy;
            }
            set
            {
                this._accuracy = value;
            }
        }
        /// <summary>Backing field for <see cref="Altitude" /> property.</summary>
        private double? _altitude;

        public double? Altitude
        {
            get
            {
                return this._altitude;
            }
            set
            {
                this._altitude = value;
            }
        }
        /// <summary>Backing field for <see cref="AltitudeAccuracy" /> property.</summary>
        private double? _altitudeAccuracy;

        public double? AltitudeAccuracy
        {
            get
            {
                return this._altitudeAccuracy;
            }
            set
            {
                this._altitudeAccuracy = value;
            }
        }
        /// <summary>Backing field for <see cref="Latitude" /> property.</summary>
        private double? _latitude;

        public double? Latitude
        {
            get
            {
                return this._latitude;
            }
            set
            {
                this._latitude = value;
            }
        }
        /// <summary>Backing field for <see cref="Longitude" /> property.</summary>
        private double? _longitude;

        public double? Longitude
        {
            get
            {
                return this._longitude;
            }
            set
            {
                this._longitude = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOutlookGeoCoordinates" /> instance.</summary>
        public MicrosoftGraphOutlookGeoCoordinates()
        {
        }
    }
    /// outlookGeoCoordinates
    public partial interface IMicrosoftGraphOutlookGeoCoordinates : Sample.API.Runtime.IJsonSerializable {
        double? Accuracy { get; set; }
        double? Altitude { get; set; }
        double? AltitudeAccuracy { get; set; }
        double? Latitude { get; set; }
        double? Longitude { get; set; }
    }
}