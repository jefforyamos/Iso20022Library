﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionNotificationType2Code.  ISO2002 ID# _bLJAwNp-Ed-ak6NoX_4Aeg_746682206.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of notification cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bLJAwNp-Ed-ak6NoX_4Aeg_746682206")]
[Description(@"Type of notification cancellation request.")]
[DerivedFrom(typeof(CorporateActionNotificationTypeCode))]
public enum CorporateActionNotificationType2Code
{
    /// <summary>
    /// Notification sent to void a previously sent notification due to the withdrawal of the event by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bLJAwdp-Ed-ak6NoX_4Aeg_746682216")]
    [Description(@"Notification sent to void a previously sent notification due to the withdrawal of the event by the issuer.")]
    Withrawal = CorporateActionNotificationTypeCode.Withrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification requesting the cancellation of a previously sent notification.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bLJAwtp-Ed-ak6NoX_4Aeg_746682237")]
    [Description(@"Notification requesting the cancellation of a previously sent notification.")]
    Cancellation = CorporateActionNotificationTypeCode.Cancellation, // same ordinal as derivation source for type conversions
    
}
