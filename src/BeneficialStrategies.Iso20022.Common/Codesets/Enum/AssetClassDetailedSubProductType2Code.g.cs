﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType2Code.  ISO2002 ID# _4NUJgA2eEeW72qLtWESimw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Softs.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4NUJgA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Softs.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RobustaCoffee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PV51sQ2fEeW72qLtWESimw")]
    [Description(@"??")]
    RobustaCoffee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cocoa".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_P_aswQ2fEeW72qLtWESimw")]
    [Description(@"??")]
    Cocoa,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RawSugar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_RqOowQ2fEeW72qLtWESimw")]
    [Description(@"??")]
    RawSugar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WhiteSugar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_S_xfYQ2fEeW72qLtWESimw")]
    [Description(@"??")]
    WhiteSugar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iQv5oQ2gEeW72qLtWESimw")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassDetailedSubProductType2CodeMetadataExtensions
{
    private static readonly AssetClassDetailedSubProductType2CodeDropdownSource _dropdownSource = new AssetClassDetailedSubProductType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassDetailedSubProductType2CodeDropdownRow GetMetadata(this AssetClassDetailedSubProductType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


