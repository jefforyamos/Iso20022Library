﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NotificationToReceiveStatusCode.  ISO2002 ID# _aODGYtp-Ed-ak6NoX_4Aeg_1172047099.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether or not the event as mentioned in the notification occurred. Details of the event can be different from the details as per notification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NotificationToReceiveStatusCodeDropdownSource"/>.
/// Implements <seealso cref="INotificationToReceiveStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aODGYtp-Ed-ak6NoX_4Aeg_1172047099")]
public partial class NotificationToReceiveStatusCodeDropdownRow : EnumMetadataItem<NotificationToReceiveStatusCode>, INotificationToReceiveStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies whether or not the event as mentioned in the notification occurred. Details of the event can be different from the details as per notification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NotificationToReceiveStatusCodeDropdownRow(NotificationToReceiveStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
