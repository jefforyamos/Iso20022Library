﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceStatus1Code.  ISO2002 ID# _bkBa2Np-Ed-ak6NoX_4Aeg_1047073628.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the balance of transactions with a certain status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bkBa2Np-Ed-ak6NoX_4Aeg_1047073628")]
public partial class BalanceStatus1CodeDropdownSource : EnumMetadataManager<BalanceStatus1Code,IBalanceStatus1CodeDropdownRow,BalanceStatus1CodeDropdownRow>
{
    public BalanceStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
