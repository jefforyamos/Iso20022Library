﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LocationCategory2Code.  ISO2002 ID# _H30HwHsIEeSR68OJvMfxJQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Location category of the place where the transaction is actually performed. 
/// It correspond partially to the ISO 8583: 1993, field number 22-4.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H30HwHsIEeSR68OJvMfxJQ")]
[Description(@"Location category of the place where the transaction is actually performed.  It correspond partially to the ISO 8583: 1993, field number 22-4.")]
[DerivedFrom(typeof(LocationCategoryCode))]
public enum LocationCategory2Code
{
    /// <summary>
    /// Customer home.
    /// Encoded/decoded by serializers as "Home".
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_KdgXoXsIEeSR68OJvMfxJQ")]
    [Description(@"Customer home.")]
    Home,
    
    /// <summary>
    /// Aboard a bus, train, ship, airplane, taxi, etc.
    /// Encoded/decoded by serializers as "Aboard".
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_w3820VDhEeuJG-g6zrGRtg")]
    [Description(@"Aboard a bus, train, ship, airplane, taxi, etc.")]
    Aboard,
    
    /// <summary>
    /// Fixed location, for example in a shop.
    /// Encoded/decoded by serializers as "Fixed".
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_w-zswVDhEeuJG-g6zrGRtg")]
    [Description(@"Fixed location, for example in a shop.")]
    Fixed,
    
    /// <summary>
    /// Nomadic location.
    /// Encoded/decoded by serializers as "Nomadic".
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_0crh0VDhEeuJG-g6zrGRtg")]
    [Description(@"Nomadic location.")]
    Nomadic,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LocationCategory2CodeMetadataExtensions
{
    private static readonly LocationCategory2CodeDropdownSource _dropdownSource = new LocationCategory2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILocationCategory2CodeDropdownRow GetMetadata(this LocationCategory2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


