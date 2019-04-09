namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workingHours</summary>
    public partial class MicrosoftGraphWorkingHours : Sample.API.Models.IMicrosoftGraphWorkingHours
    {
        /// <summary>Backing field for <see cref="DaysOfWeek" /> property.</summary>
        private string[] _daysOfWeek;

        public string[] DaysOfWeek
        {
            get
            {
                return this._daysOfWeek;
            }
            set
            {
                this._daysOfWeek = value;
            }
        }
        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private string _endTime;

        public string EndTime
        {
            get
            {
                return this._endTime;
            }
            set
            {
                this._endTime = value;
            }
        }
        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        public string StartTime
        {
            get
            {
                return this._startTime;
            }
            set
            {
                this._startTime = value;
            }
        }
        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphTimeZoneBase _timeZone;

        /// <summary>timeZoneBase</summary>
        public Sample.API.Models.IMicrosoftGraphTimeZoneBase TimeZone
        {
            get
            {
                return this._timeZone;
            }
            set
            {
                this._timeZone = value;
            }
        }
        public string TimeZoneName
        {
            get
            {
                return /*1*/TimeZone/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/TimeZone/*4*/.Name/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkingHours" /> instance.</summary>
        public MicrosoftGraphWorkingHours()
        {
        }
    }
    /// workingHours
    public partial interface IMicrosoftGraphWorkingHours : Sample.API.Runtime.IJsonSerializable {
        string[] DaysOfWeek { get; set; }
        string EndTime { get; set; }
        string StartTime { get; set; }
        Sample.API.Models.IMicrosoftGraphTimeZoneBase TimeZone { get; set; }
        string TimeZoneName { get; set; }
    }
}