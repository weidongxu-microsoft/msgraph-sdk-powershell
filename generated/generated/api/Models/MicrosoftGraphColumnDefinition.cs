namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphColumnDefinition : Sample.API.Models.IMicrosoftGraphColumnDefinition, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphColumnDefinition" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphColumndefinitionAllof1 _componentsSchemasMicrosoftGraphColumndefinitionAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphColumndefinitionAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphColumnDefinition" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>booleanColumn</summary>
        public Sample.API.Models.IMicrosoftGraphBooleanColumn Boolean
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Boolean;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Boolean = value;
            }
        }
        /// <summary>calculatedColumn</summary>
        public Sample.API.Models.IMicrosoftGraphCalculatedColumn Calculated
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Calculated;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Calculated = value;
            }
        }
        public string CalculatedFormat
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CalculatedFormat;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CalculatedFormat = value;
            }
        }
        public string CalculatedFormula
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CalculatedFormula;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CalculatedFormula = value;
            }
        }
        public string CalculatedOutputType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CalculatedOutputType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CalculatedOutputType = value;
            }
        }
        /// <summary>choiceColumn</summary>
        public Sample.API.Models.IMicrosoftGraphChoiceColumn Choice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Choice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Choice = value;
            }
        }
        public bool? ChoiceAllowTextEntry
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ChoiceAllowTextEntry;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ChoiceAllowTextEntry = value;
            }
        }
        public string[] ChoiceChoices
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ChoiceChoices;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ChoiceChoices = value;
            }
        }
        public string ChoiceDisplayAs
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ChoiceDisplayAs;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ChoiceDisplayAs = value;
            }
        }
        public string ColumnGroup
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ColumnGroup;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ColumnGroup = value;
            }
        }
        /// <summary>currencyColumn</summary>
        public Sample.API.Models.IMicrosoftGraphCurrencyColumn Currency
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Currency;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Currency = value;
            }
        }
        public string CurrencyLocale
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CurrencyLocale;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .CurrencyLocale = value;
            }
        }
        /// <summary>dateTimeColumn</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeColumn DateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DateTime = value;
            }
        }
        public string DateTimeDisplayAs
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DateTimeDisplayAs;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DateTimeDisplayAs = value;
            }
        }
        public string DateTimeFormat
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DateTimeFormat;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DateTimeFormat = value;
            }
        }
        /// <summary>defaultColumnValue</summary>
        public Sample.API.Models.IMicrosoftGraphDefaultColumnValue DefaultValue
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DefaultValue;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DefaultValue = value;
            }
        }
        public string DefaultValueFormula
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DefaultValueFormula;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DefaultValueFormula = value;
            }
        }
        public string Description
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Description;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Description = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .DisplayName = value;
            }
        }
        public bool? EnforceUniqueValues
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .EnforceUniqueValues;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .EnforceUniqueValues = value;
            }
        }
        public bool? Hidden
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Hidden;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Hidden = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        public bool? Indexed
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Indexed;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Indexed = value;
            }
        }
        /// <summary>lookupColumn</summary>
        public Sample.API.Models.IMicrosoftGraphLookupColumn Lookup
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Lookup;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Lookup = value;
            }
        }
        public bool? LookupAllowMultipleValues
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupAllowMultipleValues;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupAllowMultipleValues = value;
            }
        }
        public bool? LookupAllowUnlimitedLength
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupAllowUnlimitedLength;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupAllowUnlimitedLength = value;
            }
        }
        public string LookupColumnName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupColumnName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupColumnName = value;
            }
        }
        public string LookupListId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupListId = value;
            }
        }
        public string LookupPrimaryLookupColumnId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupPrimaryLookupColumnId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .LookupPrimaryLookupColumnId = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Name = value;
            }
        }
        /// <summary>numberColumn</summary>
        public Sample.API.Models.IMicrosoftGraphNumberColumn Number
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Number;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Number = value;
            }
        }
        public string NumberDecimalPlaces
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberDecimalPlaces;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberDecimalPlaces = value;
            }
        }
        public string NumberDisplayAs
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberDisplayAs;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberDisplayAs = value;
            }
        }
        public double? NumberMaximum
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberMaximum;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberMaximum = value;
            }
        }
        public double? NumberMinimum
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberMinimum;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .NumberMinimum = value;
            }
        }
        /// <summary>personOrGroupColumn</summary>
        public Sample.API.Models.IMicrosoftGraphPersonOrGroupColumn PersonOrGroup
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroup;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroup = value;
            }
        }
        public bool? PersonOrGroupAllowMultipleSelection
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroupAllowMultipleSelection;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroupAllowMultipleSelection = value;
            }
        }
        public string PersonOrGroupChooseFromType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroupChooseFromType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroupChooseFromType = value;
            }
        }
        public string PersonOrGroupDisplayAs
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroupDisplayAs;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .PersonOrGroupDisplayAs = value;
            }
        }
        public bool? ReadOnly
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ReadOnly;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ReadOnly = value;
            }
        }
        public bool? Required
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Required;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Required = value;
            }
        }
        /// <summary>textColumn</summary>
        public Sample.API.Models.IMicrosoftGraphTextColumn Text
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Text;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .Text = value;
            }
        }
        public bool? TextAllowMultipleLines
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextAllowMultipleLines;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextAllowMultipleLines = value;
            }
        }
        public bool? TextAppendChangesToExistingText
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextAppendChangesToExistingText;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextAppendChangesToExistingText = value;
            }
        }
        public int? TextLinesForEditing
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextLinesForEditing;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextLinesForEditing = value;
            }
        }
        public int? TextMaxLength
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextMaxLength;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextMaxLength = value;
            }
        }
        public string TextType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .TextType = value;
            }
        }
        public string ValueDefaultValue
        {
            get
            {
                return _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ValueDefaultValue;
            }
            set
            {
                _componentsSchemasMicrosoftGraphColumndefinitionAllof1 .ValueDefaultValue = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphColumnDefinition" /> instance.</summary>
        public MicrosoftGraphColumnDefinition()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphColumndefinitionAllof1 ), _componentsSchemasMicrosoftGraphColumndefinitionAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphColumndefinitionAllof1 ), _componentsSchemasMicrosoftGraphColumndefinitionAllof1 );
        }
    }
    public partial interface IMicrosoftGraphColumnDefinition : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphColumndefinitionAllof1 {

    }
}