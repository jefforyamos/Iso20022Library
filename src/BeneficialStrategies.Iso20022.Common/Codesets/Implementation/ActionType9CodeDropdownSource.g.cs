﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ActionType9Code.  ISO2002 ID# _42sRoQvBEeqgUfvUJi0f5w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IActionType9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_42sRoQvBEeqgUfvUJi0f5w")]
public partial class ActionType9CodeDropdownSource : EnumMetadataManager<ActionType9Code,IActionType9CodeDropdownRow,ActionType9CodeDropdownRow>
{
    public ActionType9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ActionType9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
