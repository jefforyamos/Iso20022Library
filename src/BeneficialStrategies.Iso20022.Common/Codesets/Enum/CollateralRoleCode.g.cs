﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralRoleCode.  ISO2002 ID# _glgtoCDCEeaned5xL18mUQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_glgtoCDCEeaned5xL18mUQ")]
[Description(@"Identifies whether the reporting counterparty is a collateral provider or a collateral taker.")]
public enum CollateralRoleCode
{
    /// <summary>
    /// Collateral taker. 
    /// Encoded/decoded by serializers as "TAKE".
    /// </summary>
    [EnumMember(Value = "TAKE")]
    [IsoId("_jS1PgCDCEeaned5xL18mUQ")]
    [Description(@"Collateral taker. ")]
    CollateralTaker,
    
    /// <summary>
    /// Collateral giver.
    /// Encoded/decoded by serializers as "GIVE".
    /// </summary>
    [EnumMember(Value = "GIVE")]
    [IsoId("_lgnVsCDCEeaned5xL18mUQ")]
    [Description(@"Collateral giver.")]
    CollateralGiver,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralRoleCodeMetadataExtensions
{
    private static readonly CollateralRoleCodeDropdownSource _dropdownSource = new CollateralRoleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralRoleCodeDropdownRow GetMetadata(this CollateralRoleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


