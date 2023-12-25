﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DisclosureRequestCancellationReasonCode.  ISO2002 ID# _IZJRIEV4EemRx7jyevcLwg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the cancellation of the disclosure request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDisclosureRequestCancellationReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IZJRIEV4EemRx7jyevcLwg")]
public partial class DisclosureRequestCancellationReasonCodeDropdownSource : EnumMetadataManager<DisclosureRequestCancellationReasonCode,IDisclosureRequestCancellationReasonCodeDropdownRow,DisclosureRequestCancellationReasonCodeDropdownRow>
{
    public DisclosureRequestCancellationReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DisclosureRequestCancellationReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
