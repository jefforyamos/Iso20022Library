﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingTypeClassificationCode.  ISO2002 ID# _aLXl1dp-Ed-ak6NoX_4Aeg_-1571134896.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Classifies the meeting type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingTypeClassificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aLXl1dp-Ed-ak6NoX_4Aeg_-1571134896")]
public partial class MeetingTypeClassificationCodeDropdownSource : EnumMetadataManager<MeetingTypeClassificationCode,IMeetingTypeClassificationCodeDropdownRow,MeetingTypeClassificationCodeDropdownRow>
{
    public MeetingTypeClassificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingTypeClassificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
