﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingInstructionCancellationStatusCode.  ISO2002 ID# _VpiZYNp-Ed-ak6NoX_4Aeg_-1662861442.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a meeting instruction cancellation request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingInstructionCancellationStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VpiZYNp-Ed-ak6NoX_4Aeg_-1662861442")]
public partial class MeetingInstructionCancellationStatusCodeDropdownSource : EnumMetadataManager<MeetingInstructionCancellationStatusCode,IMeetingInstructionCancellationStatusCodeDropdownRow,MeetingInstructionCancellationStatusCodeDropdownRow>
{
    public MeetingInstructionCancellationStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingInstructionCancellationStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
