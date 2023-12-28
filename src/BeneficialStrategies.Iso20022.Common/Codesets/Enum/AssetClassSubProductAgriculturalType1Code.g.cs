﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductAgriculturalType1Code.  ISO2002 ID# _SzFS8M5AEeSc85GUbgBycw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "Dairy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_f8pxQc5AEeSc85GUbgBycw")]
    [Description(@"??")]
    Dairy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Forestry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_gHrVgc5AEeSc85GUbgBycw")]
    [Description(@"??")]
    Forestry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GrainOilSeeds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ginlEc5AEeSc85GUbgBycw")]
    [Description(@"??")]
    GrainOilSeeds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Livestock".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hBSeEc5AEeSc85GUbgBycw")]
    [Description(@"??")]
    Livestock,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Softs".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pJ0EYc5AEeSc85GUbgBycw")]
    [Description(@"??")]
    Softs,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Seafood".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iAuhoUDaEeWOL-OsSq2h6w")]
    [Description(@"??")]
    Seafood,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3WT_IUDaEeWOL-OsSq2h6w")]
    [Description(@"??")]
    Other,
    
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

