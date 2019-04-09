namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>numberColumn</summary>
    public partial class MicrosoftGraphNumberColumn : Sample.API.Models.IMicrosoftGraphNumberColumn
    {
        /// <summary>Backing field for <see cref="DecimalPlaces" /> property.</summary>
        private string _decimalPlaces;

        public string DecimalPlaces
        {
            get
            {
                return this._decimalPlaces;
            }
            set
            {
                this._decimalPlaces = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayAs" /> property.</summary>
        private string _displayAs;

        public string DisplayAs
        {
            get
            {
                return this._displayAs;
            }
            set
            {
                this._displayAs = value;
            }
        }
        /// <summary>Backing field for <see cref="Maximum" /> property.</summary>
        private double? _maximum;

        public double? Maximum
        {
            get
            {
                return this._maximum;
            }
            set
            {
                this._maximum = value;
            }
        }
        /// <summary>Backing field for <see cref="Minimum" /> property.</summary>
        private double? _minimum;

        public double? Minimum
        {
            get
            {
                return this._minimum;
            }
            set
            {
                this._minimum = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphNumberColumn" /> instance.</summary>
        public MicrosoftGraphNumberColumn()
        {
        }
    }
    /// numberColumn
    public partial interface IMicrosoftGraphNumberColumn : Sample.API.Runtime.IJsonSerializable {
        string DecimalPlaces { get; set; }
        string DisplayAs { get; set; }
        double? Maximum { get; set; }
        double? Minimum { get; set; }
    }
}