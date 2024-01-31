﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ActionCode.  ISO2002 ID# _bp-44tp-Ed-ak6NoX_4Aeg_-1917186008.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of action a user should take.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ActionCodeDropdownSource"/>.
/// Implements <seealso cref="IActionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bp-44tp-Ed-ak6NoX_4Aeg_-1917186008")]
public partial class ActionCodeDropdownRow : EnumMetadataItem<ActionCode>, IActionCodeDropdownRow
{
    /// <summary>
    /// Specifies which type of action a user should take.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ActionCodeDropdownRow(ActionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
