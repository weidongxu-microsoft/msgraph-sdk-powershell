namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphWorkbookFilter : Sample.API.Models.IMicrosoftGraphWorkbookFilter, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookFilter" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookfilterAllof1 _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphWorkbookfilterAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphWorkbookFilter" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>workbookFilterCriteria</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookFilterCriteria Criteria
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .Criteria;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .Criteria = value;
            }
        }
        public string CriteriaColor
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaColor;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaColor = value;
            }
        }
        public string CriteriaCriterion1
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaCriterion1;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaCriterion1 = value;
            }
        }
        public string CriteriaCriterion2
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaCriterion2;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaCriterion2 = value;
            }
        }
        public string CriteriaDynamicCriteria
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaDynamicCriteria;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaDynamicCriteria = value;
            }
        }
        public string CriteriaFilterOn
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaFilterOn;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaFilterOn = value;
            }
        }
        /// <summary>workbookIcon</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookIcon CriteriaIcon
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaIcon;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaIcon = value;
            }
        }
        public string CriteriaOperator
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaOperator;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaOperator = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson CriteriaValues
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaValues;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .CriteriaValues = value;
            }
        }
        public int? IconIndex
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .IconIndex;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .IconIndex = value;
            }
        }
        public string IconSet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .IconSet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 .IconSet = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWorkbookFilter" /> instance.</summary>
        public MicrosoftGraphWorkbookFilter()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphWorkbookfilterAllof1 ), _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphWorkbookfilterAllof1 ), _componentsSchemasMicrosoftGraphWorkbookfilterAllof1 );
        }
    }
    public partial interface IMicrosoftGraphWorkbookFilter : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookfilterAllof1 {

    }
}