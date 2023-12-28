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
    /// ??
    /// Encoded/decoded by serializers as "Indoor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3wtnUZX5EeWMQt4mOczoDw")]
    [Description(@"??")]
    Indoor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsidePump".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_34m_EZX5EeWMQt4mOczoDw")]
    [Description(@"??")]
    InsidePump,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultiplePOITerminal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4HaQEZX5EeWMQt4mOczoDw")]
    [Description(@"??")]
    MultiplePOITerminal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultiplePump".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4QWwsZX5EeWMQt4mOczoDw")]
    [Description(@"??")]
    MultiplePump,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultipleSaleTerminal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4ZllMZX5EeWMQt4mOczoDw")]
    [Description(@"??")]
    MultipleSaleTerminal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SingleSaleTerminal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4oC38ZX5EeWMQt4mOczoDw")]
    [Description(@"??")]
    SingleSaleTerminal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VendingMachine".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4up2QZX5EeWMQt4mOczoDw")]
    [Description(@"??")]
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

