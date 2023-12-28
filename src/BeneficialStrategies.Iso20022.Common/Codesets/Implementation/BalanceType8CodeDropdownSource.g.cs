﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceType8Code.  ISO2002 ID# _baC_dNp-Ed-ak6NoX_4Aeg_-528666353.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_baC_dNp-Ed-ak6NoX_4Aeg_-528666353")]
public partial class BalanceType8CodeDropdownSource : EnumMetadataManager<BalanceType8Code,IBalanceType8CodeDropdownRow,BalanceType8CodeDropdownRow>
{
    public BalanceType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
