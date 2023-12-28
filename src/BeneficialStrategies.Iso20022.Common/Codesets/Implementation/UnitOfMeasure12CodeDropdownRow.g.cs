﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnitOfMeasure12Code.  ISO2002 ID# _bm4kgOXuEemUbdOm9aOvMg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the unit of measure by means of a code.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnitOfMeasure12CodeDropdownSource"/>.
/// Implements <seealso cref="IUnitOfMeasure12CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bm4kgOXuEemUbdOm9aOvMg")]
public partial class UnitOfMeasure12CodeDropdownRow : EnumMetadataItem<UnitOfMeasure12Code>, IUnitOfMeasure12CodeDropdownRow
{
    /// <summary>
    /// Identifies the unit of measure by means of a code.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnitOfMeasure12CodeDropdownRow(UnitOfMeasure12Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
