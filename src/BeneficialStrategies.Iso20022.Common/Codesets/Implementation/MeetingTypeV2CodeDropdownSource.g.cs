﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingTypeV2Code.  ISO2002 ID# _Oq2Raq7DEemG7MmivSuE5g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of security holders meeting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingTypeV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Oq2Raq7DEemG7MmivSuE5g")]
public partial class MeetingTypeV2CodeDropdownSource : EnumMetadataManager<MeetingTypeV2Code,IMeetingTypeV2CodeDropdownRow,MeetingTypeV2CodeDropdownRow>
{
    public MeetingTypeV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingTypeV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
