﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ActionType3Code.  ISO2002 ID# _3I4WYTGeEeO118ZQJgaQSQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IActionType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3I4WYTGeEeO118ZQJgaQSQ")]
public partial class ActionType3CodeDropdownSource : EnumMetadataManager<ActionType3Code,IActionType3CodeDropdownRow,ActionType3CodeDropdownRow>
{
    public ActionType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ActionType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
