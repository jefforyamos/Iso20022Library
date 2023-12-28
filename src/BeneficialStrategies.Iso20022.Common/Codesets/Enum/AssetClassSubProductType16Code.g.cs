﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType16Code.  ISO2002 ID# _FvfOMAnzEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Precious Metal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FvfOMAnzEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Precious Metal.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType16Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Precious".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oLnOsQn0EeWnS-yHF1QhNQ")]
    [Description(@"??")]
    Precious,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType16CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType16CodeDropdownSource _dropdownSource = new AssetClassSubProductType16CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType16CodeDropdownRow GetMetadata(this AssetClassSubProductType16Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

