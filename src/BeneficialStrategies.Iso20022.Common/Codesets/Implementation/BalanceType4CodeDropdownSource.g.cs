﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceType4Code.  ISO2002 ID# _Vnvpptp-Ed-ak6NoX_4Aeg_-890461341.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vnvpptp-Ed-ak6NoX_4Aeg_-890461341")]
public partial class BalanceType4CodeDropdownSource : EnumMetadataManager<BalanceType4Code,IBalanceType4CodeDropdownRow,BalanceType4CodeDropdownRow>
{
    public BalanceType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}