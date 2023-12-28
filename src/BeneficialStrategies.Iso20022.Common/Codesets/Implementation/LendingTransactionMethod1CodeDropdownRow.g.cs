﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LendingTransactionMethod1Code.  ISO2002 ID# __2_DYNojEeC60axPepSq7g_-126793566.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Lending method applied to the securities financing contract.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LendingTransactionMethod1CodeDropdownSource"/>.
/// Implements <seealso cref="ILendingTransactionMethod1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__2_DYNojEeC60axPepSq7g_-126793566")]
public partial class LendingTransactionMethod1CodeDropdownRow : EnumMetadataItem<LendingTransactionMethod1Code>, ILendingTransactionMethod1CodeDropdownRow
{
    /// <summary>
    /// Lending method applied to the securities financing contract.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LendingTransactionMethod1CodeDropdownRow(LendingTransactionMethod1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}