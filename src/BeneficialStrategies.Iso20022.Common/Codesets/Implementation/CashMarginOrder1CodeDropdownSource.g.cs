﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CashMarginOrder1Code.  ISO2002 ID# _a65lVdp-Ed-ak6NoX_4Aeg_-1022295664.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether an order is a non-margin, an opening margin or a closing margin order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICashMarginOrder1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a65lVdp-Ed-ak6NoX_4Aeg_-1022295664")]
public partial class CashMarginOrder1CodeDropdownSource : EnumMetadataManager<CashMarginOrder1Code,ICashMarginOrder1CodeDropdownRow,CashMarginOrder1CodeDropdownRow>
{
    public CashMarginOrder1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CashMarginOrder1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
