﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GoodAndServiceDeliveryChannel1Code.  ISO2002 ID# _Rfj7kD5KEeyHI64WSlzTlg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that specifies the good or service delivery channel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rfj7kD5KEeyHI64WSlzTlg")]
[Description(@"Code that specifies the good or service delivery channel.")]
[DerivedFrom(typeof(GoodAndServiceDeliveryChannelCode))]
public enum GoodAndServiceDeliveryChannel1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ElectronicDelivery.".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UWH5AT5KEeyHI64WSlzTlg")]
    [Description(@"??")]
    ElectronicDelivery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LocalPickUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UbhWYT5KEeyHI64WSlzTlg")]
    [Description(@"??")]
    LocalPickUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoDelivery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Uf_msT5KEeyHI64WSlzTlg")]
    [Description(@"??")]
    NoDelivery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UlHXQT5KEeyHI64WSlzTlg")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UqV1gT5KEeyHI64WSlzTlg")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShippingToCardholderBillingAddress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UvaiwT5KEeyHI64WSlzTlg")]
    [Description(@"??")]
    ShippingToCardholderBillingAddress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShippingToConsumerSpecifiedShippingAddress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Uz-5sT5KEeyHI64WSlzTlg")]
    [Description(@"??")]
    ShippingToConsumerSpecifiedShippingAddress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GoodAndServiceDeliveryChannel1CodeMetadataExtensions
{
    private static readonly GoodAndServiceDeliveryChannel1CodeDropdownSource _dropdownSource = new GoodAndServiceDeliveryChannel1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGoodAndServiceDeliveryChannel1CodeDropdownRow GetMetadata(this GoodAndServiceDeliveryChannel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

