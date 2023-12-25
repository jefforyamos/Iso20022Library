﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NotificationToReceiveStatusCode.  ISO2002 ID# _aODGYtp-Ed-ak6NoX_4Aeg_1172047099.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether or not the event as mentioned in the notification occurred. Details of the event can be different from the details as per notification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INotificationToReceiveStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aODGYtp-Ed-ak6NoX_4Aeg_1172047099")]
public partial class NotificationToReceiveStatusCodeDropdownSource : EnumMetadataManager<NotificationToReceiveStatusCode,INotificationToReceiveStatusCodeDropdownRow,NotificationToReceiveStatusCodeDropdownRow>
{
    public NotificationToReceiveStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NotificationToReceiveStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
