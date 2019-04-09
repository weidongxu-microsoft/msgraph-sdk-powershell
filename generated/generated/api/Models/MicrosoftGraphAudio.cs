namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>audio</summary>
    public partial class MicrosoftGraphAudio : Sample.API.Models.IMicrosoftGraphAudio
    {
        /// <summary>Backing field for <see cref="Album" /> property.</summary>
        private string _album;

        public string Album
        {
            get
            {
                return this._album;
            }
            set
            {
                this._album = value;
            }
        }
        /// <summary>Backing field for <see cref="AlbumArtist" /> property.</summary>
        private string _albumArtist;

        public string AlbumArtist
        {
            get
            {
                return this._albumArtist;
            }
            set
            {
                this._albumArtist = value;
            }
        }
        /// <summary>Backing field for <see cref="Artist" /> property.</summary>
        private string _artist;

        public string Artist
        {
            get
            {
                return this._artist;
            }
            set
            {
                this._artist = value;
            }
        }
        /// <summary>Backing field for <see cref="Bitrate" /> property.</summary>
        private long? _bitrate;

        public long? Bitrate
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
        /// <summary>Backing field for <see cref="Composers" /> property.</summary>
        private string _composers;

        public string Composers
        {
            get
            {
                return this._composers;
            }
            set
            {
                this._composers = value;
            }
        }
        /// <summary>Backing field for <see cref="Copyright" /> property.</summary>
        private string _copyright;

        public string Copyright
        {
            get
            {
                return this._copyright;
            }
            set
            {
                this._copyright = value;
            }
        }
        /// <summary>Backing field for <see cref="Disc" /> property.</summary>
        private int? _disc;

        public int? Disc
        {
            get
            {
                return this._disc;
            }
            set
            {
                this._disc = value;
            }
        }
        /// <summary>Backing field for <see cref="DiscCount" /> property.</summary>
        private int? _discCount;

        public int? DiscCount
        {
            get
            {
                return this._discCount;
            }
            set
            {
                this._discCount = value;
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
        /// <summary>Backing field for <see cref="Genre" /> property.</summary>
        private string _genre;

        public string Genre
        {
            get
            {
                return this._genre;
            }
            set
            {
                this._genre = value;
            }
        }
        /// <summary>Backing field for <see cref="HasDrm" /> property.</summary>
        private bool? _hasDrm;

        public bool? HasDrm
        {
            get
            {
                return this._hasDrm;
            }
            set
            {
                this._hasDrm = value;
            }
        }
        /// <summary>Backing field for <see cref="IsVariableBitrate" /> property.</summary>
        private bool? _isVariableBitrate;

        public bool? IsVariableBitrate
        {
            get
            {
                return this._isVariableBitrate;
            }
            set
            {
                this._isVariableBitrate = value;
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
        /// <summary>Backing field for <see cref="Track" /> property.</summary>
        private int? _track;

        public int? Track
        {
            get
            {
                return this._track;
            }
            set
            {
                this._track = value;
            }
        }
        /// <summary>Backing field for <see cref="TrackCount" /> property.</summary>
        private int? _trackCount;

        public int? TrackCount
        {
            get
            {
                return this._trackCount;
            }
            set
            {
                this._trackCount = value;
            }
        }
        /// <summary>Backing field for <see cref="Year" /> property.</summary>
        private int? _year;

        public int? Year
        {
            get
            {
                return this._year;
            }
            set
            {
                this._year = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphAudio" /> instance.</summary>
        public MicrosoftGraphAudio()
        {
        }
    }
    /// audio
    public partial interface IMicrosoftGraphAudio : Sample.API.Runtime.IJsonSerializable {
        string Album { get; set; }
        string AlbumArtist { get; set; }
        string Artist { get; set; }
        long? Bitrate { get; set; }
        string Composers { get; set; }
        string Copyright { get; set; }
        int? Disc { get; set; }
        int? DiscCount { get; set; }
        long? Duration { get; set; }
        string Genre { get; set; }
        bool? HasDrm { get; set; }
        bool? IsVariableBitrate { get; set; }
        string Title { get; set; }
        int? Track { get; set; }
        int? TrackCount { get; set; }
        int? Year { get; set; }
    }
}