﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EventClassificationCode.  ISO2002 ID# _ajDtENp-Ed-ak6NoX_4Aeg_-407135956.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides information about how the holder must participate in the event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EventClassificationCodeDropdownSource"/>.
/// Implements <seealso cref="IEventClassificationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ajDtENp-Ed-ak6NoX_4Aeg_-407135956")]
public partial class EventClassificationCodeDropdownRow : EnumMetadataItem<EventClassificationCode>, IEventClassificationCodeDropdownRow
{
    /// <summary>
    /// Provides information about how the holder must participate in the event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EventClassificationCodeDropdownRow(EventClassificationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
