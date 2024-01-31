﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnderlyingIdentificationCode.  ISO2002 ID# _zm6XAHZVEeWM6LeFwEMTgg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the underlying identification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnderlyingIdentificationCodeDropdownSource"/>.
/// Implements <seealso cref="IUnderlyingIdentificationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zm6XAHZVEeWM6LeFwEMTgg")]
public partial class UnderlyingIdentificationCodeDropdownRow : EnumMetadataItem<UnderlyingIdentificationCode>, IUnderlyingIdentificationCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the underlying identification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnderlyingIdentificationCodeDropdownRow(UnderlyingIdentificationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
