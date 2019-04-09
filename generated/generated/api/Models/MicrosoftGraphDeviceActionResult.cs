namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>deviceActionResult</summary>
    public partial class MicrosoftGraphDeviceActionResult : Sample.API.Models.IMicrosoftGraphDeviceActionResult
    {
        /// <summary>Backing field for <see cref="ActionName" /> property.</summary>
        private string _actionName;

        /// <summary>Action name</summary>
        public string ActionName
        {
            get
            {
                return this._actionName;
            }
            set
            {
                this._actionName = value;
            }
        }
        /// <summary>Backing field for <see cref="ActionState" /> property.</summary>
        private string _actionState;

        /// <summary>actionState</summary>
        public string ActionState
        {
            get
            {
                return this._actionState;
            }
            set
            {
                this._actionState = value;
            }
        }
        /// <summary>Backing field for <see cref="LastUpdatedDateTime" /> property.</summary>
        private System.DateTime? _lastUpdatedDateTime;

        /// <summary>Time the action state was last updated</summary>
        public System.DateTime? LastUpdatedDateTime
        {
            get
            {
                return this._lastUpdatedDateTime;
            }
            set
            {
                this._lastUpdatedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private System.DateTime? _startDateTime;

        /// <summary>Time the action was initiated</summary>
        public System.DateTime? StartDateTime
        {
            get
            {
                return this._startDateTime;
            }
            set
            {
                this._startDateTime = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDeviceActionResult" /> instance.</summary>
        public MicrosoftGraphDeviceActionResult()
        {
        }
    }
    /// deviceActionResult
    public partial interface IMicrosoftGraphDeviceActionResult : Sample.API.Runtime.IJsonSerializable {
        string ActionName { get; set; }
        string ActionState { get; set; }
        System.DateTime? LastUpdatedDateTime { get; set; }
        System.DateTime? StartDateTime { get; set; }
    }
}