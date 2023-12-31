﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralCode.  ISO2002 ID# _-IxzECC9EeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the item is used as collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-IxzECC9EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is used as collateral.")]
[Derivations(typeof(Collateral1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CollateralCode
{
    /// <summary>
    /// Item is used as collateral.
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_Ey4TkCC-EeWPMvNwVtiMsA")]
    [Description(@"Item is used as collateral.")]
    Collateral,
    
    /// <summary>
    /// Item is not used as collateral.
    /// Encoded/decoded by serializers as "NCOL".
    /// </summary>
    [EnumMember(Value = "NCOL")]
    [IsoId("_JkxVQCC-EeWPMvNwVtiMsA")]
    [Description(@"Item is not used as collateral.")]
    NotCollateral,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralCodeMetadataExtensions
{
    private static readonly CollateralCodeDropdownSource _dropdownSource = new CollateralCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralCodeDropdownRow GetMetadata(this CollateralCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


