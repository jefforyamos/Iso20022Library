﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ActionCode.  ISO2002 ID# _bp-44tp-Ed-ak6NoX_4Aeg_-1917186008.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which type of action a user should take.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IActionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bp-44tp-Ed-ak6NoX_4Aeg_-1917186008")]
public partial class ActionCodeDropdownSource : EnumMetadataManager<ActionCode,IActionCodeDropdownRow,ActionCodeDropdownRow>
{
    public ActionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ActionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
