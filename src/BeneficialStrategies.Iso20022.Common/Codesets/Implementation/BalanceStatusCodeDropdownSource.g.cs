﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceStatusCode.  ISO2002 ID# _bkLL0tp-Ed-ak6NoX_4Aeg_882404778.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance of transactions with a certain status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bkLL0tp-Ed-ak6NoX_4Aeg_882404778")]
public partial class BalanceStatusCodeDropdownSource : EnumMetadataManager<BalanceStatusCode,IBalanceStatusCodeDropdownRow,BalanceStatusCodeDropdownRow>
{
    public BalanceStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}