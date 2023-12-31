﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OtherAsset2Code.  ISO2002 ID# _c7iNMJNCEemQB_8XA98K0Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c7iNMJNCEemQB_8XA98K0Q")]
[Description(@"Specifies a type of asset.")]
[DerivedFrom(typeof(OtherAssetCode))]
public enum OtherAsset2Code
{
    /// <summary>
    /// Asset is a discretionary investment manager account
    /// Encoded/decoded by serializers as "Discretionary".
    /// </summary>
    [EnumMember(Value = "DIMA")]
    [IsoId("_fnEmYZNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a discretionary investment manager account")]
    Discretionary,
    
    /// <summary>
    /// Asset is an external investment account.
    /// Encoded/decoded by serializers as "ExternalAccount".
    /// </summary>
    [EnumMember(Value = "EXIA")]
    [IsoId("_fsbAcZNCEemQB_8XA98K0Q")]
    [Description(@"Asset is an external investment account.")]
    ExternalAccount,
    
    /// <summary>
    /// Property that is not real estate. Also known as 'movable chattels'.
    /// Encoded/decoded by serializers as "MovableProperty".
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_fyX3cZNCEemQB_8XA98K0Q")]
    [Description(@"Property that is not real estate. Also known as 'movable chattels'.")]
    MovableProperty,
    
    /// <summary>
    /// Property that is real estate.
    /// Encoded/decoded by serializers as "Property".
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_f5EVUZNCEemQB_8XA98K0Q")]
    [Description(@"Property that is real estate.")]
    Property,
    
    /// <summary>
    /// Asset is a trustee investment plan (TIP).
    /// Encoded/decoded by serializers as "TrusteeInvestmentPlan".
    /// </summary>
    [EnumMember(Value = "TIPP")]
    [IsoId("_f_UuUZNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a trustee investment plan (TIP).")]
    TrusteeInvestmentPlan,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OtherAsset2CodeMetadataExtensions
{
    private static readonly OtherAsset2CodeDropdownSource _dropdownSource = new OtherAsset2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOtherAsset2CodeDropdownRow GetMetadata(this OtherAsset2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


