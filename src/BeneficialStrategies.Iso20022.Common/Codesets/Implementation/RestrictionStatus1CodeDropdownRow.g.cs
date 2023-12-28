﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RestrictionStatus1Code.  ISO2002 ID# _v1wYICFnEeW9XJWqfgXIIA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a restriction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RestrictionStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IRestrictionStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_v1wYICFnEeW9XJWqfgXIIA")]
public partial class RestrictionStatus1CodeDropdownRow : EnumMetadataItem<RestrictionStatus1Code>, IRestrictionStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a restriction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RestrictionStatus1CodeDropdownRow(RestrictionStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
