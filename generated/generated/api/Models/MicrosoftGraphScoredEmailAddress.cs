namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>scoredEmailAddress</summary>
    public partial class MicrosoftGraphScoredEmailAddress : Sample.API.Models.IMicrosoftGraphScoredEmailAddress
    {
        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private string _address;

        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        /// <summary>Backing field for <see cref="ItemId" /> property.</summary>
        private string _itemId;

        public string ItemId
        {
            get
            {
                return this._itemId;
            }
            set
            {
                this._itemId = value;
            }
        }
        /// <summary>Backing field for <see cref="RelevanceScore" /> property.</summary>
        private double? _relevanceScore;

        public double? RelevanceScore
        {
            get
            {
                return this._relevanceScore;
            }
            set
            {
                this._relevanceScore = value;
            }
        }
        /// <summary>Backing field for <see cref="SelectionLikelihood" /> property.</summary>
        private string _selectionLikelihood;

        /// <summary>selectionLikelihoodInfo</summary>
        public string SelectionLikelihood
        {
            get
            {
                return this._selectionLikelihood;
            }
            set
            {
                this._selectionLikelihood = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphScoredEmailAddress" /> instance.</summary>
        public MicrosoftGraphScoredEmailAddress()
        {
        }
    }
    /// scoredEmailAddress
    public partial interface IMicrosoftGraphScoredEmailAddress : Sample.API.Runtime.IJsonSerializable {
        string Address { get; set; }
        string ItemId { get; set; }
        double? RelevanceScore { get; set; }
        string SelectionLikelihood { get; set; }
    }
}