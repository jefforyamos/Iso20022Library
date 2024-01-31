﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingInstructionRejectionCode.  ISO2002 ID# _VpFtddp-Ed-ak6NoX_4Aeg_-315431614.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible rejection reasons.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingInstructionRejectionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VpFtddp-Ed-ak6NoX_4Aeg_-315431614")]
public partial class MeetingInstructionRejectionCodeDropdownSource : EnumMetadataManager<MeetingInstructionRejectionCode,IMeetingInstructionRejectionCodeDropdownRow,MeetingInstructionRejectionCodeDropdownRow>
{
    public MeetingInstructionRejectionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingInstructionRejectionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
