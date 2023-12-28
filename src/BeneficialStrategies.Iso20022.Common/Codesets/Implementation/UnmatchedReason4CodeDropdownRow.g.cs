﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnmatchedReason4Code.  ISO2002 ID# __q6WQdojEeC60axPepSq7g_-1712157362.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnmatchedReason4CodeDropdownSource"/>.
/// Implements <seealso cref="IUnmatchedReason4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__q6WQdojEeC60axPepSq7g_-1712157362")]
public partial class UnmatchedReason4CodeDropdownRow : EnumMetadataItem<UnmatchedReason4Code>, IUnmatchedReason4CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnmatchedReason4CodeDropdownRow(UnmatchedReason4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
