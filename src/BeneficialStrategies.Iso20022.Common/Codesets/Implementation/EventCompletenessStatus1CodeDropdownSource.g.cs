﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventCompletenessStatus1Code.  ISO2002 ID# _ajDtFNp-Ed-ak6NoX_4Aeg_1571232805.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the details provided about an event are complete or incomplete.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventCompletenessStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajDtFNp-Ed-ak6NoX_4Aeg_1571232805")]
public partial class EventCompletenessStatus1CodeDropdownSource : EnumMetadataManager<EventCompletenessStatus1Code,IEventCompletenessStatus1CodeDropdownRow,EventCompletenessStatus1CodeDropdownRow>
{
    public EventCompletenessStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventCompletenessStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
