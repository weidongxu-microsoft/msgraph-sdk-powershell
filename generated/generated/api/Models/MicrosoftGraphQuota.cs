namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>quota</summary>
    public partial class MicrosoftGraphQuota : Sample.API.Models.IMicrosoftGraphQuota
    {
        /// <summary>Backing field for <see cref="Deleted" /> property.</summary>
        private long? _deleted;

        public long? Deleted
        {
            get
            {
                return this._deleted;
            }
            set
            {
                this._deleted = value;
            }
        }
        /// <summary>Backing field for <see cref="Remaining" /> property.</summary>
        private long? _remaining;

        public long? Remaining
        {
            get
            {
                return this._remaining;
            }
            set
            {
                this._remaining = value;
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
        /// <summary>Backing field for <see cref="Total" /> property.</summary>
        private long? _total;

        public long? Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        /// <summary>Backing field for <see cref="Used" /> property.</summary>
        private long? _used;

        public long? Used
        {
            get
            {
                return this._used;
            }
            set
            {
                this._used = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphQuota" /> instance.</summary>
        public MicrosoftGraphQuota()
        {
        }
    }
    /// quota
    public partial interface IMicrosoftGraphQuota : Sample.API.Runtime.IJsonSerializable {
        long? Deleted { get; set; }
        long? Remaining { get; set; }
        string State { get; set; }
        long? Total { get; set; }
        long? Used { get; set; }
    }
}