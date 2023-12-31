﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason34Code.  ISO2002 ID# _jWLNs-5NEeCisYr99QEiWA_376105983.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason34CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jWLNs-5NEeCisYr99QEiWA_376105983")]
public partial class RejectionReason34CodeDropdownSource : EnumMetadataManager<RejectionReason34Code,IRejectionReason34CodeDropdownRow,RejectionReason34CodeDropdownRow>
{
    public RejectionReason34CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason34CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
