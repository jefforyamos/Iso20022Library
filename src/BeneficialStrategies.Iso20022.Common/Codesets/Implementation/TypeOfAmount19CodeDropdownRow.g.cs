﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeOfAmount19Code.  ISO2002 ID# _or7VMPfKEei89sMSHxl1ew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification or qualification of the type of amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeOfAmount19CodeDropdownSource"/>.
/// Implements <seealso cref="ITypeOfAmount19CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_or7VMPfKEei89sMSHxl1ew")]
public partial class TypeOfAmount19CodeDropdownRow : EnumMetadataItem<TypeOfAmount19Code>, ITypeOfAmount19CodeDropdownRow
{
    /// <summary>
    /// Identification or qualification of the type of amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeOfAmount19CodeDropdownRow(TypeOfAmount19Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
