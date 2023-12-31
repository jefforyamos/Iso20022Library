﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingTypeClassification2Code.  ISO2002 ID# _QC-WYK7NEemG7MmivSuE5g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Classifies the meeting type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingTypeClassification2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QC-WYK7NEemG7MmivSuE5g")]
public partial class MeetingTypeClassification2CodeDropdownSource : EnumMetadataManager<MeetingTypeClassification2Code,IMeetingTypeClassification2CodeDropdownRow,MeetingTypeClassification2CodeDropdownRow>
{
    public MeetingTypeClassification2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingTypeClassification2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
