﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventGroupCode.  ISO2002 ID# _1oFf0zL3EeKU9IrkkToqcw_648096752.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventGroupCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1oFf0zL3EeKU9IrkkToqcw_648096752")]
public partial class EventGroupCodeDropdownSource : EnumMetadataManager<EventGroupCode,IEventGroupCodeDropdownRow,EventGroupCodeDropdownRow>
{
    public EventGroupCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventGroupCodeDropdownRow(enumValue, memberInfo))
    {
    }
}