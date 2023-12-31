﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LevelOfControlCode.  ISO2002 ID# _Y7LFQCDDEeWPMvNwVtiMsA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of control.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LevelOfControlCodeDropdownSource"/>.
/// Implements <seealso cref="ILevelOfControlCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y7LFQCDDEeWPMvNwVtiMsA")]
public partial class LevelOfControlCodeDropdownRow : EnumMetadataItem<LevelOfControlCode>, ILevelOfControlCodeDropdownRow
{
    /// <summary>
    /// Specifies the level of control.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LevelOfControlCodeDropdownRow(LevelOfControlCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
