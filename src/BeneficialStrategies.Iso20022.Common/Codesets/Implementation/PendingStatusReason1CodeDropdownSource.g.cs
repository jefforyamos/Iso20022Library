﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PendingStatusReason1Code.  ISO2002 ID# _-nYUEGBjEeaR1OOiVxm3Gg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a pending status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPendingStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-nYUEGBjEeaR1OOiVxm3Gg")]
public partial class PendingStatusReason1CodeDropdownSource : EnumMetadataManager<PendingStatusReason1Code,IPendingStatusReason1CodeDropdownRow,PendingStatusReason1CodeDropdownRow>
{
    public PendingStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PendingStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}