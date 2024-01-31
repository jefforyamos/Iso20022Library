﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SupportedPaymentOptionCode.  ISO2002 ID# _UdiH4DANEeOqioR9srQH1g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the options supported for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UdiH4DANEeOqioR9srQH1g")]
[Description(@"Specifies the options supported for a payment transaction.")]
[Derivations(typeof(SupportedPaymentOption1Code),typeof(SupportedPaymentOption2Code))]
public enum SupportedPaymentOptionCode
{
    /// <summary>
    /// The entity supports a partial approval of the payment transaction.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_mVwtsDANEeOqioR9srQH1g")]
    [Description(@"The entity supports a partial approval of the payment transaction.")]
    PartialApproval,
    
    /// <summary>
    /// The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back).
    /// Encoded/decoded by serializers as "MSRV".
    /// </summary>
    [EnumMember(Value = "MSRV")]
    [IsoId("_s2B8wDANEeOqioR9srQH1g")]
    [Description(@"The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back).")]
    PaymentApprovalOnly,
    
    /// <summary>
    /// The sender support IssuerInstalment proposals to the Cardholder.
    /// Encoded/decoded by serializers as "INSI".
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_PfI_YE7GEeyGi9JAv6wq7Q")]
    [Description(@"The sender support IssuerInstalment proposals to the Cardholder.")]
    IssuerInstalment,
    
    /// <summary>
    /// The sender is able to support Single Tap transaction.
    /// Encoded/decoded by serializers as "PINQ".
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_UM9ZYE7GEeyGi9JAv6wq7Q")]
    [Description(@"The sender is able to support Single Tap transaction.")]
    PINRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SupportedPaymentOptionCodeMetadataExtensions
{
    private static readonly SupportedPaymentOptionCodeDropdownSource _dropdownSource = new SupportedPaymentOptionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISupportedPaymentOptionCodeDropdownRow GetMetadata(this SupportedPaymentOptionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


