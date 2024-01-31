﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingCapacity2Code.  ISO2002 ID# _YZOSyNp-Ed-ak6NoX_4Aeg_539037705.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingCapacity2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZOSyNp-Ed-ak6NoX_4Aeg_539037705")]
public partial class TradingCapacity2CodeDropdownSource : EnumMetadataManager<TradingCapacity2Code,ITradingCapacity2CodeDropdownRow,TradingCapacity2CodeDropdownRow>
{
    public TradingCapacity2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingCapacity2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
