﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NotificationType3Code.  ISO2002 ID# _u-L_cK7PEemG7MmivSuE5g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of notification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NotificationType3CodeDropdownSource"/>.
/// Implements <seealso cref="INotificationType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_u-L_cK7PEemG7MmivSuE5g")]
public partial class NotificationType3CodeDropdownRow : EnumMetadataItem<NotificationType3Code>, INotificationType3CodeDropdownRow
{
    /// <summary>
    /// Specifies a type of notification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NotificationType3CodeDropdownRow(NotificationType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
