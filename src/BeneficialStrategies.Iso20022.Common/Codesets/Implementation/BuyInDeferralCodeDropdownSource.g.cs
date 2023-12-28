﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BuyInDeferralCode.  ISO2002 ID# _zwlJQJwVEeqtp-LOti013g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies that the buy-in transaction was deferred or not.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBuyInDeferralCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zwlJQJwVEeqtp-LOti013g")]
public partial class BuyInDeferralCodeDropdownSource : EnumMetadataManager<BuyInDeferralCode,IBuyInDeferralCodeDropdownRow,BuyInDeferralCodeDropdownRow>
{
    public BuyInDeferralCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BuyInDeferralCodeDropdownRow(enumValue, memberInfo))
    {
    }
}