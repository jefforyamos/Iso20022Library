﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingInstructionRejection1Code.  ISO2002 ID# _VpPeeNp-Ed-ak6NoX_4Aeg_597993338.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the possible rejection reasons.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingInstructionRejection1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VpPeeNp-Ed-ak6NoX_4Aeg_597993338")]
public partial class MeetingInstructionRejection1CodeDropdownSource : EnumMetadataManager<MeetingInstructionRejection1Code,IMeetingInstructionRejection1CodeDropdownRow,MeetingInstructionRejection1CodeDropdownRow>
{
    public MeetingInstructionRejection1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingInstructionRejection1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}