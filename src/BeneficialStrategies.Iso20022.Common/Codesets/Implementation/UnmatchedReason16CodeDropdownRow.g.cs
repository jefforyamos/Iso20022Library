﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnmatchedReason16Code.  ISO2002 ID# _AUY3gBUJEeuZw7VHHgrHLg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnmatchedReason16CodeDropdownSource"/>.
/// Implements <seealso cref="IUnmatchedReason16CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AUY3gBUJEeuZw7VHHgrHLg")]
public partial class UnmatchedReason16CodeDropdownRow : EnumMetadataItem<UnmatchedReason16Code>, IUnmatchedReason16CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnmatchedReason16CodeDropdownRow(UnmatchedReason16Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
