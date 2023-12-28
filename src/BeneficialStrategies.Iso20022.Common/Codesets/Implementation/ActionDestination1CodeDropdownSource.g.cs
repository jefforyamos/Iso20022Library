﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ActionDestination1Code.  ISO2002 ID# _w1Qk0E0wEeea0Mdu1TOzDQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Destination of action to be performed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IActionDestination1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_w1Qk0E0wEeea0Mdu1TOzDQ")]
public partial class ActionDestination1CodeDropdownSource : EnumMetadataManager<ActionDestination1Code,IActionDestination1CodeDropdownRow,ActionDestination1CodeDropdownRow>
{
    public ActionDestination1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ActionDestination1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}