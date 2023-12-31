﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LocationCategory4Code.  ISO2002 ID# _3eb_cFDdEeu8Rss-tto59A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of integration of the POI terminal in the sale environment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3eb_cFDdEeu8Rss-tto59A")]
[Description(@"Indicates the type of integration of the POI terminal in the sale environment.")]
[DerivedFrom(typeof(LocationCategoryV2Code))]
public enum LocationCategory4Code
{
    /// <summary>
    /// Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane,
    /// taxi, etc).
    /// Encoded/decoded by serializers as "Aboard".
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_nvDDhFDfEeu8Rss-tto59A")]
    [Description(@"Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane, taxi, etc).")]
    Aboard,
    
    /// <summary>
    /// Nomadic is used when the merchant is traveling to different locations (e.g fair or
    /// sport events, home delivery, food truck).
    /// Encoded/decoded by serializers as "Nomadic".
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_nvMNcFDfEeu8Rss-tto59A")]
    [Description(@"Nomadic is used when the merchant is traveling to different locations (e.g fair or sport events, home delivery, food truck).")]
    Nomadic,
    
    /// <summary>
    /// Fixed location, for example in a shop.
    /// Encoded/decoded by serializers as "PhysicalShop".
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_nvMNcVDfEeu8Rss-tto59A")]
    [Description(@"Fixed location, for example in a shop.")]
    PhysicalShop,
    
    /// <summary>
    /// Virtual Shop is used for any ecommerce solution.
    /// Encoded/decoded by serializers as "VirtualShop".
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_nvMNclDfEeu8Rss-tto59A")]
    [Description(@"Virtual Shop is used for any ecommerce solution.")]
    VirtualShop,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LocationCategory4CodeMetadataExtensions
{
    private static readonly LocationCategory4CodeDropdownSource _dropdownSource = new LocationCategory4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILocationCategory4CodeDropdownRow GetMetadata(this LocationCategory4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


