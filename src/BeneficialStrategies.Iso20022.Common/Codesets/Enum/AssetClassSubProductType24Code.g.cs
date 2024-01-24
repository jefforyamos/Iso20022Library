﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType24Code.  ISO2002 ID# _e_R0oVrKEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Coal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e_R0oVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Coal.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType24Code
{
    /// <summary>
    /// Commodity of type coal.
    /// Encoded/decoded by serializers as "COAL".
    /// </summary>
    [EnumMember(Value = "COAL")]
    [IsoId("_fK85IVrKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type coal.")]
    Coal = AssetClassSubProductTypeCode.Coal, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType24CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType24CodeDropdownSource _dropdownSource = new AssetClassSubProductType24CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType24CodeDropdownRow GetMetadata(this AssetClassSubProductType24Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


