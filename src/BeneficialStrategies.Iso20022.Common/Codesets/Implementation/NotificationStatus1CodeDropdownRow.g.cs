﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NotificationStatus1Code.  ISO2002 ID# _Vp_FU9p-Ed-ak6NoX_4Aeg_-86852675.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status to define the completeness of information contained in the notification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NotificationStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="INotificationStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vp_FU9p-Ed-ak6NoX_4Aeg_-86852675")]
public partial class NotificationStatus1CodeDropdownRow : EnumMetadataItem<NotificationStatus1Code>, INotificationStatus1CodeDropdownRow
{
    /// <summary>
    /// Status to define the completeness of information contained in the notification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NotificationStatus1CodeDropdownRow(NotificationStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
