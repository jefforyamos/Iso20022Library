﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OtherAssetCode.  ISO2002 ID# _deqTgEyMEeiepssxrmRw1A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_deqTgEyMEeiepssxrmRw1A")]
[Description(@"Specifies a type of asset.")]
public enum OtherAssetCode
{
    /// <summary>
    /// Property that is real estate.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_fdkQMEyMEeiepssxrmRw1A")]
    [Description(@"Property that is real estate.")]
    PROP,
    
    /// <summary>
    /// Property that is not real estate. Also known as 'movable chattels'.
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_j1tVIEyMEeiepssxrmRw1A")]
    [Description(@"Property that is not real estate. Also known as 'movable chattels'.")]
    MOVE,
    
    /// <summary>
    /// Asset is an external investment account.
    /// </summary>
    [EnumMember(Value = "EXIA")]
    [IsoId("_DYEaAJNCEemQB_8XA98K0Q")]
    [Description(@"Asset is an external investment account.")]
    EXIA,
    
    /// <summary>
    /// Asset is a discretionary investment manager account
    /// </summary>
    [EnumMember(Value = "DIMA")]
    [IsoId("_OfW3gJNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a discretionary investment manager account")]
    DIMA,
    
    /// <summary>
    /// Asset is a trustee investment plan (TIP).
    /// </summary>
    [EnumMember(Value = "TIPP")]
    [IsoId("_XhV1YJNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a trustee investment plan (TIP).")]
    TIPP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OtherAssetCodeMetadataExtensions
{
    private static readonly OtherAssetCodeDropdownSource _dropdownSource = new OtherAssetCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOtherAssetCodeDropdownRow GetMetadata(this OtherAssetCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


