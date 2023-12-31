﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LiquidityLimitType1Code.  ISO2002 ID# _afL5tNp-Ed-ak6NoX_4Aeg_-1698330294.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the precise type of liquidity management limit.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILiquidityLimitType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_afL5tNp-Ed-ak6NoX_4Aeg_-1698330294")]
public partial class LiquidityLimitType1CodeDropdownSource : EnumMetadataManager<LiquidityLimitType1Code,ILiquidityLimitType1CodeDropdownRow,LiquidityLimitType1CodeDropdownRow>
{
    public LiquidityLimitType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LiquidityLimitType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
