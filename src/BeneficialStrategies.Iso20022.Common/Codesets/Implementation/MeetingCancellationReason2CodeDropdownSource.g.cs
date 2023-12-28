﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingCancellationReason2Code.  ISO2002 ID# _aVM3QNp-Ed-ak6NoX_4Aeg_-990079523.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingCancellationReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aVM3QNp-Ed-ak6NoX_4Aeg_-990079523")]
public partial class MeetingCancellationReason2CodeDropdownSource : EnumMetadataManager<MeetingCancellationReason2Code,IMeetingCancellationReason2CodeDropdownRow,MeetingCancellationReason2CodeDropdownRow>
{
    public MeetingCancellationReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingCancellationReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}