﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GoodAndServiceDeliveryChannelCode.  ISO2002 ID# _A9WDQD5GEeyHI64WSlzTlg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that specifies the good or service delivery channel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A9WDQD5GEeyHI64WSlzTlg")]
[Description(@"Code that specifies the good or service delivery channel.")]
public enum GoodAndServiceDeliveryChannelCode
{
    /// <summary>
    /// Pick up locally
    /// Encoded/decoded by serializers as "PULC".
    /// </summary>
    [EnumMember(Value = "PULC")]
    [IsoId("_Kg6EMD5GEeyHI64WSlzTlg")]
    [Description(@"Pick up locally")]
    LocalPickUp,
    
    /// <summary>
    /// Shipping to cardholder billing address
    /// Encoded/decoded by serializers as "SCBA".
    /// </summary>
    [EnumMember(Value = "SCBA")]
    [IsoId("_C-OgcD5HEeyHI64WSlzTlg")]
    [Description(@"Shipping to cardholder billing address")]
    ShippingToCardholderBillingAddress,
    
    /// <summary>
    /// Shipping to consumer specified shipping address
    /// Encoded/decoded by serializers as "SCSA".
    /// </summary>
    [EnumMember(Value = "SCSA")]
    [IsoId("_vkZ6ID5IEeyHI64WSlzTlg")]
    [Description(@"Shipping to consumer specified shipping address")]
    ShippingToConsumerSpecifiedShippingAddress,
    
    /// <summary>
    /// Other delivery channel defined at national level.
    /// 
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_AlgDoD5JEeyHI64WSlzTlg")]
    [Description(@"Other delivery channel defined at national level. ")]
    OtherNational,
    
    /// <summary>
    /// Other delivery channel defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_AtNOID5JEeyHI64WSlzTlg")]
    [Description(@"Other delivery channel defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// No delivery.
    /// 
    /// Encoded/decoded by serializers as "NDEL".
    /// </summary>
    [EnumMember(Value = "NDEL")]
    [IsoId("_A6LTID5JEeyHI64WSlzTlg")]
    [Description(@"No delivery. ")]
    NoDelivery,
    
    /// <summary>
    /// Electronic delivery.
    /// Encoded/decoded by serializers as "EDEL".
    /// </summary>
    [EnumMember(Value = "EDEL")]
    [IsoId("_BnV7ID5JEeyHI64WSlzTlg")]
    [Description(@"Electronic delivery.")]
    ElectronicDelivery,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GoodAndServiceDeliveryChannelCodeMetadataExtensions
{
    private static readonly GoodAndServiceDeliveryChannelCodeDropdownSource _dropdownSource = new GoodAndServiceDeliveryChannelCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGoodAndServiceDeliveryChannelCodeDropdownRow GetMetadata(this GoodAndServiceDeliveryChannelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

