﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceType5Code.  ISO2002 ID# _VoMVkdp-Ed-ak6NoX_4Aeg_-1849040017.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VoMVkdp-Ed-ak6NoX_4Aeg_-1849040017")]
public partial class BalanceType5CodeDropdownSource : EnumMetadataManager<BalanceType5Code,IBalanceType5CodeDropdownRow,BalanceType5CodeDropdownRow>
{
    public BalanceType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
