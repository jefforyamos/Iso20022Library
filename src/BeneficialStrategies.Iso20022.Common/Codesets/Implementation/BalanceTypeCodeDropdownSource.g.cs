﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceTypeCode.  ISO2002 ID# _bbFhQNp-Ed-ak6NoX_4Aeg_142948041.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bbFhQNp-Ed-ak6NoX_4Aeg_142948041")]
public partial class BalanceTypeCodeDropdownSource : EnumMetadataManager<BalanceTypeCode,IBalanceTypeCodeDropdownRow,BalanceTypeCodeDropdownRow>
{
    public BalanceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}