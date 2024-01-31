﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalServiceType1Code.  ISO2002 ID# _kKF0sBZdEeiwvuY-sPnsNg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of additional service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kKF0sBZdEeiwvuY-sPnsNg")]
[Description(@"Type of additional service.")]
[DerivedFrom(typeof(AdditionalServiceTypeCode))]
public enum AdditionalServiceType1Code
{
    /// <summary>
    /// Card activation
    /// Encoded/decoded by serializers as "CACT".
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_l_7U8RZdEeiwvuY-sPnsNg")]
    [Description(@"Card activation")]
    CardActivation = AdditionalServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchase of goods or services with cashback
    /// Encoded/decoded by serializers as "CSHB".
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_mLhg8RZdEeiwvuY-sPnsNg")]
    [Description(@"Purchase of goods or services with cashback")]
    CashBack = AdditionalServiceTypeCode.CashBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dynamic Currency Conversion (DCC)
    /// Encoded/decoded by serializers as "DCCV".
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_mcVkIRZdEeiwvuY-sPnsNg")]
    [Description(@"Dynamic Currency Conversion (DCC)")]
    DCC = AdditionalServiceTypeCode.DCC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instant payment from a cardholder's account to an acceptor's account
    /// Encoded/decoded by serializers as "INTP".
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_mmdJcRZdEeiwvuY-sPnsNg")]
    [Description(@"Instant payment from a cardholder's account to an acceptor's account")]
    InstantPayment = AdditionalServiceTypeCode.InstantPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instant transfer of funds from a payer's account to a payee's account.
    /// Encoded/decoded by serializers as "INTT".
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_mw3psRZdEeiwvuY-sPnsNg")]
    [Description(@"Instant transfer of funds from a payer's account to a payee's account.")]
    InstantTransfer = AdditionalServiceTypeCode.InstantTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loyalty services
    /// Encoded/decoded by serializers as "LOYT".
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_m-jgYRZdEeiwvuY-sPnsNg")]
    [Description(@"Loyalty services")]
    Loyalty = AdditionalServiceTypeCode.Loyalty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of additional service at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nMi5ERZdEeiwvuY-sPnsNg")]
    [Description(@"Other type of additional service at national level")]
    OtherNational = AdditionalServiceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of additional service at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_narbsRZdEeiwvuY-sPnsNg")]
    [Description(@"Other type of additional service at private level")]
    OtherPrivate = AdditionalServiceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel (amount could be absent).
    /// Encoded/decoded by serializers as "PRST".
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_nl1i0RZdEeiwvuY-sPnsNg")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel (amount could be absent).")]
    PreStagedTransaction = AdditionalServiceTypeCode.PreStagedTransaction, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalServiceType1CodeMetadataExtensions
{
    private static readonly AdditionalServiceType1CodeDropdownSource _dropdownSource = new AdditionalServiceType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalServiceType1CodeDropdownRow GetMetadata(this AdditionalServiceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


