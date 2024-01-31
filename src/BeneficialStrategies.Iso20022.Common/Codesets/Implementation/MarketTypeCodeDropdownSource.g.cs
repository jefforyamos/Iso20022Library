﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MarketTypeCode.  ISO2002 ID# _aUwLU9p-Ed-ak6NoX_4Aeg_1124995296.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMarketTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aUwLU9p-Ed-ak6NoX_4Aeg_1124995296")]
public partial class MarketTypeCodeDropdownSource : EnumMetadataManager<MarketTypeCode,IMarketTypeCodeDropdownRow,MarketTypeCodeDropdownRow>
{
    public MarketTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MarketTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
