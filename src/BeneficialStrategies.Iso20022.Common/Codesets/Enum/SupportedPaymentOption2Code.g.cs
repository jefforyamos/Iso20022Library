﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SupportedPaymentOption2Code.  ISO2002 ID# _ZiQqIU7GEeyGi9JAv6wq7Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the options supported for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZiQqIU7GEeyGi9JAv6wq7Q")]
[Description(@"Specifies the options supported for a payment transaction.")]
[DerivedFrom(typeof(SupportedPaymentOptionCode))]
public enum SupportedPaymentOption2Code
{
    /// <summary>
    /// The entity supports a partial approval of the payment transaction.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZonJwU7GEeyGi9JAv6wq7Q")]
    [Description(@"The entity supports a partial approval of the payment transaction.")]
    PartialApproval = SupportedPaymentOptionCode.PartialApproval, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back).
    /// Encoded/decoded by serializers as "MSRV".
    /// </summary>
    [EnumMember(Value = "MSRV")]
    [IsoId("_ZonJw07GEeyGi9JAv6wq7Q")]
    [Description(@"The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back).")]
    PaymentApprovalOnly = SupportedPaymentOptionCode.PaymentApprovalOnly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sender support IssuerInstalment proposals to the Cardholder.
    /// Encoded/decoded by serializers as "INSI".
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_hbKgEU7GEeyGi9JAv6wq7Q")]
    [Description(@"The sender support IssuerInstalment proposals to the Cardholder.")]
    IssuerInstalment = SupportedPaymentOptionCode.IssuerInstalment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The sender is able to support Single Tap transaction.
    /// Encoded/decoded by serializers as "PINQ".
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_hk3OoU7GEeyGi9JAv6wq7Q")]
    [Description(@"The sender is able to support Single Tap transaction.")]
    PINRequest = SupportedPaymentOptionCode.PINRequest, // same ordinal as derivation source for type conversions
    
}
