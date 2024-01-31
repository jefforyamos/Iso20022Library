﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType32Code.  ISO2002 ID# _Q2ah4VrdEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Wet Freight.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q2ah4VrdEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Wet Freight.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType32Code
{
    /// <summary>
    /// Commodity of type wet freight.
    /// Encoded/decoded by serializers as "WETF".
    /// </summary>
    [EnumMember(Value = "WETF")]
    [IsoId("_RB1uw1rdEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type wet freight.")]
    Wet = AssetClassSubProductTypeCode.Wet, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType32CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType32CodeDropdownSource _dropdownSource = new AssetClassSubProductType32CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType32CodeDropdownRow GetMetadata(this AssetClassSubProductType32Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


