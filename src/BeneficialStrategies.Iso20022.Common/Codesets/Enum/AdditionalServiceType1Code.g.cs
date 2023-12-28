﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalServiceType1Code.  ISO2002 ID# _kKF0sBZdEeiwvuY-sPnsNg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "CardActivation".
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_l_7U8RZdEeiwvuY-sPnsNg")]
    [Description(@"Card activation")]
    CardActivation,
    
    /// <summary>
    /// Purchase of goods or services with cashback
    /// Encoded/decoded by serializers as "CashBack".
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_mLhg8RZdEeiwvuY-sPnsNg")]
    [Description(@"Purchase of goods or services with cashback")]
    CashBack,
    
    /// <summary>
    /// Dynamic Currency Conversion (DCC)
    /// Encoded/decoded by serializers as "DCC".
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_mcVkIRZdEeiwvuY-sPnsNg")]
    [Description(@"Dynamic Currency Conversion (DCC)")]
    DCC,
    
    /// <summary>
    /// Instant payment from a cardholder's account to an acceptor's account
    /// Encoded/decoded by serializers as "InstantPayment".
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_mmdJcRZdEeiwvuY-sPnsNg")]
    [Description(@"Instant payment from a cardholder's account to an acceptor's account")]
    InstantPayment,
    
    /// <summary>
    /// Instant transfer of funds from a payer's account to a payee's account.
    /// Encoded/decoded by serializers as "InstantTransfer".
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_mw3psRZdEeiwvuY-sPnsNg")]
    [Description(@"Instant transfer of funds from a payer's account to a payee's account.")]
    InstantTransfer,
    
    /// <summary>
    /// Loyalty services
    /// Encoded/decoded by serializers as "Loyalty".
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_m-jgYRZdEeiwvuY-sPnsNg")]
    [Description(@"Loyalty services")]
    Loyalty,
    
    /// <summary>
    /// Other type of additional service at national level
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nMi5ERZdEeiwvuY-sPnsNg")]
    [Description(@"Other type of additional service at national level")]
    OtherNational,
    
    /// <summary>
    /// Other type of additional service at private level
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_narbsRZdEeiwvuY-sPnsNg")]
    [Description(@"Other type of additional service at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel (amount could be absent).
    /// Encoded/decoded by serializers as "PreStagedTransaction".
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_nl1i0RZdEeiwvuY-sPnsNg")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel (amount could be absent).")]
    PreStagedTransaction,
    
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


