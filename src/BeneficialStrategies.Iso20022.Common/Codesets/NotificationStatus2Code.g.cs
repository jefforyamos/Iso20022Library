﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NotificationStatus2Code.  ISO2002 ID# _aNwLd9p-Ed-ak6NoX_4Aeg_-174896821.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status to define if the occurrence of the event contained in the notification is confirmed or unconfirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNwLd9p-Ed-ak6NoX_4Aeg_-174896821")]
[Description(@"Status to define if the occurrence of the event contained in the notification is confirmed or unconfirmed.")]
[DerivedFrom(typeof(NotificationStatusCode))]
public enum NotificationStatus2Code
{
    /// <summary>
    /// Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.
    /// Encoded/decoded by serializers as &quot;ECON&quot;.
    /// </summary>
    [EnumMember(Value = "ECON")]
    [IsoId("_aNwLeNp-Ed-ak6NoX_4Aeg_-174896803")]
    [Description(@"Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.")]
    EventConfirmed = NotificationStatusCode.EventConfirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.
    /// Encoded/decoded by serializers as &quot;EUNC&quot;.
    /// </summary>
    [EnumMember(Value = "EUNC")]
    [IsoId("_aN5VYNp-Ed-ak6NoX_4Aeg_-174896795")]
    [Description(@"The occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.")]
    EventUnconfirmed = NotificationStatusCode.EventUnconfirmed, // same ordinal as derivation source for type conversions
    
}
