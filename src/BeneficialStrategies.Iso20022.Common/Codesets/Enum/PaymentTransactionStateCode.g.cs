﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentTransactionStateCode.  ISO2002 ID# _fEf3YKHmEeagRbKvRt3LnA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the different states which a payment transaction can be in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fEf3YKHmEeagRbKvRt3LnA")]
[Description(@"Contains the different states which a payment transaction can be in.")]
[Derivations(typeof(PaymentTransactionState1Code))]
// External derivations that should be provided by the proper interface are: 
public enum PaymentTransactionStateCode
{
    /// <summary>
    /// Transaction is received by my institution.
    /// Encoded/decoded by serializers as "RCMY".
    /// </summary>
    [EnumMember(Value = "RCMY")]
    [IsoId("_nmQdEKHmEeagRbKvRt3LnA")]
    [Description(@"Transaction is received by my institution.")]
    ReceivedByMyInstitution,
    
    /// <summary>
    /// Transaction is sent by my institution.
    /// Encoded/decoded by serializers as "STMY".
    /// </summary>
    [EnumMember(Value = "STMY")]
    [IsoId("_v4WPEKHmEeagRbKvRt3LnA")]
    [Description(@"Transaction is sent by my institution.")]
    SentByMyInstitution,
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.
    /// Encoded/decoded by serializers as "STDD".
    /// </summary>
    [EnumMember(Value = "STDD")]
    [IsoId("_52ZMkKHmEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.")]
    SentByDebtorAgentOrDebtor,
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.
    /// Encoded/decoded by serializers as "RCCC".
    /// </summary>
    [EnumMember(Value = "RCCC")]
    [IsoId("_AmsbsKHnEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.")]
    ReceivedAtCreditorAgentOrCreditor,
    
    /// <summary>
    /// Transaction is credited.
    /// Encoded/decoded by serializers as "CRED".
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_J8DokKHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is credited.")]
    Credited,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentTransactionStateCodeMetadataExtensions
{
    private static readonly PaymentTransactionStateCodeDropdownSource _dropdownSource = new PaymentTransactionStateCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentTransactionStateCodeDropdownRow GetMetadata(this PaymentTransactionStateCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


