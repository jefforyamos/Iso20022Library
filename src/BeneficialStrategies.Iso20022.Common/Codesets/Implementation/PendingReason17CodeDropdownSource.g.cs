﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingReason17Code.  ISO2002 ID# _-bahwOBjEeiVRbNQx5-Vhg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction or the instruction has a pending status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingReason17CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-bahwOBjEeiVRbNQx5-Vhg")]
public partial class PendingReason17CodeDropdownSource : EnumMetadataManager<PendingReason17Code,IPendingReason17CodeDropdownRow,PendingReason17CodeDropdownRow>
{
    public PendingReason17CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingReason17CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
