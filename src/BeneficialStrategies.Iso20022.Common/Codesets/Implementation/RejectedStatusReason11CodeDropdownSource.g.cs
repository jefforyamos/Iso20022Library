﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectedStatusReason11Code.  ISO2002 ID# _G1StsEgbEea9YuSvQGoi-w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectedStatusReason11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_G1StsEgbEea9YuSvQGoi-w")]
public partial class RejectedStatusReason11CodeDropdownSource : EnumMetadataManager<RejectedStatusReason11Code,IRejectedStatusReason11CodeDropdownRow,RejectedStatusReason11CodeDropdownRow>
{
    public RejectedStatusReason11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectedStatusReason11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
