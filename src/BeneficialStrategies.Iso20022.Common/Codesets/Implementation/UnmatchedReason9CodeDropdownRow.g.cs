﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnmatchedReason9Code.  ISO2002 ID# _NnLDQSwLEeOqZONeZTLNPw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnmatchedReason9CodeDropdownSource"/>.
/// Implements <seealso cref="IUnmatchedReason9CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NnLDQSwLEeOqZONeZTLNPw")]
public partial class UnmatchedReason9CodeDropdownRow : EnumMetadataItem<UnmatchedReason9Code>, IUnmatchedReason9CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnmatchedReason9CodeDropdownRow(UnmatchedReason9Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
