namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>geoCoordinates</summary>
    public partial class MicrosoftGraphGeoCoordinates : Sample.API.Models.IMicrosoftGraphGeoCoordinates
    {
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
        /// <summary>Creates an new <see cref="MicrosoftGraphGeoCoordinates" /> instance.</summary>
        public MicrosoftGraphGeoCoordinates()
        {
        }
    }
    /// geoCoordinates
    public partial interface IMicrosoftGraphGeoCoordinates : Sample.API.Runtime.IJsonSerializable {
        double? Altitude { get; set; }
        double? Latitude { get; set; }
        double? Longitude { get; set; }
    }
}