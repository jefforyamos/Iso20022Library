﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventFrequency5Code.  ISO2002 ID# _ajzT-Np-Ed-ak6NoX_4Aeg_-1261201154.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventFrequency5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajzT-Np-Ed-ak6NoX_4Aeg_-1261201154")]
public partial class EventFrequency5CodeDropdownSource : EnumMetadataManager<EventFrequency5Code,IEventFrequency5CodeDropdownRow,EventFrequency5CodeDropdownRow>
{
    public EventFrequency5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventFrequency5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
