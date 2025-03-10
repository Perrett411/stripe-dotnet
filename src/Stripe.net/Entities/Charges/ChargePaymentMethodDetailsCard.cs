// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCard : StripeEntity<ChargePaymentMethodDetailsCard>
    {
        /// <summary>
        /// The authorized amount.
        /// </summary>
        [JsonProperty("amount_authorized")]
        public long? AmountAuthorized { get; set; }

        /// <summary>
        /// Authorization code on the charge.
        /// </summary>
        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// When using manual capture, a future timestamp at which the charge will be automatically
        /// refunded if uncaptured.
        /// </summary>
        [JsonProperty("capture_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Check results by Card networks on Card address and CVC at time of payment.
        /// </summary>
        [JsonProperty("checks")]
        public ChargePaymentMethodDetailsCardChecks Checks { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// A high-level description of the type of cards issued in this range. (For internal use
        /// only and not typically available in standard API requests.).
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("extended_authorization")]
        public ChargePaymentMethodDetailsCardExtendedAuthorization ExtendedAuthorization { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check
        /// whether two customers who’ve signed up with you are using the same card number, for
        /// example. For payment methods that tokenize card information (Apple Pay, Google Pay), the
        /// tokenized number might be provided instead of the underlying card number.
        ///
        /// <em>As of May 1, 2021, card fingerprint in India for Connect changed to allow two
        /// fingerprints for the same card---one for India and one for the rest of the world.</em>.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Card funding type. Can be <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// Issuer identification number of the card. (For internal use only and not typically
        /// available in standard API requests.).
        /// </summary>
        [JsonProperty("iin")]
        public string Iin { get; set; }

        [JsonProperty("incremental_authorization")]
        public ChargePaymentMethodDetailsCardIncrementalAuthorization IncrementalAuthorization { get; set; }

        /// <summary>
        /// Installment details for this payment (Mexico only).
        ///
        /// For more information, see the <a
        /// href="https://stripe.com/docs/payments/installments">installments integration guide</a>.
        /// </summary>
        [JsonProperty("installments")]
        public ChargePaymentMethodDetailsCardInstallments Installments { get; set; }

        /// <summary>
        /// The name of the card's issuing bank. (For internal use only and not typically available
        /// in standard API requests.).
        /// </summary>
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the mandate used to make this payment or created by it.
        /// </summary>
        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        /// <summary>
        /// True if this payment was marked as MOTO and out of scope for SCA.
        /// </summary>
        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        [JsonProperty("multicapture")]
        public ChargePaymentMethodDetailsCardMulticapture Multicapture { get; set; }

        /// <summary>
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>interac</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// If this card has network token credentials, this contains the details of the network
        /// token credentials.
        /// </summary>
        [JsonProperty("network_token")]
        public ChargePaymentMethodDetailsCardNetworkToken NetworkToken { get; set; }

        /// <summary>
        /// This is used by the financial networks to identify a transaction. Visa calls this the
        /// Transaction ID, Mastercard calls this the Trace ID, and American Express calls this the
        /// Acquirer Reference Data. This value will be present if it is returned by the financial
        /// network in the authorization response, and null otherwise.
        /// </summary>
        [JsonProperty("network_transaction_id")]
        public string NetworkTransactionId { get; set; }

        [JsonProperty("overcapture")]
        public ChargePaymentMethodDetailsCardOvercapture Overcapture { get; set; }

        /// <summary>
        /// Status of a card based on the card issuer.
        /// One of: <c>regulated</c>, or <c>unregulated</c>.
        /// </summary>
        [JsonProperty("regulated_status")]
        public string RegulatedStatus { get; set; }

        /// <summary>
        /// Populated if this transaction used 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public ChargePaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
        public ChargePaymentMethodDetailsCardWallet Wallet { get; set; }
    }
}
