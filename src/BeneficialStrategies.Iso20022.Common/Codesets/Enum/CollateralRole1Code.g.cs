﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralRole1Code.  ISO2002 ID# _pFIlUCDCEeaned5xL18mUQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pFIlUCDCEeaned5xL18mUQ")]
[Description(@"Identifies whether the reporting counterparty is a collateral provider or a collateral taker.")]
[DerivedFrom(typeof(CollateralRoleCode))]
public enum CollateralRole1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralGiver".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qHyVISDCEeaned5xL18mUQ")]
    [Description(@"??")]
    CollateralGiver,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralTaker".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qPOZ4SDCEeaned5xL18mUQ")]
    [Description(@"??")]
    CollateralTaker,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralRole1CodeMetadataExtensions
{
    private static readonly CollateralRole1CodeDropdownSource _dropdownSource = new CollateralRole1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralRole1CodeDropdownRow GetMetadata(this CollateralRole1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


