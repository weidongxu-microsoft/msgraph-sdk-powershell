namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookFilterCriteria</summary>
    public partial class MicrosoftGraphWorkbookFilterCriteria : Sample.API.Models.IMicrosoftGraphWorkbookFilterCriteria
    {
        /// <summary>Backing field for <see cref="Color" /> property.</summary>
        private string _color;

        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        /// <summary>Backing field for <see cref="Criterion1" /> property.</summary>
        private string _criterion1;

        public string Criterion1
        {
            get
            {
                return this._criterion1;
            }
            set
            {
                this._criterion1 = value;
            }
        }
        /// <summary>Backing field for <see cref="Criterion2" /> property.</summary>
        private string _criterion2;

        public string Criterion2
        {
            get
            {
                return this._criterion2;
            }
            set
            {
                this._criterion2 = value;
            }
        }
        /// <summary>Backing field for <see cref="DynamicCriteria" /> property.</summary>
        private string _dynamicCriteria;

        public string DynamicCriteria
        {
            get
            {
                return this._dynamicCriteria;
            }
            set
            {
                this._dynamicCriteria = value;
            }
        }
        /// <summary>Backing field for <see cref="FilterOn" /> property.</summary>
        private string _filterOn;

        public string FilterOn
        {
            get
            {
                return this._filterOn;
            }
            set
            {
                this._filterOn = value;
            }
        }
        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookIcon _icon;

        /// <summary>workbookIcon</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookIcon Icon
        {
            get
            {
                return this._icon;
            }
            set
            {
                this._icon = value;
            }
        }
        public int? IconIndex
        {
            get
            {
                return /*1*/Icon/*4*/.Index/*3*/;
            }
            set
            {
                /*1*/Icon/*4*/.Index/*3*/ = value;
            }
        }
        public string IconSet
        {
            get
            {
                return /*1*/Icon/*4*/.Set/*3*/;
            }
            set
            {
                /*1*/Icon/*4*/.Set/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Operator" /> property.</summary>
        private string _operator;

        public string Operator
        {
            get
            {
                return this._operator;
            }
            set
            {
                this._operator = value;
            }
        }
        /// <summary>Backing field for <see cref="Values" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _values;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Values
        {
            get
            {
                return this._values;
            }
            set
            {
                this._values = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookFilterCriteria" /> instance.</summary>
        public MicrosoftGraphWorkbookFilterCriteria()
        {
        }
    }
    /// workbookFilterCriteria
    public partial interface IMicrosoftGraphWorkbookFilterCriteria : Sample.API.Runtime.IJsonSerializable {
        string Color { get; set; }
        string Criterion1 { get; set; }
        string Criterion2 { get; set; }
        string DynamicCriteria { get; set; }
        string FilterOn { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookIcon Icon { get; set; }
        int? IconIndex { get; set; }
        string IconSet { get; set; }
        string Operator { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Values { get; set; }
    }
}