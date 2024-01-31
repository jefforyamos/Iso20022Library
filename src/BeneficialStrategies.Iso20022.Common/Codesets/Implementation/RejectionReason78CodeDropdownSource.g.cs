﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason78Code.  ISO2002 ID# _5q004QaYEe2-DuDrUXkg2w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason78CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5q004QaYEe2-DuDrUXkg2w")]
public partial class RejectionReason78CodeDropdownSource : EnumMetadataManager<RejectionReason78Code,IRejectionReason78CodeDropdownRow,RejectionReason78CodeDropdownRow>
{
    public RejectionReason78CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason78CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
