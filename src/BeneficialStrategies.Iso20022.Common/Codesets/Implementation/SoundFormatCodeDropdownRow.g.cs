﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SoundFormatCode.  ISO2002 ID# _ADcV0N6_Eeiwsev40qZGEQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of sound to play.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SoundFormatCodeDropdownSource"/>.
/// Implements <seealso cref="ISoundFormatCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ADcV0N6_Eeiwsev40qZGEQ")]
public partial class SoundFormatCodeDropdownRow : EnumMetadataItem<SoundFormatCode>, ISoundFormatCodeDropdownRow
{
    /// <summary>
    /// Type of sound to play.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SoundFormatCodeDropdownRow(SoundFormatCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
