﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetFXSubProductType1Code.  ISO2002 ID# _IWuWENDjEeSv_Pll20DdbA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the allowed foreign exchange types for foreign exchange derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IWuWENDjEeSv_Pll20DdbA")]
[Description(@"Specifies the allowed foreign exchange types for foreign exchange derivatives.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetFXSubProductType1Code
{
    /// <summary>
    /// Commodity attribute of type foreign exchange cross rate.
    /// Encoded/decoded by serializers as "FXCR".
    /// </summary>
    [EnumMember(Value = "FXCR")]
    [IsoId("_LWWI4dDjEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange cross rate.")]
    ForeignExchangeCrossRate = AssetClassDetailedSubProductTypeCode.ForeignExchangeCrossRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type foreign exchange emerging markets.
    /// Encoded/decoded by serializers as "FXEM".
    /// </summary>
    [EnumMember(Value = "FXEM")]
    [IsoId("_LeFIkdDjEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange emerging markets.")]
    ForeignExchangeEmergingMarket = AssetClassDetailedSubProductTypeCode.ForeignExchangeEmergingMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type foreign exchange majors.
    /// Encoded/decoded by serializers as "FXMJ".
    /// </summary>
    [EnumMember(Value = "FXMJ")]
    [IsoId("_Lj4OkdDjEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange majors.")]
    ForeignExchangeMajor = AssetClassDetailedSubProductTypeCode.ForeignExchangeMajor, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetFXSubProductType1CodeMetadataExtensions
{
    private static readonly AssetFXSubProductType1CodeDropdownSource _dropdownSource = new AssetFXSubProductType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetFXSubProductType1CodeDropdownRow GetMetadata(this AssetFXSubProductType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


