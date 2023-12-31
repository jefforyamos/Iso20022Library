﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReservationType2Code.  ISO2002 ID# _8KDc86MgEeCJ6YNENx4h-w_-1329725720.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the precise type of reservation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8KDc86MgEeCJ6YNENx4h-w_-1329725720")]
[Description(@"Specifies the precise type of reservation.")]
[DerivedFrom(typeof(ReservationTypeCode))]
public enum ReservationType2Code
{
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.
    /// Encoded/decoded by serializers as "CashReservation".
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_8KDc9KMgEeCJ6YNENx4h-w_-2072444791")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.")]
    CashReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as "UrgentPaymentReservation".
    /// </summary>
    [EnumMember(Value = "UPAR")]
    [IsoId("_8KDc9aMgEeCJ6YNENx4h-w_-2083543568")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.")]
    UrgentPaymentReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as "NetSSSReservation".
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_8KDc9qMgEeCJ6YNENx4h-w_58010523")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.")]
    NetSSSReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.
    /// Encoded/decoded by serializers as "HighlyUrgentPaymentReservation".
    /// </summary>
    [EnumMember(Value = "HPAR")]
    [IsoId("_8KDc96MgEeCJ6YNENx4h-w_643957549")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.")]
    HighlyUrgentPaymentReservation,
    
    /// <summary>
    /// Amount above which funds will be destined for investment.
    /// Encoded/decoded by serializers as "ThresholdForInvestment".
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_8KMm4KMgEeCJ6YNENx4h-w_-428047510")]
    [Description(@"Amount above which funds will be destined for investment.")]
    ThresholdForInvestment,
    
    /// <summary>
    /// Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as "Blocked".
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_8KMm4aMgEeCJ6YNENx4h-w_-745824171")]
    [Description(@"Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReservationType2CodeMetadataExtensions
{
    private static readonly ReservationType2CodeDropdownSource _dropdownSource = new ReservationType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReservationType2CodeDropdownRow GetMetadata(this ReservationType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


