﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventFrequency1Code.  ISO2002 ID# _ajNeF9p-Ed-ak6NoX_4Aeg_899403009.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventFrequency1CodeDropdownSource"/>.
/// Implements <seealso cref="IEventFrequency1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajNeF9p-Ed-ak6NoX_4Aeg_899403009")]
public partial class EventFrequency1CodeDropdownRow : EnumMetadataItem<EventFrequency1Code>, IEventFrequency1CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventFrequency1CodeDropdownRow(EventFrequency1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
