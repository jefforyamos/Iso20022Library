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
[Derivations(typeof(LocationCategory4Code))]
public enum LocationCategoryV2Code
{
    /// <summary>
    /// Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane,
    /// taxi, etc).
    /// Encoded/decoded by serializers as "ABRD".
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_h8FRTVDdEeu8Rss-tto59A")]
    [Description(@"Aboard is used when the sale is done in a vehicle (e.g a bus, train, ship, airplane,|taxi, etc).")]
    Aboard,
    
    /// <summary>
    /// Customer home.
    /// Encoded/decoded by serializers as "HOME".
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_h8FRTlDdEeu8Rss-tto59A")]
    [Description(@"Customer home.")]
    Home,
    
    /// <summary>
    /// Indoor terminal.
    /// Encoded/decoded by serializers as "INDR".
    /// </summary>
    [EnumMember(Value = "INDR")]
    [IsoId("_h8FRT1DdEeu8Rss-tto59A")]
    [Description(@"Indoor terminal.")]
    Indoor,
    
    /// <summary>
    /// Terminal incorporated in the pump dispensing petrol.
    /// Encoded/decoded by serializers as "IPMP".
    /// </summary>
    [EnumMember(Value = "IPMP")]
    [IsoId("_h8FRUFDdEeu8Rss-tto59A")]
    [Description(@"Terminal incorporated in the pump dispensing petrol.")]
    InsidePump,
    
    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as "MOTO".
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_h8FRUVDdEeu8Rss-tto59A")]
    [Description(@"Mail order or telephone order.")]
    MailOrderTelephoneOrder,
    
    /// <summary>
    /// Multiple terminals linked to a unique sale terminal.
    /// Encoded/decoded by serializers as "MPOI".
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_h8PCQFDdEeu8Rss-tto59A")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MultiplePOITerminal,
    
    /// <summary>
    /// Outdoor terminal serving several petrol pumps.
    /// Encoded/decoded by serializers as "MPMP".
    /// </summary>
    [EnumMember(Value = "MPMP")]
    [IsoId("_h8PCQVDdEeu8Rss-tto59A")]
    [Description(@"Outdoor terminal serving several petrol pumps.")]
    MultiplePump,
    
    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// Encoded/decoded by serializers as "MSLE".
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_h8PCQlDdEeu8Rss-tto59A")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MultipleSaleTerminal,
    
    /// <summary>
    /// Nomadic is used when the merchant is traveling to different locations (e.g fair or
    /// sport events, home delivery, food truck).
    /// Encoded/decoded by serializers as "NMDC".
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_h8PCQ1DdEeu8Rss-tto59A")]
    [Description(@"Nomadic is used when the merchant is traveling to different locations (e.g fair or|sport events, home delivery, food truck).")]
    Nomadic,
    
    /// <summary>
    /// Fixed location, for example in a shop.
    /// Encoded/decoded by serializers as "FIXD".
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_h8PCRFDdEeu8Rss-tto59A")]
    [Description(@"Fixed location, for example in a shop.")]
    PhysicalShop,
    
    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// Encoded/decoded by serializers as "SSLE".
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_h8PCRVDdEeu8Rss-tto59A")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SingleSaleTerminal,
    
    /// <summary>
    /// Terminal integrated in a vending machine.
    /// Encoded/decoded by serializers as "VNDG".
    /// </summary>
    [EnumMember(Value = "VNDG")]
    [IsoId("_h8PCRlDdEeu8Rss-tto59A")]
    [Description(@"Terminal integrated in a vending machine.")]
    VendingMachine,
    
    /// <summary>
    /// Virtual Shop is used for any ecommerce solution.
    /// Encoded/decoded by serializers as "VIRT".
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_h8PCR1DdEeu8Rss-tto59A")]
    [Description(@"Virtual Shop is used for any ecommerce solution.")]
    VirtualShop,
    
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


