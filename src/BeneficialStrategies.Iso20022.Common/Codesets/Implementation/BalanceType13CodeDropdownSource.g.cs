﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceType13Code.  ISO2002 ID# _m5hTdfNBEeCuA5Tr22BnwA_454049868.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the kind of the balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceType13CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_m5hTdfNBEeCuA5Tr22BnwA_454049868")]
public partial class BalanceType13CodeDropdownSource : EnumMetadataManager<BalanceType13Code,IBalanceType13CodeDropdownRow,BalanceType13CodeDropdownRow>
{
    public BalanceType13CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceType13CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
