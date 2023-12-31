﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CrossTradeExecutionCode.  ISO2002 ID# _bUOrWdp-Ed-ak6NoX_4Aeg_335335746.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cross being submitted to a market.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICrossTradeExecutionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bUOrWdp-Ed-ak6NoX_4Aeg_335335746")]
public partial class CrossTradeExecutionCodeDropdownSource : EnumMetadataManager<CrossTradeExecutionCode,ICrossTradeExecutionCodeDropdownRow,CrossTradeExecutionCodeDropdownRow>
{
    public CrossTradeExecutionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CrossTradeExecutionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
