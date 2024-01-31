﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventConfirmationStatusCode.  ISO2002 ID# _ajNeFNp-Ed-ak6NoX_4Aeg_-582418410.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of the occurrence of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventConfirmationStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajNeFNp-Ed-ak6NoX_4Aeg_-582418410")]
public partial class EventConfirmationStatusCodeDropdownSource : EnumMetadataManager<EventConfirmationStatusCode,IEventConfirmationStatusCodeDropdownRow,EventConfirmationStatusCodeDropdownRow>
{
    public EventConfirmationStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventConfirmationStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
