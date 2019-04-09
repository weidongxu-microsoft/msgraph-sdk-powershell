namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>photo</summary>
    public partial class MicrosoftGraphPhoto : Sample.API.Models.IMicrosoftGraphPhoto
    {
        /// <summary>Backing field for <see cref="CameraMake" /> property.</summary>
        private string _cameraMake;

        public string CameraMake
        {
            get
            {
                return this._cameraMake;
            }
            set
            {
                this._cameraMake = value;
            }
        }
        /// <summary>Backing field for <see cref="CameraModel" /> property.</summary>
        private string _cameraModel;

        public string CameraModel
        {
            get
            {
                return this._cameraModel;
            }
            set
            {
                this._cameraModel = value;
            }
        }
        /// <summary>Backing field for <see cref="ExposureDenominator" /> property.</summary>
        private double? _exposureDenominator;

        public double? ExposureDenominator
        {
            get
            {
                return this._exposureDenominator;
            }
            set
            {
                this._exposureDenominator = value;
            }
        }
        /// <summary>Backing field for <see cref="ExposureNumerator" /> property.</summary>
        private double? _exposureNumerator;

        public double? ExposureNumerator
        {
            get
            {
                return this._exposureNumerator;
            }
            set
            {
                this._exposureNumerator = value;
            }
        }
        /// <summary>Backing field for <see cref="FNumber" /> property.</summary>
        private double? _fNumber;

        public double? FNumber
        {
            get
            {
                return this._fNumber;
            }
            set
            {
                this._fNumber = value;
            }
        }
        /// <summary>Backing field for <see cref="FocalLength" /> property.</summary>
        private double? _focalLength;

        public double? FocalLength
        {
            get
            {
                return this._focalLength;
            }
            set
            {
                this._focalLength = value;
            }
        }
        /// <summary>Backing field for <see cref="Iso" /> property.</summary>
        private int? _iso;

        public int? Iso
        {
            get
            {
                return this._iso;
            }
            set
            {
                this._iso = value;
            }
        }
        /// <summary>Backing field for <see cref="TakenDateTime" /> property.</summary>
        private System.DateTime? _takenDateTime;

        public System.DateTime? TakenDateTime
        {
            get
            {
                return this._takenDateTime;
            }
            set
            {
                this._takenDateTime = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPhoto" /> instance.</summary>
        public MicrosoftGraphPhoto()
        {
        }
    }
    /// photo
    public partial interface IMicrosoftGraphPhoto : Sample.API.Runtime.IJsonSerializable {
        string CameraMake { get; set; }
        string CameraModel { get; set; }
        double? ExposureDenominator { get; set; }
        double? ExposureNumerator { get; set; }
        double? FNumber { get; set; }
        double? FocalLength { get; set; }
        int? Iso { get; set; }
        System.DateTime? TakenDateTime { get; set; }
    }
}