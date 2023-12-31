﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason50Code.  ISO2002 ID# _frUwsLKxEemDyeh7tbvg1w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason50CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_frUwsLKxEemDyeh7tbvg1w")]
public partial class RejectionReason50CodeDropdownSource : EnumMetadataManager<RejectionReason50Code,IRejectionReason50CodeDropdownRow,RejectionReason50CodeDropdownRow>
{
    public RejectionReason50CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason50CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
