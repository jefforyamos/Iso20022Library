﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventFrequency8Code.  ISO2002 ID# _nYW2IBUREeOIaq8KyCdIDQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventFrequency8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nYW2IBUREeOIaq8KyCdIDQ")]
public partial class EventFrequency8CodeDropdownSource : EnumMetadataManager<EventFrequency8Code,IEventFrequency8CodeDropdownRow,EventFrequency8CodeDropdownRow>
{
    public EventFrequency8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventFrequency8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
