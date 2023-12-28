﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductMetal1Code.  ISO2002 ID# _Wi3yENDrEeS8V88MH4oPOQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list for metal related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wi3yENDrEeS8V88MH4oPOQ")]
[Description(@"Code list for metal related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductMetal1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonPrecious".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aFAcEdDrEeS8V88MH4oPOQ")]
    [Description(@"??")]
    NonPrecious,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Precious".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aSQN4dDrEeS8V88MH4oPOQ")]
    [Description(@"??")]
    Precious,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_IOVEkAFLEeaDfK-zDSyB6A")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductMetal1CodeMetadataExtensions
{
    private static readonly AssetClassSubProductMetal1CodeDropdownSource _dropdownSource = new AssetClassSubProductMetal1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductMetal1CodeDropdownRow GetMetadata(this AssetClassSubProductMetal1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

