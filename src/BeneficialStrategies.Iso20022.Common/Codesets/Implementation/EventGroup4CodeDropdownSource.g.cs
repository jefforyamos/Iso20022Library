﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventGroup4Code.  ISO2002 ID# _i8tCgAB8EeqouY-yI_q3qQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventGroup4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_i8tCgAB8EeqouY-yI_q3qQ")]
public partial class EventGroup4CodeDropdownSource : EnumMetadataManager<EventGroup4Code,IEventGroup4CodeDropdownRow,EventGroup4CodeDropdownRow>
{
    public EventGroup4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventGroup4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}