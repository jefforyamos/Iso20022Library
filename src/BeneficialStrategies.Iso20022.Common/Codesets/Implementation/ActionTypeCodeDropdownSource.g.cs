﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ActionTypeCode.  ISO2002 ID# _TVpK8gEcEeCQm6a_G2yO_w_-1860538994.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed by the POI system (Point Of Interaction).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IActionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVpK8gEcEeCQm6a_G2yO_w_-1860538994")]
public partial class ActionTypeCodeDropdownSource : EnumMetadataManager<ActionTypeCode,IActionTypeCodeDropdownRow,ActionTypeCodeDropdownRow>
{
    public ActionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ActionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
