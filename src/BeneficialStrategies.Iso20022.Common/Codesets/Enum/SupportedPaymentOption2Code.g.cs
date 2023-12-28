﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SupportedPaymentOption2Code.  ISO2002 ID# _ZiQqIU7GEeyGi9JAv6wq7Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "PartialApproval".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZonJwU7GEeyGi9JAv6wq7Q")]
    [Description(@"??")]
    PartialApproval,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentApprovalOnly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZonJw07GEeyGi9JAv6wq7Q")]
    [Description(@"??")]
    PaymentApprovalOnly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssuerInstalment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbKgEU7GEeyGi9JAv6wq7Q")]
    [Description(@"??")]
    IssuerInstalment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PINRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hk3OoU7GEeyGi9JAv6wq7Q")]
    [Description(@"??")]
    PINRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SupportedPaymentOption2CodeMetadataExtensions
{
    private static readonly SupportedPaymentOption2CodeDropdownSource _dropdownSource = new SupportedPaymentOption2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISupportedPaymentOption2CodeDropdownRow GetMetadata(this SupportedPaymentOption2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

