namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>workbookFilter</summary>
    public partial class ComponentsSchemasMicrosoftGraphWorkbookfilterAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphWorkbookfilterAllof1
    {
        /// <summary>Backing field for <see cref="Criteria" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbookFilterCriteria _criteria;

        /// <summary>workbookFilterCriteria</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookFilterCriteria Criteria
        {
            get
            {
                return this._criteria;
            }
            set
            {
                this._criteria = value;
            }
        }
        public string CriteriaColor
        {
            get
            {
                return /*1*/Criteria/*4*/.Color/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.Color/*3*/ = value;
            }
        }
        public string CriteriaCriterion1
        {
            get
            {
                return /*1*/Criteria/*4*/.Criterion1/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.Criterion1/*3*/ = value;
            }
        }
        public string CriteriaCriterion2
        {
            get
            {
                return /*1*/Criteria/*4*/.Criterion2/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.Criterion2/*3*/ = value;
            }
        }
        public string CriteriaDynamicCriteria
        {
            get
            {
                return /*1*/Criteria/*4*/.DynamicCriteria/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.DynamicCriteria/*3*/ = value;
            }
        }
        public string CriteriaFilterOn
        {
            get
            {
                return /*1*/Criteria/*4*/.FilterOn/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.FilterOn/*3*/ = value;
            }
        }
        /// <summary>workbookIcon</summary>
        public Sample.API.Models.IMicrosoftGraphWorkbookIcon CriteriaIcon
        {
            get
            {
                return /*1*/Criteria/*4*/.Icon/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.Icon/*3*/ = value;
            }
        }
        public string CriteriaOperator
        {
            get
            {
                return /*1*/Criteria/*4*/.Operator/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.Operator/*3*/ = value;
            }
        }
        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson CriteriaValues
        {
            get
            {
                return /*1*/Criteria/*4*/.Values/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.Values/*3*/ = value;
            }
        }
        public int? IconIndex
        {
            get
            {
                return /*1*/Criteria/*4*/.IconIndex/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.IconIndex/*3*/ = value;
            }
        }
        public string IconSet
        {
            get
            {
                return /*1*/Criteria/*4*/.IconSet/*3*/;
            }
            set
            {
                /*1*/Criteria/*4*/.IconSet/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphWorkbookfilterAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphWorkbookfilterAllof1()
        {
        }
    }
    /// workbookFilter
    public partial interface IComponentsSchemasMicrosoftGraphWorkbookfilterAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphWorkbookFilterCriteria Criteria { get; set; }
        string CriteriaColor { get; set; }
        string CriteriaCriterion1 { get; set; }
        string CriteriaCriterion2 { get; set; }
        string CriteriaDynamicCriteria { get; set; }
        string CriteriaFilterOn { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbookIcon CriteriaIcon { get; set; }
        string CriteriaOperator { get; set; }
        Sample.API.Models.IMicrosoftGraphJson CriteriaValues { get; set; }
        int? IconIndex { get; set; }
        string IconSet { get; set; }
    }
}