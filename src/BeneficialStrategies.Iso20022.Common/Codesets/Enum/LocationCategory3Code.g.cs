﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LocationCategory3Code.  ISO2002 ID# _0dI9wJX5EeWMQt4mOczoDw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of integration of the POI terminal in the sale environment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0dI9wJX5EeWMQt4mOczoDw")]
[Description(@"Indicates the type of integration of the POI terminal in the sale environment.")]
[DerivedFrom(typeof(LocationCategoryCode))]
public enum LocationCategory3Code
{
    /// <summary>
    /// Indoor terminal.
    /// Encoded/decoded by serializers as "Indoor".
    /// </summary>
    [EnumMember(Value = "INDR")]
    [IsoId("_3wtnUZX5EeWMQt4mOczoDw")]
    [Description(@"Indoor terminal.")]
    Indoor,
    
    /// <summary>
    /// Terminal incorporated in the pump dispensing petrol.
    /// Encoded/decoded by serializers as "InsidePump".
    /// </summary>
    [EnumMember(Value = "IPMP")]
    [IsoId("_34m_EZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal incorporated in the pump dispensing petrol.")]
    InsidePump,
    
    /// <summary>
    /// Multiple terminals linked to a unique sale terminal.
    /// Encoded/decoded by serializers as "MultiplePOITerminal".
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_4HaQEZX5EeWMQt4mOczoDw")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MultiplePOITerminal,
    
    /// <summary>
    /// Outdoor terminal serving several petrol pumps.
    /// Encoded/decoded by serializers as "MultiplePump".
    /// </summary>
    [EnumMember(Value = "MPMP")]
    [IsoId("_4QWwsZX5EeWMQt4mOczoDw")]
    [Description(@"Outdoor terminal serving several petrol pumps.")]
    MultiplePump,
    
    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// Encoded/decoded by serializers as "MultipleSaleTerminal".
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_4ZllMZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MultipleSaleTerminal,
    
    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// Encoded/decoded by serializers as "SingleSaleTerminal".
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_4oC38ZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SingleSaleTerminal,
    
    /// <summary>
    /// Terminal integrated in a vending machine.
    /// Encoded/decoded by serializers as "VendingMachine".
    /// </summary>
    [EnumMember(Value = "VNDG")]
    [IsoId("_4up2QZX5EeWMQt4mOczoDw")]
    [Description(@"Terminal integrated in a vending machine.")]
    VendingMachine,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LocationCategory3CodeMetadataExtensions
{
    private static readonly LocationCategory3CodeDropdownSource _dropdownSource = new LocationCategory3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILocationCategory3CodeDropdownRow GetMetadata(this LocationCategory3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


