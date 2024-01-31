﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MarketClaimType1Code.  ISO2002 ID# _1y3xAC2oEeuVt5XRmyhHiA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market claim in the context of a corporate action distribution event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMarketClaimType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1y3xAC2oEeuVt5XRmyhHiA")]
public partial class MarketClaimType1CodeDropdownSource : EnumMetadataManager<MarketClaimType1Code,IMarketClaimType1CodeDropdownRow,MarketClaimType1CodeDropdownRow>
{
    public MarketClaimType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MarketClaimType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
