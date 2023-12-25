﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LocationCategoryV2Code.  ISO2002 ID# _TweHIFDdEeu8Rss-tto59A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Location category code of the place where the merchant actually performed the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TweHIFDdEeu8Rss-tto59A")]
[Description(@"Location category code of the place where the merchant actually performed the transaction.")]
public enum LocationCategoryV2Code
{
    /// <summary>
    /// Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane,
    /// taxi, etc).
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_h8FRTVDdEeu8Rss-tto59A")]
    [Description(@"Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane, taxi, etc).")]
    ABRD,
    
    /// <summary>
    /// Customer home.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_h8FRTlDdEeu8Rss-tto59A")]
    [Description(@"Customer home.")]
    HOME,
    
    /// <summary>
    /// Indoor terminal.
    /// </summary>
    [EnumMember(Value = "INDR")]
    [IsoId("_h8FRT1DdEeu8Rss-tto59A")]
    [Description(@"Indoor terminal.")]
    INDR,
    
    /// <summary>
    /// Terminal incorporated in the pump dispensing petrol.
    /// </summary>
    [EnumMember(Value = "IPMP")]
    [IsoId("_h8FRUFDdEeu8Rss-tto59A")]
    [Description(@"Terminal incorporated in the pump dispensing petrol.")]
    IPMP,
    
    /// <summary>
    /// Mail order or telephone order.
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_h8FRUVDdEeu8Rss-tto59A")]
    [Description(@"Mail order or telephone order.")]
    MOTO,
    
    /// <summary>
    /// Multiple terminals linked to a unique sale terminal.
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_h8PCQFDdEeu8Rss-tto59A")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MPOI,
    
    /// <summary>
    /// Outdoor terminal serving several petrol pumps.
    /// </summary>
    [EnumMember(Value = "MPMP")]
    [IsoId("_h8PCQVDdEeu8Rss-tto59A")]
    [Description(@"Outdoor terminal serving several petrol pumps.")]
    MPMP,
    
    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_h8PCQlDdEeu8Rss-tto59A")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MSLE,
    
    /// <summary>
    /// Nomadic is used when the merchant is traveling to different locations (e.g fair or
    /// sport events, home delivery, food truck).
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_h8PCQ1DdEeu8Rss-tto59A")]
    [Description(@"Nomadic is used when the merchant is traveling to different locations (e.g fair or sport events, home delivery, food truck).")]
    NMDC,
    
    /// <summary>
    /// Fixed location, for example in a shop.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_h8PCRFDdEeu8Rss-tto59A")]
    [Description(@"Fixed location, for example in a shop.")]
    FIXD,
    
    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_h8PCRVDdEeu8Rss-tto59A")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SSLE,
    
    /// <summary>
    /// Terminal integrated in a vending machine.
    /// </summary>
    [EnumMember(Value = "VNDG")]
    [IsoId("_h8PCRlDdEeu8Rss-tto59A")]
    [Description(@"Terminal integrated in a vending machine.")]
    VNDG,
    
    /// <summary>
    /// Virtual Shop is used for any ecommerce solution.
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_h8PCR1DdEeu8Rss-tto59A")]
    [Description(@"Virtual Shop is used for any ecommerce solution.")]
    VIRT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LocationCategoryV2CodeMetadataExtensions
{
    private static readonly LocationCategoryV2CodeDropdownSource _dropdownSource = new LocationCategoryV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILocationCategoryV2CodeDropdownRow GetMetadata(this LocationCategoryV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


