﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ActionType8Code.  ISO2002 ID# _EsxP4ErCEeenp6hmNprBHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Recommended action for the card issuer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ActionType8CodeDropdownSource"/>.
/// Implements <seealso cref="IActionType8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EsxP4ErCEeenp6hmNprBHg")]
public partial class ActionType8CodeDropdownRow : EnumMetadataItem<ActionType8Code>, IActionType8CodeDropdownRow
{
    /// <summary>
    /// Recommended action for the card issuer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ActionType8CodeDropdownRow(ActionType8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
