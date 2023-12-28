﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CheckCodeLine1Code.  ISO2002 ID# _ecCDMK4EEeWL1uap3dNhCQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format of the check code line.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CheckCodeLine1CodeDropdownSource"/>.
/// Implements <seealso cref="ICheckCodeLine1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ecCDMK4EEeWL1uap3dNhCQ")]
public partial class CheckCodeLine1CodeDropdownRow : EnumMetadataItem<CheckCodeLine1Code>, ICheckCodeLine1CodeDropdownRow
{
    /// <summary>
    /// Format of the check code line.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CheckCodeLine1CodeDropdownRow(CheckCodeLine1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}