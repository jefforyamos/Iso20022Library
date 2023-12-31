﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventType1Code.  ISO2002 ID# _aki609p-Ed-ak6NoX_4Aeg_-470397126.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aki609p-Ed-ak6NoX_4Aeg_-470397126")]
public partial class EventType1CodeDropdownSource : EnumMetadataManager<EventType1Code,IEventType1CodeDropdownRow,EventType1CodeDropdownRow>
{
    public EventType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
