﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralType2Code.  ISO2002 ID# _YZhNttp-Ed-ak6NoX_4Aeg_1034999409.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZhNttp-Ed-ak6NoX_4Aeg_1034999409")]
[Description(@"Specifies the type of collateral.")]
[DerivedFrom(typeof(CollateralTypeCode))]
public enum CollateralType2Code
{
    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_YZhNt9p-Ed-ak6NoX_4Aeg_-490160893")]
    [Description(@"Collateral type is cash.")]
    Cash,
    
    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as "Securities".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_YZhNuNp-Ed-ak6NoX_4Aeg_-2046528295")]
    [Description(@"Collateral type is securities.")]
    Securities,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralType2CodeMetadataExtensions
{
    private static readonly CollateralType2CodeDropdownSource _dropdownSource = new CollateralType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralType2CodeDropdownRow GetMetadata(this CollateralType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


