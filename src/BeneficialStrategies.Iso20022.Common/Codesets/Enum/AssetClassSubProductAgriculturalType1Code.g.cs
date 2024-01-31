﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductAgriculturalType1Code.  ISO2002 ID# _SzFS8M5AEeSc85GUbgBycw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list for agricultural related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SzFS8M5AEeSc85GUbgBycw")]
[Description(@"Code list for agricultural related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductAgriculturalType1Code
{
    /// <summary>
    /// Commodity of type dairy.
    /// Encoded/decoded by serializers as "DIRY".
    /// </summary>
    [EnumMember(Value = "DIRY")]
    [IsoId("_f8pxQc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type dairy.")]
    Dairy = AssetClassSubProductTypeCode.Dairy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type forestry.
    /// Encoded/decoded by serializers as "FRST".
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_gHrVgc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type forestry.")]
    Forestry = AssetClassSubProductTypeCode.Forestry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type grain oil seeds.
    /// Encoded/decoded by serializers as "GROS".
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_ginlEc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type grain oil seeds.")]
    GrainOilSeeds = AssetClassSubProductTypeCode.GrainOilSeeds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type livestock.
    /// Encoded/decoded by serializers as "LSTK".
    /// </summary>
    [EnumMember(Value = "LSTK")]
    [IsoId("_hBSeEc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type livestock.")]
    Livestock = AssetClassSubProductTypeCode.Livestock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type softs.
    /// Encoded/decoded by serializers as "SOFT".
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_pJ0EYc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type softs.")]
    Softs = AssetClassSubProductTypeCode.Softs, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type seafood.
    /// Encoded/decoded by serializers as "SEAF".
    /// </summary>
    [EnumMember(Value = "SEAF")]
    [IsoId("_iAuhoUDaEeWOL-OsSq2h6w")]
    [Description(@"Commodity of type seafood.")]
    Seafood = AssetClassSubProductTypeCode.Seafood, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_3WT_IUDaEeWOL-OsSq2h6w")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductAgriculturalType1CodeMetadataExtensions
{
    private static readonly AssetClassSubProductAgriculturalType1CodeDropdownSource _dropdownSource = new AssetClassSubProductAgriculturalType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductAgriculturalType1CodeDropdownRow GetMetadata(this AssetClassSubProductAgriculturalType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


