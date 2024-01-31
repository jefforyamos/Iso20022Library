﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for VerificationEntity1Code.  ISO2002 ID# _Lxl9oBZOEeiXa46FI4OtcQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of verification entity.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="VerificationEntity1CodeDropdownSource"/>.
/// Implements <seealso cref="IVerificationEntity1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Lxl9oBZOEeiXa46FI4OtcQ")]
public partial class VerificationEntity1CodeDropdownRow : EnumMetadataItem<VerificationEntity1Code>, IVerificationEntity1CodeDropdownRow
{
    /// <summary>
    /// Type of verification entity.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public VerificationEntity1CodeDropdownRow(VerificationEntity1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
