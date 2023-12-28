﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SystemEventType2Code.  ISO2002 ID# _ZRZQ5dp-Ed-ak6NoX_4Aeg_1212494654.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of event related to a system's operation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SystemEventType2CodeDropdownSource"/>.
/// Implements <seealso cref="ISystemEventType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZRZQ5dp-Ed-ak6NoX_4Aeg_1212494654")]
public partial class SystemEventType2CodeDropdownRow : EnumMetadataItem<SystemEventType2Code>, ISystemEventType2CodeDropdownRow
{
    /// <summary>
    /// Specifies a type of event related to a system's operation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SystemEventType2CodeDropdownRow(SystemEventType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}