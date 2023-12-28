﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FailureReason6Code.  ISO2002 ID# _x-5LMItDEeSxlKlAGYErFg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for which the key has been stopped.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFailureReason6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_x-5LMItDEeSxlKlAGYErFg")]
public partial class FailureReason6CodeDropdownSource : EnumMetadataManager<FailureReason6Code,IFailureReason6CodeDropdownRow,FailureReason6CodeDropdownRow>
{
    public FailureReason6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FailureReason6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}