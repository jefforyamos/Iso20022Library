﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceCounterparty1Code.  ISO2002 ID# _bkBa0tp-Ed-ak6NoX_4Aeg_678189976.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of counterparty to be taken into account for calculation of the balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceCounterparty1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bkBa0tp-Ed-ak6NoX_4Aeg_678189976")]
public partial class BalanceCounterparty1CodeDropdownSource : EnumMetadataManager<BalanceCounterparty1Code,IBalanceCounterparty1CodeDropdownRow,BalanceCounterparty1CodeDropdownRow>
{
    public BalanceCounterparty1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceCounterparty1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
