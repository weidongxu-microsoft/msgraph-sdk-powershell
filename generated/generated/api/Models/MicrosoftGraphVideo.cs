namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>video</summary>
    public partial class MicrosoftGraphVideo : Sample.API.Models.IMicrosoftGraphVideo
    {
        /// <summary>Backing field for <see cref="AudioBitsPerSample" /> property.</summary>
        private int? _audioBitsPerSample;

        public int? AudioBitsPerSample
        {
            get
            {
                return this._audioBitsPerSample;
            }
            set
            {
                this._audioBitsPerSample = value;
            }
        }
        /// <summary>Backing field for <see cref="AudioChannels" /> property.</summary>
        private int? _audioChannels;

        public int? AudioChannels
        {
            get
            {
                return this._audioChannels;
            }
            set
            {
                this._audioChannels = value;
            }
        }
        /// <summary>Backing field for <see cref="AudioFormat" /> property.</summary>
        private string _audioFormat;

        public string AudioFormat
        {
            get
            {
                return this._audioFormat;
            }
            set
            {
                this._audioFormat = value;
            }
        }
        /// <summary>Backing field for <see cref="AudioSamplesPerSecond" /> property.</summary>
        private int? _audioSamplesPerSecond;

        public int? AudioSamplesPerSecond
        {
            get
            {
                return this._audioSamplesPerSecond;
            }
            set
            {
                this._audioSamplesPerSecond = value;
            }
        }
        /// <summary>Backing field for <see cref="Bitrate" /> property.</summary>
        private int? _bitrate;

        public int? Bitrate
        {
            get
            {
                return this._bitrate;
            }
            set
            {
                this._bitrate = value;
            }
        }
        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private long? _duration;

        public long? Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        /// <summary>Backing field for <see cref="FourCC" /> property.</summary>
        private string _fourCC;

        public string FourCC
        {
            get
            {
                return this._fourCC;
            }
            set
            {
                this._fourCC = value;
            }
        }
        /// <summary>Backing field for <see cref="FrameRate" /> property.</summary>
        private double? _frameRate;

        public double? FrameRate
        {
            get
            {
                return this._frameRate;
            }
            set
            {
                this._frameRate = value;
            }
        }
        /// <summary>Backing field for <see cref="Height" /> property.</summary>
        private int? _height;

        public int? Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        /// <summary>Backing field for <see cref="Width" /> property.</summary>
        private int? _width;

        public int? Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphVideo" /> instance.</summary>
        public MicrosoftGraphVideo()
        {
        }
    }
    /// video
    public partial interface IMicrosoftGraphVideo : Sample.API.Runtime.IJsonSerializable {
        int? AudioBitsPerSample { get; set; }
        int? AudioChannels { get; set; }
        string AudioFormat { get; set; }
        int? AudioSamplesPerSecond { get; set; }
        int? Bitrate { get; set; }
        long? Duration { get; set; }
        string FourCC { get; set; }
        double? FrameRate { get; set; }
        int? Height { get; set; }
        int? Width { get; set; }
    }
}