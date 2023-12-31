﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Collateral1Code.  ISO2002 ID# _ObDuwCC-EeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the item is used as collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ObDuwCC-EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is used as collateral.")]
[DerivedFrom(typeof(CollateralCode))]
public enum Collateral1Code
{
    /// <summary>
    /// Item is used as collateral.
    /// Encoded/decoded by serializers as "Collateral".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_QHQx4SC-EeWPMvNwVtiMsA")]
    [Description(@"Item is used as collateral.")]
    Collateral,
    
    /// <summary>
    /// Item is not used as collateral.
    /// Encoded/decoded by serializers as "NotCollateral".
    /// </summary>
    [EnumMember(Value = "NCOL")]
    [IsoId("_QPdEkSC-EeWPMvNwVtiMsA")]
    [Description(@"Item is not used as collateral.")]
    NotCollateral,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Collateral1CodeMetadataExtensions
{
    private static readonly Collateral1CodeDropdownSource _dropdownSource = new Collateral1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateral1CodeDropdownRow GetMetadata(this Collateral1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


