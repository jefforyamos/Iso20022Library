﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SystemBalanceType2Code.  ISO2002 ID# _8OFBV6MgEeCJ6YNENx4h-w_-736903366.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance within a system processing the transactions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISystemBalanceType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8OFBV6MgEeCJ6YNENx4h-w_-736903366")]
public partial class SystemBalanceType2CodeDropdownSource : EnumMetadataManager<SystemBalanceType2Code,ISystemBalanceType2CodeDropdownRow,SystemBalanceType2CodeDropdownRow>
{
    public SystemBalanceType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SystemBalanceType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
