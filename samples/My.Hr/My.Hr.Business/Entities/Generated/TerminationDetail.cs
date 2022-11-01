/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace My.Hr.Business.Entities
{
    /// <summary>
    /// Represents the Termination Detail entity.
    /// </summary>
    public partial class TerminationDetail : EntityBase
    {
        private DateTime _date;
        private string? _reasonSid;
        private string? _reasonText;

        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        public DateTime Date { get => _date; set => SetValue(ref _date, value, transform: DateTimeTransform.DateOnly); }

        /// <summary>
        /// Gets or sets the <see cref="Reason"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonPropertyName("reason")]
        public string? ReasonSid { get => _reasonSid; set => SetValue(ref _reasonSid, value); }

        /// <summary>
        /// Gets the corresponding <see cref="Reason"/> text (read-only where selected).
        /// </summary>
        public string? ReasonText => RefDataNamespace.TerminationReason.GetRefDataText(_reasonSid); 

        /// <summary>
        /// Gets or sets the Reason (see <see cref="RefDataNamespace.TerminationReason"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonIgnore]
        public RefDataNamespace.TerminationReason? Reason { get => _reasonSid; set => SetValue(ref _reasonSid, value); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(Date), Date, v => Date = v);
            yield return CreateProperty(nameof(ReasonSid), ReasonSid, v => ReasonSid = v);
        }
    }
}

#pragma warning restore
#nullable restore