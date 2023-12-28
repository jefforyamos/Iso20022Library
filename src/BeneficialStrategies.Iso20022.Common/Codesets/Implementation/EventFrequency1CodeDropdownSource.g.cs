﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventFrequency1Code.  ISO2002 ID# _ajNeF9p-Ed-ak6NoX_4Aeg_899403009.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventFrequency1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajNeF9p-Ed-ak6NoX_4Aeg_899403009")]
public partial class EventFrequency1CodeDropdownSource : EnumMetadataManager<EventFrequency1Code,IEventFrequency1CodeDropdownRow,EventFrequency1CodeDropdownRow>
{
    public EventFrequency1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventFrequency1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
