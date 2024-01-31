﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MovementResponseType1Code.  ISO2002 ID# _jQzlhe5NEeCisYr99QEiWA_-503094567.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of movement response to be returned.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MovementResponseType1CodeDropdownSource"/>.
/// Implements <seealso cref="IMovementResponseType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jQzlhe5NEeCisYr99QEiWA_-503094567")]
public partial class MovementResponseType1CodeDropdownRow : EnumMetadataItem<MovementResponseType1Code>, IMovementResponseType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of movement response to be returned.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MovementResponseType1CodeDropdownRow(MovementResponseType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
