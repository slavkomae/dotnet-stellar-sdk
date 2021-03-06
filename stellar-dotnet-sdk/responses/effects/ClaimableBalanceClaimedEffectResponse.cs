﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace stellar_dotnet_sdk.responses.effects
{
    /// <summary>
    ///     Represents claimable_balance_claimed effect response.
    ///     See: https://www.stellar.org/developers/horizon/reference/resources/effect.html
    ///     <seealso cref="requests.EffectsRequestBuilder" />
    ///     <seealso cref="Server" />
    /// </summary>
    public class ClaimableBalanceClaimedEffectResponse : EffectResponse
    {
        public override int TypeId => 52;

        [JsonProperty(PropertyName = "asset")]
        public string Asset { get; private set; }

        [JsonProperty(PropertyName = "balance_id")]
	    public string BalanceID { get; private set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; private set; }

        public ClaimableBalanceClaimedEffectResponse()
        {

        }

        public ClaimableBalanceClaimedEffectResponse(string asset, string balanceID, string amount)
        {
            Asset = asset;
            BalanceID = balanceID;
            Amount = amount;
        }
    }
}