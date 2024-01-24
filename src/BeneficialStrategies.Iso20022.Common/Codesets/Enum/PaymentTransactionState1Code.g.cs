﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentTransactionState1Code.  ISO2002 ID# _Wlue0KHnEeagRbKvRt3LnA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the different states which a payment transaction can be in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wlue0KHnEeagRbKvRt3LnA")]
[Description(@"Contains the different states which a payment transaction can be in.")]
[DerivedFrom(typeof(PaymentTransactionStateCode))]
public enum PaymentTransactionState1Code
{
    /// <summary>
    /// Transaction is credited.
    /// Encoded/decoded by serializers as "CRED".
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_YEuMYaHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is credited.")]
    Credited = PaymentTransactionStateCode.Credited, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.
    /// Encoded/decoded by serializers as "RCCC".
    /// </summary>
    [EnumMember(Value = "RCCC")]
    [IsoId("_YZBBYqHnEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.")]
    ReceivedAtCreditorAgentOrCreditor = PaymentTransactionStateCode.ReceivedAtCreditorAgentOrCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is received by my institution.
    /// Encoded/decoded by serializers as "RCMY".
    /// </summary>
    [EnumMember(Value = "RCMY")]
    [IsoId("_YsRUkqHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is received by my institution.")]
    ReceivedByMyInstitution = PaymentTransactionStateCode.ReceivedByMyInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is sent by my institution.
    /// Encoded/decoded by serializers as "STMY".
    /// </summary>
    [EnumMember(Value = "STMY")]
    [IsoId("_Yw8ZMaHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is sent by my institution.")]
    SentByMyInstitution = PaymentTransactionStateCode.SentByMyInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.
    /// Encoded/decoded by serializers as "STDD".
    /// </summary>
    [EnumMember(Value = "STDD")]
    [IsoId("_ZKEq4aHnEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.")]
    SentByDebtorAgentOrDebtor = PaymentTransactionStateCode.SentByDebtorAgentOrDebtor, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentTransactionState1CodeMetadataExtensions
{
    private static readonly PaymentTransactionState1CodeDropdownSource _dropdownSource = new PaymentTransactionState1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentTransactionState1CodeDropdownRow GetMetadata(this PaymentTransactionState1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


