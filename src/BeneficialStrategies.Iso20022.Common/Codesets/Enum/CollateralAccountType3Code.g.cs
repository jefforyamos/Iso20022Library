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
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member's customers.
    /// Encoded/decoded by serializers as "Margin".
    /// </summary>
    [EnumMember(Value = "MGIN")]
    [IsoId("_Ce_XEVHQEeeqtLmveSCYmA")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member's customers.")]
    Margin,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers clearing member's default risk.
    /// Encoded/decoded by serializers as "DefaultFund".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_Cwzf0VHQEeeqtLmveSCYmA")]
    [Description(@"Specifies that the account is used to post collateral that covers clearing member's default risk.")]
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


