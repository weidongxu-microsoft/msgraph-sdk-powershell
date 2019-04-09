namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>columnDefinition</summary>
    public partial class ComponentsSchemasMicrosoftGraphColumndefinitionAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphColumndefinitionAllof1
    {
        /// <summary>Backing field for <see cref="Boolean" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphBooleanColumn _boolean;

        /// <summary>booleanColumn</summary>
        public Sample.API.Models.IMicrosoftGraphBooleanColumn Boolean
        {
            get
            {
                return this._boolean;
            }
            set
            {
                this._boolean = value;
            }
        }
        /// <summary>Backing field for <see cref="Calculated" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphCalculatedColumn _calculated;

        /// <summary>calculatedColumn</summary>
        public Sample.API.Models.IMicrosoftGraphCalculatedColumn Calculated
        {
            get
            {
                return this._calculated;
            }
            set
            {
                this._calculated = value;
            }
        }
        public string CalculatedFormat
        {
            get
            {
                return /*1*/Calculated/*4*/.Format/*3*/;
            }
            set
            {
                /*1*/Calculated/*4*/.Format/*3*/ = value;
            }
        }
        public string CalculatedFormula
        {
            get
            {
                return /*1*/Calculated/*4*/.Formula/*3*/;
            }
            set
            {
                /*1*/Calculated/*4*/.Formula/*3*/ = value;
            }
        }
        public string CalculatedOutputType
        {
            get
            {
                return /*1*/Calculated/*4*/.OutputType/*3*/;
            }
            set
            {
                /*1*/Calculated/*4*/.OutputType/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Choice" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphChoiceColumn _choice;

        /// <summary>choiceColumn</summary>
        public Sample.API.Models.IMicrosoftGraphChoiceColumn Choice
        {
            get
            {
                return this._choice;
            }
            set
            {
                this._choice = value;
            }
        }
        public bool? ChoiceAllowTextEntry
        {
            get
            {
                return /*1*/Choice/*4*/.AllowTextEntry/*3*/;
            }
            set
            {
                /*1*/Choice/*4*/.AllowTextEntry/*3*/ = value;
            }
        }
        public string[] ChoiceChoices
        {
            get
            {
                return /*1*/Choice/*4*/.Choices/*3*/;
            }
            set
            {
                /*1*/Choice/*4*/.Choices/*3*/ = value;
            }
        }
        public string ChoiceDisplayAs
        {
            get
            {
                return /*1*/Choice/*4*/.DisplayAs/*3*/;
            }
            set
            {
                /*1*/Choice/*4*/.DisplayAs/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ColumnGroup" /> property.</summary>
        private string _columnGroup;

        public string ColumnGroup
        {
            get
            {
                return this._columnGroup;
            }
            set
            {
                this._columnGroup = value;
            }
        }
        /// <summary>Backing field for <see cref="Currency" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphCurrencyColumn _currency;

        /// <summary>currencyColumn</summary>
        public Sample.API.Models.IMicrosoftGraphCurrencyColumn Currency
        {
            get
            {
                return this._currency;
            }
            set
            {
                this._currency = value;
            }
        }
        public string CurrencyLocale
        {
            get
            {
                return /*1*/Currency/*4*/.Locale/*3*/;
            }
            set
            {
                /*1*/Currency/*4*/.Locale/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="DateTime" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeColumn _dateTime;

        /// <summary>dateTimeColumn</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeColumn DateTime
        {
            get
            {
                return this._dateTime;
            }
            set
            {
                this._dateTime = value;
            }
        }
        public string DateTimeDisplayAs
        {
            get
            {
                return /*1*/DateTime/*4*/.DisplayAs/*3*/;
            }
            set
            {
                /*1*/DateTime/*4*/.DisplayAs/*3*/ = value;
            }
        }
        public string DateTimeFormat
        {
            get
            {
                return /*1*/DateTime/*4*/.Format/*3*/;
            }
            set
            {
                /*1*/DateTime/*4*/.Format/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="DefaultValue" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDefaultColumnValue _defaultValue;

        /// <summary>defaultColumnValue</summary>
        public Sample.API.Models.IMicrosoftGraphDefaultColumnValue DefaultValue
        {
            get
            {
                return this._defaultValue;
            }
            set
            {
                this._defaultValue = value;
            }
        }
        public string DefaultValueFormula
        {
            get
            {
                return /*1*/DefaultValue/*4*/.Formula/*3*/;
            }
            set
            {
                /*1*/DefaultValue/*4*/.Formula/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
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
        /// <summary>Backing field for <see cref="EnforceUniqueValues" /> property.</summary>
        private bool? _enforceUniqueValues;

        public bool? EnforceUniqueValues
        {
            get
            {
                return this._enforceUniqueValues;
            }
            set
            {
                this._enforceUniqueValues = value;
            }
        }
        /// <summary>Backing field for <see cref="Hidden" /> property.</summary>
        private bool? _hidden;

        public bool? Hidden
        {
            get
            {
                return this._hidden;
            }
            set
            {
                this._hidden = value;
            }
        }
        /// <summary>Backing field for <see cref="Indexed" /> property.</summary>
        private bool? _indexed;

        public bool? Indexed
        {
            get
            {
                return this._indexed;
            }
            set
            {
                this._indexed = value;
            }
        }
        /// <summary>Backing field for <see cref="Lookup" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphLookupColumn _lookup;

        /// <summary>lookupColumn</summary>
        public Sample.API.Models.IMicrosoftGraphLookupColumn Lookup
        {
            get
            {
                return this._lookup;
            }
            set
            {
                this._lookup = value;
            }
        }
        public bool? LookupAllowMultipleValues
        {
            get
            {
                return /*1*/Lookup/*4*/.AllowMultipleValues/*3*/;
            }
            set
            {
                /*1*/Lookup/*4*/.AllowMultipleValues/*3*/ = value;
            }
        }
        public bool? LookupAllowUnlimitedLength
        {
            get
            {
                return /*1*/Lookup/*4*/.AllowUnlimitedLength/*3*/;
            }
            set
            {
                /*1*/Lookup/*4*/.AllowUnlimitedLength/*3*/ = value;
            }
        }
        public string LookupColumnName
        {
            get
            {
                return /*1*/Lookup/*4*/.ColumnName/*3*/;
            }
            set
            {
                /*1*/Lookup/*4*/.ColumnName/*3*/ = value;
            }
        }
        public string LookupListId
        {
            get
            {
                return /*1*/Lookup/*4*/.ListId/*3*/;
            }
            set
            {
                /*1*/Lookup/*4*/.ListId/*3*/ = value;
            }
        }
        public string LookupPrimaryLookupColumnId
        {
            get
            {
                return /*1*/Lookup/*4*/.PrimaryLookupColumnId/*3*/;
            }
            set
            {
                /*1*/Lookup/*4*/.PrimaryLookupColumnId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphNumberColumn _number;

        /// <summary>numberColumn</summary>
        public Sample.API.Models.IMicrosoftGraphNumberColumn Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
        public string NumberDecimalPlaces
        {
            get
            {
                return /*1*/Number/*4*/.DecimalPlaces/*3*/;
            }
            set
            {
                /*1*/Number/*4*/.DecimalPlaces/*3*/ = value;
            }
        }
        public string NumberDisplayAs
        {
            get
            {
                return /*1*/Number/*4*/.DisplayAs/*3*/;
            }
            set
            {
                /*1*/Number/*4*/.DisplayAs/*3*/ = value;
            }
        }
        public double? NumberMaximum
        {
            get
            {
                return /*1*/Number/*4*/.Maximum/*3*/;
            }
            set
            {
                /*1*/Number/*4*/.Maximum/*3*/ = value;
            }
        }
        public double? NumberMinimum
        {
            get
            {
                return /*1*/Number/*4*/.Minimum/*3*/;
            }
            set
            {
                /*1*/Number/*4*/.Minimum/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="PersonOrGroup" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPersonOrGroupColumn _personOrGroup;

        /// <summary>personOrGroupColumn</summary>
        public Sample.API.Models.IMicrosoftGraphPersonOrGroupColumn PersonOrGroup
        {
            get
            {
                return this._personOrGroup;
            }
            set
            {
                this._personOrGroup = value;
            }
        }
        public bool? PersonOrGroupAllowMultipleSelection
        {
            get
            {
                return /*1*/PersonOrGroup/*4*/.AllowMultipleSelection/*3*/;
            }
            set
            {
                /*1*/PersonOrGroup/*4*/.AllowMultipleSelection/*3*/ = value;
            }
        }
        public string PersonOrGroupChooseFromType
        {
            get
            {
                return /*1*/PersonOrGroup/*4*/.ChooseFromType/*3*/;
            }
            set
            {
                /*1*/PersonOrGroup/*4*/.ChooseFromType/*3*/ = value;
            }
        }
        public string PersonOrGroupDisplayAs
        {
            get
            {
                return /*1*/PersonOrGroup/*4*/.DisplayAs/*3*/;
            }
            set
            {
                /*1*/PersonOrGroup/*4*/.DisplayAs/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        public bool? ReadOnly
        {
            get
            {
                return this._readOnly;
            }
            set
            {
                this._readOnly = value;
            }
        }
        /// <summary>Backing field for <see cref="Required" /> property.</summary>
        private bool? _required;

        public bool? Required
        {
            get
            {
                return this._required;
            }
            set
            {
                this._required = value;
            }
        }
        /// <summary>Backing field for <see cref="Text" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphTextColumn _text;

        /// <summary>textColumn</summary>
        public Sample.API.Models.IMicrosoftGraphTextColumn Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        public bool? TextAllowMultipleLines
        {
            get
            {
                return /*1*/Text/*4*/.AllowMultipleLines/*3*/;
            }
            set
            {
                /*1*/Text/*4*/.AllowMultipleLines/*3*/ = value;
            }
        }
        public bool? TextAppendChangesToExistingText
        {
            get
            {
                return /*1*/Text/*4*/.AppendChangesToExistingText/*3*/;
            }
            set
            {
                /*1*/Text/*4*/.AppendChangesToExistingText/*3*/ = value;
            }
        }
        public int? TextLinesForEditing
        {
            get
            {
                return /*1*/Text/*4*/.LinesForEditing/*3*/;
            }
            set
            {
                /*1*/Text/*4*/.LinesForEditing/*3*/ = value;
            }
        }
        public int? TextMaxLength
        {
            get
            {
                return /*1*/Text/*4*/.MaxLength/*3*/;
            }
            set
            {
                /*1*/Text/*4*/.MaxLength/*3*/ = value;
            }
        }
        public string TextType
        {
            get
            {
                return /*1*/Text/*4*/.TextType/*3*/;
            }
            set
            {
                /*1*/Text/*4*/.TextType/*3*/ = value;
            }
        }
        public string ValueDefaultValue
        {
            get
            {
                return /*1*/DefaultValue/*4*/.Value/*3*/;
            }
            set
            {
                /*1*/DefaultValue/*4*/.Value/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphColumndefinitionAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphColumndefinitionAllof1()
        {
        }
    }
    /// columnDefinition
    public partial interface IComponentsSchemasMicrosoftGraphColumndefinitionAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphBooleanColumn Boolean { get; set; }
        Sample.API.Models.IMicrosoftGraphCalculatedColumn Calculated { get; set; }
        string CalculatedFormat { get; set; }
        string CalculatedFormula { get; set; }
        string CalculatedOutputType { get; set; }
        Sample.API.Models.IMicrosoftGraphChoiceColumn Choice { get; set; }
        bool? ChoiceAllowTextEntry { get; set; }
        string[] ChoiceChoices { get; set; }
        string ChoiceDisplayAs { get; set; }
        string ColumnGroup { get; set; }
        Sample.API.Models.IMicrosoftGraphCurrencyColumn Currency { get; set; }
        string CurrencyLocale { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeColumn DateTime { get; set; }
        string DateTimeDisplayAs { get; set; }
        string DateTimeFormat { get; set; }
        Sample.API.Models.IMicrosoftGraphDefaultColumnValue DefaultValue { get; set; }
        string DefaultValueFormula { get; set; }
        string Description { get; set; }
        string DisplayName { get; set; }
        bool? EnforceUniqueValues { get; set; }
        bool? Hidden { get; set; }
        bool? Indexed { get; set; }
        Sample.API.Models.IMicrosoftGraphLookupColumn Lookup { get; set; }
        bool? LookupAllowMultipleValues { get; set; }
        bool? LookupAllowUnlimitedLength { get; set; }
        string LookupColumnName { get; set; }
        string LookupListId { get; set; }
        string LookupPrimaryLookupColumnId { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphNumberColumn Number { get; set; }
        string NumberDecimalPlaces { get; set; }
        string NumberDisplayAs { get; set; }
        double? NumberMaximum { get; set; }
        double? NumberMinimum { get; set; }
        Sample.API.Models.IMicrosoftGraphPersonOrGroupColumn PersonOrGroup { get; set; }
        bool? PersonOrGroupAllowMultipleSelection { get; set; }
        string PersonOrGroupChooseFromType { get; set; }
        string PersonOrGroupDisplayAs { get; set; }
        bool? ReadOnly { get; set; }
        bool? Required { get; set; }
        Sample.API.Models.IMicrosoftGraphTextColumn Text { get; set; }
        bool? TextAllowMultipleLines { get; set; }
        bool? TextAppendChangesToExistingText { get; set; }
        int? TextLinesForEditing { get; set; }
        int? TextMaxLength { get; set; }
        string TextType { get; set; }
        string ValueDefaultValue { get; set; }
    }
}