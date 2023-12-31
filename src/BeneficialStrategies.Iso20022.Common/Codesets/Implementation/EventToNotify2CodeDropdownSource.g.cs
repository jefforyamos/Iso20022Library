﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EventToNotify2Code.  ISO2002 ID# _CXj_EQ0vEeqUVL7sB4m7NA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Event the POI notifies to the Sale System.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEventToNotify2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CXj_EQ0vEeqUVL7sB4m7NA")]
public partial class EventToNotify2CodeDropdownSource : EnumMetadataManager<EventToNotify2Code,IEventToNotify2CodeDropdownRow,EventToNotify2CodeDropdownRow>
{
    public EventToNotify2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EventToNotify2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
