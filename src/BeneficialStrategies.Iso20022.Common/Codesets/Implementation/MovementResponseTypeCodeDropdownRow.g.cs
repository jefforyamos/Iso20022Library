﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MovementResponseTypeCode.  ISO2002 ID# _jQ9Wgu5NEeCisYr99QEiWA_1302753990.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of movement response to be returned.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MovementResponseTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IMovementResponseTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jQ9Wgu5NEeCisYr99QEiWA_1302753990")]
public partial class MovementResponseTypeCodeDropdownRow : EnumMetadataItem<MovementResponseTypeCode>, IMovementResponseTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of movement response to be returned.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MovementResponseTypeCodeDropdownRow(MovementResponseTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
