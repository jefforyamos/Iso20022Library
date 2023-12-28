﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralAccountType3Code.  ISO2002 ID# _-SycYFHPEeeqtLmveSCYmA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Classification of the requirement that collateral in the collateral account is covering.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-SycYFHPEeeqtLmveSCYmA")]
[Description(@"Classification of the requirement that collateral in the collateral account is covering.")]
[DerivedFrom(typeof(CollateralAccountTypeCode))]
public enum CollateralAccountType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Margin".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ce_XEVHQEeeqtLmveSCYmA")]
    [Description(@"??")]
    Margin,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DefaultFund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Cwzf0VHQEeeqtLmveSCYmA")]
    [Description(@"??")]
    DefaultFund,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralAccountType3CodeMetadataExtensions
{
    private static readonly CollateralAccountType3CodeDropdownSource _dropdownSource = new CollateralAccountType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralAccountType3CodeDropdownRow GetMetadata(this CollateralAccountType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


