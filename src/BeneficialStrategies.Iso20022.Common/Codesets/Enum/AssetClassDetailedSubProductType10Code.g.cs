﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType10Code.  ISO2002 ID# _BUgXgA2fEeW72qLtWESimw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Non-Precious.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BUgXgA2fEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Non-Precious.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType10Code
{
    /// <summary>
    /// Commodity attribute of type aluminium.
    /// Encoded/decoded by serializers as "ALUM".
    /// </summary>
    [EnumMember(Value = "ALUM")]
    [IsoId("_TEO2sQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type aluminium.")]
    Aluminium = AssetClassDetailedSubProductTypeCode.Aluminium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type aluminium alloy.
    /// Encoded/decoded by serializers as "ALUA".
    /// </summary>
    [EnumMember(Value = "ALUA")]
    [IsoId("_TLYAgQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type aluminium alloy.")]
    AluminiumAlloy = AssetClassDetailedSubProductTypeCode.AluminiumAlloy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type cobalt.
    /// Encoded/decoded by serializers as "CBLT".
    /// </summary>
    [EnumMember(Value = "CBLT")]
    [IsoId("_TtvGsQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type cobalt.")]
    Cobalt = AssetClassDetailedSubProductTypeCode.Cobalt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type copper.
    /// Encoded/decoded by serializers as "COPR".
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_UcwI0Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type copper.")]
    Copper = AssetClassDetailedSubProductTypeCode.Copper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    ///  Commodity attribute of type iron ore.
    /// Encoded/decoded by serializers as "IRON".
    /// </summary>
    [EnumMember(Value = "IRON")]
    [IsoId("_XdkOcQ2hEeW72qLtWESimw")]
    [Description(@" Commodity attribute of type iron ore.")]
    IronOre = AssetClassDetailedSubProductTypeCode.IronOre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type molybdenum.
    /// Encoded/decoded by serializers as "MOLY".
    /// </summary>
    [EnumMember(Value = "MOLY")]
    [IsoId("_YP_w8Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type molybdenum.")]
    Molybdenum = AssetClassDetailedSubProductTypeCode.Molybdenum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract).
    /// Encoded/decoded by serializers as "NASC".
    /// </summary>
    [EnumMember(Value = "NASC")]
    [IsoId("_b7pjUQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract).")]
    NASAAC = AssetClassDetailedSubProductTypeCode.NASAAC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type nickel.
    /// Encoded/decoded by serializers as "NICK".
    /// </summary>
    [EnumMember(Value = "NICK")]
    [IsoId("_cfgeUQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type nickel.")]
    Nickel = AssetClassDetailedSubProductTypeCode.Nickel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type steel.
    /// Encoded/decoded by serializers as "STEL".
    /// </summary>
    [EnumMember(Value = "STEL")]
    [IsoId("_fS7oMQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type steel.")]
    Steel = AssetClassDetailedSubProductTypeCode.Steel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type tin.
    /// Encoded/decoded by serializers as "TINN".
    /// </summary>
    [EnumMember(Value = "TINN")]
    [IsoId("_gj3EkQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type tin.")]
    Tin = AssetClassDetailedSubProductTypeCode.Tin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type zinc.
    /// Encoded/decoded by serializers as "ZINC".
    /// </summary>
    [EnumMember(Value = "ZINC")]
    [IsoId("_h6mOAQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type zinc.")]
    Zinc = AssetClassDetailedSubProductTypeCode.Zinc, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jKfIkQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type lead.
    /// Encoded/decoded by serializers as "LEAD".
    /// </summary>
    [EnumMember(Value = "LEAD")]
    [IsoId("_j32xUVrDEeWN79Bl6BUd3g")]
    [Description(@"Commodity attribute of type lead.")]
    Lead = AssetClassDetailedSubProductTypeCode.Lead, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassDetailedSubProductType10CodeMetadataExtensions
{
    private static readonly AssetClassDetailedSubProductType10CodeDropdownSource _dropdownSource = new AssetClassDetailedSubProductType10CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassDetailedSubProductType10CodeDropdownRow GetMetadata(this AssetClassDetailedSubProductType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


