/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Cdr.Banking.Business.Entities
{
    /// <summary>
    /// Represents the Credit Card Account entity.
    /// </summary>
    public partial class CreditCardAccount : EntityBase
    {
        private decimal _minPaymentAmount;
        private decimal _paymentDueAmount;
        private string? _paymentCurrency;
        private DateTime _paymentDueDate;

        /// <summary>
        /// Gets or sets the Min Payment Amount.
        /// </summary>
        public decimal MinPaymentAmount { get => _minPaymentAmount; set => SetValue(ref _minPaymentAmount, value); }

        /// <summary>
        /// Gets or sets the Payment Due Amount.
        /// </summary>
        public decimal PaymentDueAmount { get => _paymentDueAmount; set => SetValue(ref _paymentDueAmount, value); }

        /// <summary>
        /// Gets or sets the Payment Currency.
        /// </summary>
        public string? PaymentCurrency { get => _paymentCurrency; set => SetValue(ref _paymentCurrency, value); }

        /// <summary>
        /// Gets or sets the Payment Due Date.
        /// </summary>
        public DateTime PaymentDueDate { get => _paymentDueDate; set => SetValue(ref _paymentDueDate, value, transform: DateTimeTransform.DateOnly); }

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(MinPaymentAmount), MinPaymentAmount, v => MinPaymentAmount = v);
            yield return CreateProperty(nameof(PaymentDueAmount), PaymentDueAmount, v => PaymentDueAmount = v);
            yield return CreateProperty(nameof(PaymentCurrency), PaymentCurrency, v => PaymentCurrency = v);
            yield return CreateProperty(nameof(PaymentDueDate), PaymentDueDate, v => PaymentDueDate = v);
        }
    }
}

#pragma warning restore
#nullable restore