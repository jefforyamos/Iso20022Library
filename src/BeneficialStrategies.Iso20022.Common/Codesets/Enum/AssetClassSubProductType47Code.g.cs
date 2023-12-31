﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType47Code.  ISO2002 ID# _iTsYoPwhEeW4Wthd0Ze_kA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product types for specific asset classes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iTsYoPwhEeW4Wthd0Ze_kA")]
[Description(@"Defines the sub-product types for specific asset classes.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType47Code
{
    /// <summary>
    /// Commodity of type deliverable.
    /// Encoded/decoded by serializers as "Deliverable".
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_kPWNAfwhEeW4Wthd0Ze_kA")]
    [Description(@"Commodity of type deliverable.")]
    Deliverable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType47CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType47CodeDropdownSource _dropdownSource = new AssetClassSubProductType47CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType47CodeDropdownRow GetMetadata(this AssetClassSubProductType47Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


