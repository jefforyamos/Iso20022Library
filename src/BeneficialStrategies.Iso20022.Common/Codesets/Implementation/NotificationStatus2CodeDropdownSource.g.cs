﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NotificationStatus2Code.  ISO2002 ID# _aNwLd9p-Ed-ak6NoX_4Aeg_-174896821.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status to define if the occurrence of the event contained in the notification is confirmed or unconfirmed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INotificationStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aNwLd9p-Ed-ak6NoX_4Aeg_-174896821")]
public partial class NotificationStatus2CodeDropdownSource : EnumMetadataManager<NotificationStatus2Code,INotificationStatus2CodeDropdownRow,NotificationStatus2CodeDropdownRow>
{
    public NotificationStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NotificationStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}