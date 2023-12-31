﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeOfAmount11Code.  ISO2002 ID# _4ydHoFKQEeeFcfYfFkVztg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies the amount of the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeOfAmount11CodeDropdownSource"/>.
/// Implements <seealso cref="ITypeOfAmount11CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4ydHoFKQEeeFcfYfFkVztg")]
public partial class TypeOfAmount11CodeDropdownRow : EnumMetadataItem<TypeOfAmount11Code>, ITypeOfAmount11CodeDropdownRow
{
    /// <summary>
    /// Qualifies the amount of the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeOfAmount11CodeDropdownRow(TypeOfAmount11Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
