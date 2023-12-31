﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ActionType5Code.  ISO2002 ID# _YAeyAHuYEeSVeNXcmBQ4hQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IActionType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YAeyAHuYEeSVeNXcmBQ4hQ")]
public partial class ActionType5CodeDropdownSource : EnumMetadataManager<ActionType5Code,IActionType5CodeDropdownRow,ActionType5CodeDropdownRow>
{
    public ActionType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ActionType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
