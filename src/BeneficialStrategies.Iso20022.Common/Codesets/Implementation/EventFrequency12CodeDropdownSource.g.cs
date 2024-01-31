﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventFrequency12Code.  ISO2002 ID# _tRpaUDrvEeuD7rm9md9zvg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventFrequency12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tRpaUDrvEeuD7rm9md9zvg")]
public partial class EventFrequency12CodeDropdownSource : EnumMetadataManager<EventFrequency12Code,IEventFrequency12CodeDropdownRow,EventFrequency12CodeDropdownRow>
{
    public EventFrequency12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventFrequency12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
