﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalReservationTypeCode.  ISO2002 ID# _BGqPsBUOEeusI4XK3oQSyg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of reservation, as published in an external reservation type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BGqPsBUOEeusI4XK3oQSyg")]
[Description(@"Specifies the type of reservation, as published in an external reservation type code set. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalReservationType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalReservationTypeCode
{
    /// <summary>
    /// Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as "BLKD".
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_ut1ZYPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively or executing cash withdrawals.
    /// Encoded/decoded by serializers as "CARE".
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_ut1ZY_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively or executing cash withdrawals.")]
    CashReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.
    /// Encoded/decoded by serializers as "HPAR".
    /// </summary>
    [EnumMember(Value = "HPAR")]
    [IsoId("_ut1ZZvRYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.")]
    HighlyUrgentPaymentReservation,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as "NSSR".
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_ut_KYPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.")]
    NetSSSReservation,
    
    /// <summary>
    /// Amount above which funds will be destined for investment.
    /// Encoded/decoded by serializers as "THRE".
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_uuIUUPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount above which funds will be destined for investment.")]
    ThresholdForInvestment,
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as "UPAR".
    /// </summary>
    [EnumMember(Value = "UPAR")]
    [IsoId("_uuIUU_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.")]
    UrgentPaymentReservation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalReservationTypeCodeMetadataExtensions
{
    private static readonly ExternalReservationTypeCodeDropdownSource _dropdownSource = new ExternalReservationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalReservationTypeCodeDropdownRow GetMetadata(this ExternalReservationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


