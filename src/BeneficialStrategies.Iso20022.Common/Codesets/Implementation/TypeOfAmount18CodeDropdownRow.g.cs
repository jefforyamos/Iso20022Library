﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeOfAmount18Code.  ISO2002 ID# _441QsPPwEeihCvvpsmGI2w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification or qualification of the type of amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeOfAmount18CodeDropdownSource"/>.
/// Implements <seealso cref="ITypeOfAmount18CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_441QsPPwEeihCvvpsmGI2w")]
public partial class TypeOfAmount18CodeDropdownRow : EnumMetadataItem<TypeOfAmount18Code>, ITypeOfAmount18CodeDropdownRow
{
    /// <summary>
    /// Identification or qualification of the type of amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeOfAmount18CodeDropdownRow(TypeOfAmount18Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
