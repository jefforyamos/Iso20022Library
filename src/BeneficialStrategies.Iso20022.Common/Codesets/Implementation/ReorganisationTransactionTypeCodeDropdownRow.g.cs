﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReorganisationTransactionTypeCode.  ISO2002 ID# _QcVdoMU9EeeWeZMpNX1JUQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of reorganisation transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReorganisationTransactionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IReorganisationTransactionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QcVdoMU9EeeWeZMpNX1JUQ")]
public partial class ReorganisationTransactionTypeCodeDropdownRow : EnumMetadataItem<ReorganisationTransactionTypeCode>, IReorganisationTransactionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of reorganisation transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReorganisationTransactionTypeCodeDropdownRow(ReorganisationTransactionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}