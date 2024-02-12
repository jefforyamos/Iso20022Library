﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReservationTypeCode.  ISO2002 ID# _ZUrOYNp-Ed-ak6NoX_4Aeg_-459088300.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the precise type of reservation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUrOYNp-Ed-ak6NoX_4Aeg_-459088300")]
[Description(@"Specifies the precise type of reservation.")]
[Derivations(typeof(ReservationType1Code),typeof(ReservationType2Code))]
public enum ReservationTypeCode
{
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.
    /// Encoded/decoded by serializers as "CARE".
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_ZUrOYdp-Ed-ak6NoX_4Aeg_-459087850")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.")]
    CashReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as "UPAR".
    /// </summary>
    [EnumMember(Value = "UPAR")]
    [IsoId("_ZUrOYtp-Ed-ak6NoX_4Aeg_-451703214")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.")]
    UrgentPaymentReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as "NSSR".
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_ZUrOY9p-Ed-ak6NoX_4Aeg_-451703172")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.")]
    NetSSSReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.
    /// Encoded/decoded by serializers as "HPAR".
    /// </summary>
    [EnumMember(Value = "HPAR")]
    [IsoId("_ZUrOZNp-Ed-ak6NoX_4Aeg_-451703129")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.")]
    HighlyUrgentPaymentReservation,
    
    /// <summary>
    /// Amount above which funds will be destined for investment.
    /// Encoded/decoded by serializers as "THRE".
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_ZUrOZdp-Ed-ak6NoX_4Aeg_-451703094")]
    [Description(@"Amount above which funds will be destined for investment.")]
    ThresholdForInvestment,
    
    /// <summary>
    /// Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as "BLKD".
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_8Jv696MgEeCJ6YNENx4h-w_-766777941")]
    [Description(@"Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked,
    
}
