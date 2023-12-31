﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MarketType4Code.  ISO2002 ID# _aUmaVNp-Ed-ak6NoX_4Aeg_-863621443.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMarketType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aUmaVNp-Ed-ak6NoX_4Aeg_-863621443")]
public partial class MarketType4CodeDropdownSource : EnumMetadataManager<MarketType4Code,IMarketType4CodeDropdownRow,MarketType4CodeDropdownRow>
{
    public MarketType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MarketType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
