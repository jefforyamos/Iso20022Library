﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClearingAccountType1Code.  ISO2002 ID# _YZXcu9p-Ed-ak6NoX_4Aeg_-1340826137.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the clearing account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZXcu9p-Ed-ak6NoX_4Aeg_-1340826137")]
[Description(@"Specifies the clearing account type.")]
[DerivedFrom(typeof(ClearingAccountTypeCode))]
public enum ClearingAccountType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "House".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YZXcvNp-Ed-ak6NoX_4Aeg_-1776867324")]
    [Description(@"??")]
    House,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Client".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YZhNsNp-Ed-ak6NoX_4Aeg_-2094643985")]
    [Description(@"??")]
    Client,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LiquidityProvider".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YZhNsdp-Ed-ak6NoX_4Aeg_2086484245")]
    [Description(@"??")]
    LiquidityProvider,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClearingAccountType1CodeMetadataExtensions
{
    private static readonly ClearingAccountType1CodeDropdownSource _dropdownSource = new ClearingAccountType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClearingAccountType1CodeDropdownRow GetMetadata(this ClearingAccountType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

