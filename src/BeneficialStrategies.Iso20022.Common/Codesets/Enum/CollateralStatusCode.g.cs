﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralStatusCode.  ISO2002 ID# _itEK0MUZEeiF-qqyf1JQhg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_itEK0MUZEeiF-qqyf1JQhg")]
[Description(@"Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.")]
[Derivations(typeof(CollateralStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CollateralStatusCode
{
    /// <summary>
    /// Shortage of collateral.
    /// Encoded/decoded by serializers as "DEFI".
    /// </summary>
    [EnumMember(Value = "DEFI")]
    [IsoId("_HnIp4MUaEeiF-qqyf1JQhg")]
    [Description(@"Shortage of collateral.")]
    CollateralShortage,
    
    /// <summary>
    /// Excess of collateral.
    /// Encoded/decoded by serializers as "EXCS".
    /// </summary>
    [EnumMember(Value = "EXCS")]
    [IsoId("_KxXKMMUaEeiF-qqyf1JQhg")]
    [Description(@"Excess of collateral.")]
    CollateralExcess,
    
    /// <summary>
    /// Collateral covers the exposure and there is no excess.
    /// Encoded/decoded by serializers as "FLAT".
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_UvIa4MUaEeiF-qqyf1JQhg")]
    [Description(@"Collateral covers the exposure and there is no excess.")]
    NoExcessCollateral,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralStatusCodeMetadataExtensions
{
    private static readonly CollateralStatusCodeDropdownSource _dropdownSource = new CollateralStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralStatusCodeDropdownRow GetMetadata(this CollateralStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


