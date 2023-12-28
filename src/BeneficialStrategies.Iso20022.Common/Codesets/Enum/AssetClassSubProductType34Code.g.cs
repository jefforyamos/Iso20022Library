﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType34Code.  ISO2002 ID# _zvbdQVrfEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Manufacturing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zvbdQVrfEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Manufacturing.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType34Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Manufacturing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_z68wwVrfEeWN79Bl6BUd3g")]
    [Description(@"??")]
    Manufacturing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType34CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType34CodeDropdownSource _dropdownSource = new AssetClassSubProductType34CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType34CodeDropdownRow GetMetadata(this AssetClassSubProductType34Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

