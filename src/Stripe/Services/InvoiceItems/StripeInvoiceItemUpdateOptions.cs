﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeInvoiceItemUpdateOptions
	{
		[JsonProperty("amount")]
		public int AmountInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}