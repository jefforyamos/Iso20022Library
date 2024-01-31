﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ActionType3Code.  ISO2002 ID# _3I4WYTGeEeO118ZQJgaQSQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ActionType3CodeDropdownSource"/>.
/// Implements <seealso cref="IActionType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3I4WYTGeEeO118ZQJgaQSQ")]
public partial class ActionType3CodeDropdownRow : EnumMetadataItem<ActionType3Code>, IActionType3CodeDropdownRow
{
    /// <summary>
    /// Type of action to be performed by the point of interaction (POI).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ActionType3CodeDropdownRow(ActionType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
