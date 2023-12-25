﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralAccountTypeCode.  ISO2002 ID# _waUkkqMOEeCojJW5vEuTEQ_951032316.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the collateral account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_waUkkqMOEeCojJW5vEuTEQ_951032316")]
[Description(@"Specifies the collateral account type.")]
public enum CollateralAccountTypeCode
{
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries.
    /// </summary>
    [EnumMember(Value = "HOUS")]
    [IsoId("_waUkk6MOEeCojJW5vEuTEQ_1771953380")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries.")]
    HOUS,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for the clearing member's customers.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_waUklKMOEeCojJW5vEuTEQ_-1755897740")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for the clearing member's customers.")]
    CLIE,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for liquidity providers (also known as market maker) activities.
    /// </summary>
    [EnumMember(Value = "LIPR")]
    [IsoId("_waUklaMOEeCojJW5vEuTEQ_384687960")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for liquidity providers (also known as market maker) activities.")]
    LIPR,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member's customers.
    /// </summary>
    [EnumMember(Value = "MGIN")]
    [IsoId("_waUklqMOEeCojJW5vEuTEQ_-470789377")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member's customers.")]
    MGIN,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers clearing member's default risk.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_waUkl6MOEeCojJW5vEuTEQ_768200063")]
    [Description(@"Specifies that the account is used to post collateral that covers clearing member's default risk.")]
    DFLT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralAccountTypeCodeMetadataExtensions
{
    private static readonly CollateralAccountTypeCodeDropdownSource _dropdownSource = new CollateralAccountTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralAccountTypeCodeDropdownRow GetMetadata(this CollateralAccountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


