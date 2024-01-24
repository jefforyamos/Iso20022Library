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
    /// Reported when the cancellation cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as "LEGL".
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_t8xsUVkyEeGeoaLUQk__nA_904992085")]
    [Description(@"Reported when the cancellation cannot be accepted because of regulatory rules.")]
    LegalDecision = PaymentCancellationRejectionCode.LegalDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of an agent refuses to cancel.
    /// Encoded/decoded by serializers as "AGNT".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_t8xsUlkyEeGeoaLUQk__nA_1782896849")]
    [Description(@"Reported when the cancellation cannot be accepted because of an agent refuses to cancel.")]
    AgentDecision = PaymentCancellationRejectionCode.AgentDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of a customer decision (Creditor).
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t8xsU1kyEeGeoaLUQk__nA_710891790")]
    [Description(@"Reported when the cancellation cannot be accepted because of a customer decision (Creditor).")]
    CustomerDecision = PaymentCancellationRejectionCode.CustomerDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation not accepted as the transaction has already been returned.
    /// Encoded/decoded by serializers as "ARDT".
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_t8xsVFkyEeGeoaLUQk__nA_1164979059")]
    [Description(@"Cancellation not accepted as the transaction has already been returned.")]
    AlreadyReturned = PaymentCancellationRejectionCode.AlreadyReturned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No response from beneficiary (to the cancellation request).
    /// Encoded/decoded by serializers as "NOAS".
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_t862QFkyEeGeoaLUQk__nA_-520965957")]
    [Description(@"No response from beneficiary (to the cancellation request).")]
    NoAnswerFromCustomer = PaymentCancellationRejectionCode.NoAnswerFromCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original transaction (subject to cancellation) never received.
    /// Encoded/decoded by serializers as "NOOR".
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_t862QVkyEeGeoaLUQk__nA_-1641009312")]
    [Description(@"Original transaction (subject to cancellation) never received.")]
    NoOriginalTransactionReceived = PaymentCancellationRejectionCode.NoOriginalTransactionReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number specified has been closed on the receiver’s books.
    /// Encoded/decoded by serializers as "AC04".
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t862QlkyEeGeoaLUQk__nA_-538589492")]
    [Description(@"Account number specified has been closed on the receiver’s books.")]
    ClosedAccountNumber = PaymentCancellationRejectionCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as "AM04".
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_t862Q1kyEeGeoaLUQk__nA_-2038615569")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = PaymentCancellationRejectionCode.InsufficientFunds, // same ordinal as derivation source for type conversions
    
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


