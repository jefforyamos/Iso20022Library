﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeniedReason6Code.  ISO2002 ID# _-_kAAFhdEeS8HfHHd4stCA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the denied reason.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeniedReason6CodeDropdownSource"/>.
/// Implements <seealso cref="IDeniedReason6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-_kAAFhdEeS8HfHHd4stCA")]
public partial class DeniedReason6CodeDropdownRow : EnumMetadataItem<DeniedReason6Code>, IDeniedReason6CodeDropdownRow
{
    /// <summary>
    /// Specifies the denied reason.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeniedReason6CodeDropdownRow(DeniedReason6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}