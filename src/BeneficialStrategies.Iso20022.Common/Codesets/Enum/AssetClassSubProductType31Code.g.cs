﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType31Code.  ISO2002 ID# _Mjf7MVrdEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Dry Freight.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Mjf7MVrdEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Dry Freight.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType31Code
{
    /// <summary>
    /// Commodity of type dry freight.
    /// Encoded/decoded by serializers as "Dry".
    /// </summary>
    [EnumMember(Value = "DRYF")]
    [IsoId("_MvTikVrdEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type dry freight.")]
    Dry,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType31CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType31CodeDropdownSource _dropdownSource = new AssetClassSubProductType31CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType31CodeDropdownRow GetMetadata(this AssetClassSubProductType31Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


