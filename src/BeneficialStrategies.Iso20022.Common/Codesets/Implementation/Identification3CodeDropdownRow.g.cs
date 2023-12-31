﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Identification3Code.  ISO2002 ID# _leEoQad3EeuEcqP2FGAFaA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of an individual.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Identification3CodeDropdownSource"/>.
/// Implements <seealso cref="IIdentification3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_leEoQad3EeuEcqP2FGAFaA")]
public partial class Identification3CodeDropdownRow : EnumMetadataItem<Identification3Code>, IIdentification3CodeDropdownRow
{
    /// <summary>
    /// Identification of an individual.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Identification3CodeDropdownRow(Identification3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
