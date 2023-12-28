﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType12Code.  ISO2002 ID# _Tl5sIVrLEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Commodity derivative base product code list for Inflation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tl5sIVrLEeWN79Bl6BUd3g")]
[Description(@"Commodity derivative base product code list for Inflation.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType12Code
{
    /// <summary>
    /// Commodity of type inflation.
    /// Encoded/decoded by serializers as "Inflation".
    /// </summary>
    [EnumMember(Value = "INFL")]
    [IsoId("_TxFBZ1rLEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type inflation.")]
    Inflation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType12CodeMetadataExtensions
{
    private static readonly AssetClassProductType12CodeDropdownSource _dropdownSource = new AssetClassProductType12CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType12CodeDropdownRow GetMetadata(this AssetClassProductType12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


