namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>plannerCategoryDescriptions</summary>
    public partial class MicrosoftGraphPlannerCategoryDescriptions : Sample.API.Models.IMicrosoftGraphPlannerCategoryDescriptions
    {
        /// <summary>Backing field for <see cref="Category1" /> property.</summary>
        private string _category1;

        public string Category1
        {
            get
            {
                return this._category1;
            }
            set
            {
                this._category1 = value;
            }
        }
        /// <summary>Backing field for <see cref="Category2" /> property.</summary>
        private string _category2;

        public string Category2
        {
            get
            {
                return this._category2;
            }
            set
            {
                this._category2 = value;
            }
        }
        /// <summary>Backing field for <see cref="Category3" /> property.</summary>
        private string _category3;

        public string Category3
        {
            get
            {
                return this._category3;
            }
            set
            {
                this._category3 = value;
            }
        }
        /// <summary>Backing field for <see cref="Category4" /> property.</summary>
        private string _category4;

        public string Category4
        {
            get
            {
                return this._category4;
            }
            set
            {
                this._category4 = value;
            }
        }
        /// <summary>Backing field for <see cref="Category5" /> property.</summary>
        private string _category5;

        public string Category5
        {
            get
            {
                return this._category5;
            }
            set
            {
                this._category5 = value;
            }
        }
        /// <summary>Backing field for <see cref="Category6" /> property.</summary>
        private string _category6;

        public string Category6
        {
            get
            {
                return this._category6;
            }
            set
            {
                this._category6 = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphPlannerCategoryDescriptions" /> instance.
        /// </summary>
        public MicrosoftGraphPlannerCategoryDescriptions()
        {
        }
    }
    /// plannerCategoryDescriptions
    public partial interface IMicrosoftGraphPlannerCategoryDescriptions : Sample.API.Runtime.IJsonSerializable {
        string Category1 { get; set; }
        string Category2 { get; set; }
        string Category3 { get; set; }
        string Category4 { get; set; }
        string Category5 { get; set; }
        string Category6 { get; set; }
    }
}