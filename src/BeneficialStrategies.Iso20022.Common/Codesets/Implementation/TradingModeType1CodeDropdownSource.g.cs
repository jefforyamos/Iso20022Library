﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingModeType1Code.  ISO2002 ID# _-JagcIBEEeSUJZYcWGKkkw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of the trading mode.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingModeType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-JagcIBEEeSUJZYcWGKkkw")]
public partial class TradingModeType1CodeDropdownSource : EnumMetadataManager<TradingModeType1Code,ITradingModeType1CodeDropdownRow,TradingModeType1CodeDropdownRow>
{
    public TradingModeType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingModeType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
