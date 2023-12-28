﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason55Code.  ISO2002 ID# _-IH_MOkIEemm4qhb2yFPOw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason55CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-IH_MOkIEemm4qhb2yFPOw")]
public partial class RejectionReason55CodeDropdownSource : EnumMetadataManager<RejectionReason55Code,IRejectionReason55CodeDropdownRow,RejectionReason55CodeDropdownRow>
{
    public RejectionReason55CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason55CodeDropdownRow(enumValue, memberInfo))
    {
    }
}