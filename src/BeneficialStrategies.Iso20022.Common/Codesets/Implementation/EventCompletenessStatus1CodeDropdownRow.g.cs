﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventCompletenessStatus1Code.  ISO2002 ID# _ajDtFNp-Ed-ak6NoX_4Aeg_1571232805.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the details provided about an event are complete or incomplete.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventCompletenessStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IEventCompletenessStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajDtFNp-Ed-ak6NoX_4Aeg_1571232805")]
public partial class EventCompletenessStatus1CodeDropdownRow : EnumMetadataItem<EventCompletenessStatus1Code>, IEventCompletenessStatus1CodeDropdownRow
{
    /// <summary>
    /// Indicates whether the details provided about an event are complete or incomplete.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventCompletenessStatus1CodeDropdownRow(EventCompletenessStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
