// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionUpdate : StripeEntity<ConfigurationFeaturesSubscriptionUpdate>
    {
        /// <summary>
        /// The types of subscription updates that are supported for items listed in the
        /// <c>products</c> attribute. When empty, subscriptions are not updateable.
        /// One of: <c>price</c>, <c>promotion_code</c>, or <c>quantity</c>.
        /// </summary>
        [JsonProperty("default_allowed_updates")]
        public List<string> DefaultAllowedUpdates { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The list of up to 10 products that support subscription updates.
        /// </summary>
        [JsonProperty("products")]
        public List<ConfigurationFeaturesSubscriptionUpdateProduct> Products { get; set; }

        /// <summary>
        /// Determines how to handle prorations resulting from subscription updates. Valid values
        /// are <c>none</c>, <c>create_prorations</c>, and <c>always_invoice</c>. Defaults to a
        /// value of <c>none</c> if you don't set it during creation.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("schedule_at_period_end")]
        public ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd ScheduleAtPeriodEnd { get; set; }
    }
}
