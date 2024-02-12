﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderStatus3Code.  ISO2002 ID# _Vep_Etp-Ed-ak6NoX_4Aeg_-933053776.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vep_Etp-Ed-ak6NoX_4Aeg_-933053776")]
[Description(@"Specifies the current status of the order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus3Code
{
    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as "STNP".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_Vep_E9p-Ed-ak6NoX_4Aeg_-913662626")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled.
    /// Encoded/decoded by serializers as "CANP".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_Vep_FNp-Ed-ak6NoX_4Aeg_-887802624")]
    [Description(@"Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled.")]
    PendingCancel = OrderStatusCode.PendingCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for cancellation instruction for the order has been accepted and processed; the order has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_Vep_Fdp-Ed-ak6NoX_4Aeg_-672621299")]
    [Description(@"Request for cancellation instruction for the order has been accepted and processed; the order has been cancelled.")]
    Completed = OrderStatusCode.Completed, // same ordinal as derivation source for type conversions
    
}
