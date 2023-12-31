﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NotificationStatusCode.  ISO2002 ID# _aN5VZdp-Ed-ak6NoX_4Aeg_-927913400.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the occurrence of the event contained in the notification is confirmed or unconfirmed. Details of the event can be complete or incomplete.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aN5VZdp-Ed-ak6NoX_4Aeg_-927913400")]
[Description(@"Specifies if the occurrence of the event contained in the notification is confirmed or unconfirmed. Details of the event can be complete or incomplete.")]
[Derivations(typeof(NotificationStatus1Code),typeof(NotificationStatus2Code))]
// External derivations that should be provided by the proper interface are: 
public enum NotificationStatusCode
{
    /// <summary>
    /// The notification contains all the details.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_aN5VZtp-Ed-ak6NoX_4Aeg_-2057646880")]
    [Description(@"The notification contains all the details.")]
    Complete,
    
    /// <summary>
    /// Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.
    /// Encoded/decoded by serializers as "PREC".
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_aN5VZ9p-Ed-ak6NoX_4Aeg_-1569105629")]
    [Description(@"Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.")]
    PreliminaryEventConfirmed,
    
    /// <summary>
    /// Notification may not contain complete details as the occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.
    /// Encoded/decoded by serializers as "PREU".
    /// </summary>
    [EnumMember(Value = "PREU")]
    [IsoId("_aN5VaNp-Ed-ak6NoX_4Aeg_-313114775")]
    [Description(@"Notification may not contain complete details as the occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.")]
    PreliminaryEventUnconfirmed,
    
    /// <summary>
    /// Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.
    /// Encoded/decoded by serializers as "ECON".
    /// </summary>
    [EnumMember(Value = "ECON")]
    [IsoId("_aODGYNp-Ed-ak6NoX_4Aeg_373949805")]
    [Description(@"Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.")]
    EventConfirmed,
    
    /// <summary>
    /// The occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.
    /// Encoded/decoded by serializers as "EUNC".
    /// </summary>
    [EnumMember(Value = "EUNC")]
    [IsoId("_aODGYdp-Ed-ak6NoX_4Aeg_377642934")]
    [Description(@"The occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.")]
    EventUnconfirmed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NotificationStatusCodeMetadataExtensions
{
    private static readonly NotificationStatusCodeDropdownSource _dropdownSource = new NotificationStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INotificationStatusCodeDropdownRow GetMetadata(this NotificationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


