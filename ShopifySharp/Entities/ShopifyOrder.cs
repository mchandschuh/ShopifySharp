﻿using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify order.
    /// </summary>
    public class ShopifyOrder : ShopifyObject
    {
        /// <summary>
        /// The mailing address associated with the payment method. This address is an optional field that will not be available on orders that do not require one. 
        /// </summary>
        [JsonProperty("billing_address")]
        public ShopifyAddress BillingAddress { get; set; }

        /// <summary>
        /// The IP address of the browser used by the customer when placing the order.
        /// </summary>
        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        /// <summary>
        /// Indicates whether or not the person who placed the order would like to receive email updates from the shop. 
        /// This is set when checking the "I want to receive occasional emails about new products, promotions and other news" checkbox during checkout.
        /// </summary>
        [JsonProperty("buyer_accepts_marketing")]
        public bool BuyerAcceptsMarketing { get; set; }

        /// <summary>
        /// The reason why the order was cancelled. If the order was not cancelled, this value is null. Known values are "customer", "fraud", "inventory" and "other".
        /// </summary>
        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// The date and time when the order was cancelled. If the order was not cancelled, this value is null.
        /// </summary>
        [JsonProperty("cancelled_at")]
        public DateTime? CancelledAt { get; set; }

        /// <summary>
        /// Unique identifier for a particular cart that is attached to a particular order.
        /// </summary>
        [JsonProperty("cart_token")]
        public string CartToken { get; set; }

        /// <summary>
        /// A <see cref="ShopifyClientDetails"/> object containing information about the client.
        /// </summary>
        [JsonProperty("client_details")]
        public ShopifyClientDetails ClientDetails { get; set; }

        /// <summary>
        /// The date and time when the order was closed. If the order was not clsoed, this value is null.
        /// </summary>
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        /// <summary>
        /// The customer's contact email address.
        /// </summary>
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// The date and time when the order was created in Shopify.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The three letter code (ISO 4217) for the currency used for the payment.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A <see cref="ShopifyCustomer"/> object containing information about the customer. This value may be null if the order was created through Shopify POS.
        /// </summary>
        [JsonProperty("customer")]
        public ShopifyCustomer Customer { get; set; }

        /// <summary>
        /// Applicable discount codes that can be applied to the order.
        /// </summary>
        [JsonProperty("discount_codes")]
        public IEnumerable<ShopifyDiscountCode> DiscountCodes { get; set; }

        /// <summary>
        /// The order's email address. Note: On and after 2015-11-03, you should be using <see cref="ContactEmail"/> to refer to the customer's email address. 
        /// Between 2015-11-03 and 2015-12-03, updates to an order's email will also update the customer's email. This is temporary so apps can be migrated over to 
        /// doing customer updates rather than order updates to change the contact email. After 2015-12-03, updating updating an order's email will no longer update 
        /// the customer's email and apps will have to use the customer update endpoint to do so.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The financial status of an order. Known values are "authorized", "paid", "pending", "partially_paid", "partially_refunded", "refunded" and "voided".
        /// </summary>
        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        /// <summary>
        /// An array of <see cref="ShopifyFulfillment"/> objects for this order.
        /// </summary>
        [JsonProperty("fulfillments")]
        public IEnumerable<ShopifyFulfillment> Fulfillments { get; set; }

        /// <summary>
        /// The fulfillment status for this order. Known values are 'fulfilled', 'null' and 'partial'.
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// Tags are additional short descriptors, commonly used for filtering and searching, formatted as a string of comma-separated values.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// The URL for the page where the buyer landed when entering the shop.
        /// </summary>
        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        /// <summary>
        /// An array of <see cref="ShopifyLineItem"/> objects, each one containing information about an item in the order.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<ShopifyLineItem> LineItems { get; set; }

        /// <summary>
        /// The customer's order name as represented by a number, e.g. '#1001'.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The text of an optional note that a shop owner can attach to the order.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Extra information that is added to the order.
        /// </summary>
        [JsonProperty("note_attributes")]
        public IEnumerable<ShopifyNoteAttribute> NoteAttributes { get; set; }

        /// <summary>
        /// Numerical identifier unique to the shop. A number is sequential and starts at 1000.
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// A unique numeric identifier for the order. This one is used by the shop owner and customer. 
        /// This is different from the id property, which is also a unique numeric identifier for the order, but used for API purposes.
        /// </summary>
        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }

        /// <summary>
        /// Payment details for this order. May be null if the order was created via API without payment details.
        /// </summary>
        [JsonProperty("payment_details")]
        public ShopifyPaymentDetails PaymentDetails { get; set; }

        /// <summary>
        /// The date that the order was processed at.
        /// </summary>
        [JsonProperty("processed_at")]
        public DateTime? ProcessedAt { get; set; }

        /// <summary>
        /// The type of payment processing method. Known values are 'checkout', 'direct', 'manual', 'offsite', 'express', 'free' and 'none'.
        /// </summary>
        [JsonProperty("processing_method")]
        public string ProcessingMethod { get; set; }

        /// <summary>
        /// The website that the customer clicked on to come to the shop.
        /// </summary>
        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }

        /// <summary>
        /// The mailing address to where the order will be shipped. This address is optional and will not be available on orders that do not require one.
        /// </summary>
        [JsonProperty("shipping_address")]
        public ShopifyAddress ShippingAddress { get; set; }

        /// <summary>
        /// An array of <see cref="ShopifyShippingLine"/> objects, each of which details the shipping methods used.
        /// </summary>
        [JsonProperty("shipping_lines")]
        public IEnumerable<ShopifyShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// Where the order originated. May only be set during creation, and is not writeable thereafter.
        /// Orders created via the API may be assigned any string of your choice except for "web", "pos", "iphone", and "android". 
        /// Default is "api".
        /// </summary>
        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// Price of the order before shipping and taxes
        /// </summary>
        [JsonProperty("subtotal_price")]
        public double SubtotalPrice { get; set; }

        /// <summary>
        /// An array of <see cref="ShopifyTaxLine"/> objects, each of which details the total taxes applicable to the order.
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<ShopifyTaxLine> TaxLines { get; set; }

        /// <summary>
        /// States whether or not taxes are included in the order subtotal. 
        /// </summary>
        [JsonProperty("taxes_included")]
        public bool TaxesIncluded { get; set; }

        /// <summary>
        /// Unique identifier for a particular order.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The total amount of the discounts applied to the price of the order.
        /// </summary>
        [JsonProperty("total_discounts")]
        public double TotalDiscounts { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order.
        /// </summary>
        [JsonProperty("total_line_items_price")]
        public double TotalLineItemsPrice { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order, with taxes and discounts included (must be positive).
        /// </summary>
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        /// <summary>
        /// The sum of all the prices of all the items in the order, in USD, with taxes and discounts included (must be positive).
        /// </summary>
        [JsonProperty("total_price_usd")]
        public double TotalPriceUsd { get; set; }

        /// <summary>
        /// The sum of all the taxes applied to the order (must be positive).
        /// </summary>
        [JsonProperty("total_tax")]
        public double TotalTax { get; set; }

        /// <summary>
        /// The sum of all the weights of the line items in the order, in grams.
        /// </summary>
        [JsonProperty("total_weight")]
        public long? TotalWeight { get; set; }

        /// <summary>
        /// The date and time when the order was last modified.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// An array of <see cref="ShopifyTransaction"/> objects that detail all of the transactions in 
        /// this order.
        /// </summary>
        [JsonProperty("transactions"), Obsolete("This property is not documented in Shopify's API docs. Attempting to create an order with transactions often throws an error — use with caution.")]
        public IEnumerable<ShopifyTransaction> Transactions { get; set; }
    }
}
