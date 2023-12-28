﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentCancellationRejection2Code.  ISO2002 ID# _t8xsUFkyEeGeoaLUQk__nA_564743882.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Returned when a request for cancellation cannot be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t8xsUFkyEeGeoaLUQk__nA_564743882")]
[Description(@"Returned when a request for cancellation cannot be executed.")]
[DerivedFrom(typeof(PaymentCancellationRejectionCode))]
public enum PaymentCancellationRejection2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LegalDecision".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t8xsUVkyEeGeoaLUQk__nA_904992085")]
    [Description(@"??")]
    LegalDecision,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AgentDecision".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t8xsUlkyEeGeoaLUQk__nA_1782896849")]
    [Description(@"??")]
    AgentDecision,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerDecision".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t8xsU1kyEeGeoaLUQk__nA_710891790")]
    [Description(@"??")]
    CustomerDecision,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AlreadyReturned".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t8xsVFkyEeGeoaLUQk__nA_1164979059")]
    [Description(@"??")]
    AlreadyReturned,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoAnswerFromCustomer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t862QFkyEeGeoaLUQk__nA_-520965957")]
    [Description(@"??")]
    NoAnswerFromCustomer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoOriginalTransactionReceived".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t862QVkyEeGeoaLUQk__nA_-1641009312")]
    [Description(@"??")]
    NoOriginalTransactionReceived,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosedAccountNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t862QlkyEeGeoaLUQk__nA_-538589492")]
    [Description(@"??")]
    ClosedAccountNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientFunds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t862Q1kyEeGeoaLUQk__nA_-2038615569")]
    [Description(@"??")]
    InsufficientFunds,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentCancellationRejection2CodeMetadataExtensions
{
    private static readonly PaymentCancellationRejection2CodeDropdownSource _dropdownSource = new PaymentCancellationRejection2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentCancellationRejection2CodeDropdownRow GetMetadata(this PaymentCancellationRejection2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

