﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason23Code.  ISO2002 ID# _AL0OMRnzEeyroI8qKgB7Mg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason23CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AL0OMRnzEeyroI8qKgB7Mg")]
public partial class PendingReason23CodeDropdownSource : EnumMetadataManager<PendingReason23Code,IPendingReason23CodeDropdownRow,PendingReason23CodeDropdownRow>
{
    public PendingReason23CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason23CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
