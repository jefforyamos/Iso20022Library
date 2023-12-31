﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for VerificationEntityCode.  ISO2002 ID# _lnn88BZNEeiXa46FI4OtcQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Entity to perform verification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="VerificationEntityCodeDropdownSource"/>.
/// Implements <seealso cref="IVerificationEntityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lnn88BZNEeiXa46FI4OtcQ")]
public partial class VerificationEntityCodeDropdownRow : EnumMetadataItem<VerificationEntityCode>, IVerificationEntityCodeDropdownRow
{
    /// <summary>
    /// Entity to perform verification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public VerificationEntityCodeDropdownRow(VerificationEntityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
