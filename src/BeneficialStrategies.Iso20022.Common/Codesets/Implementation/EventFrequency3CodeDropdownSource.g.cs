﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventFrequency3Code.  ISO2002 ID# _ajpi8dp-Ed-ak6NoX_4Aeg_1482517785.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventFrequency3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajpi8dp-Ed-ak6NoX_4Aeg_1482517785")]
public partial class EventFrequency3CodeDropdownSource : EnumMetadataManager<EventFrequency3Code,IEventFrequency3CodeDropdownRow,EventFrequency3CodeDropdownRow>
{
    public EventFrequency3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventFrequency3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}