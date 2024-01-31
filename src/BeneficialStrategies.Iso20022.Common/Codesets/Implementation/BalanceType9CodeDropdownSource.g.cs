﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceType9Code.  ISO2002 ID# _bao1UNp-Ed-ak6NoX_4Aeg_1033663849.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceType9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bao1UNp-Ed-ak6NoX_4Aeg_1033663849")]
public partial class BalanceType9CodeDropdownSource : EnumMetadataManager<BalanceType9Code,IBalanceType9CodeDropdownRow,BalanceType9CodeDropdownRow>
{
    public BalanceType9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceType9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
