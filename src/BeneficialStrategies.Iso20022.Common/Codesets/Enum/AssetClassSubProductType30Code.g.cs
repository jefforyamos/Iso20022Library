﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType30Code.  ISO2002 ID# _ftdB4VrNEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Weather.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ftdB4VrNEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Weather.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType30Code
{
    /// <summary>
    /// Commodity of type weather.
    /// Encoded/decoded by serializers as "WTHR".
    /// </summary>
    [EnumMember(Value = "WTHR")]
    [IsoId("_f4vr41rNEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type weather.")]
    Weather = AssetClassSubProductTypeCode.Weather, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType30CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType30CodeDropdownSource _dropdownSource = new AssetClassSubProductType30CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType30CodeDropdownRow GetMetadata(this AssetClassSubProductType30Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


