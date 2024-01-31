﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ActionDestinationCode.  ISO2002 ID# _DsgNEE0wEeea0Mdu1TOzDQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of destination for a specific action.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IActionDestinationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DsgNEE0wEeea0Mdu1TOzDQ")]
public partial class ActionDestinationCodeDropdownSource : EnumMetadataManager<ActionDestinationCode,IActionDestinationCodeDropdownRow,ActionDestinationCodeDropdownRow>
{
    public ActionDestinationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ActionDestinationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
