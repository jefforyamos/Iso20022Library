﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NewSecuritiesIssuanceType6Code.  ISO2002 ID# _PLMMMWKeEeWR9ZSfjmHwUA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities proceeds; whether they are defeased or non-defeased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PLMMMWKeEeWR9ZSfjmHwUA")]
[Description(@"Specifies the type of securities proceeds; whether they are defeased or non-defeased.")]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
public enum NewSecuritiesIssuanceType6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DefeasedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PfIb4WKeEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    DefeasedSecurityIndicator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonDefeasedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PfIb42KeEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    NonDefeasedSecurityIndicator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RefundedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_RrbUUWKeEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    RefundedSecurityIndicator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonRefundedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_R93vMWKeEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    NonRefundedSecurityIndicator,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NewSecuritiesIssuanceType6CodeMetadataExtensions
{
    private static readonly NewSecuritiesIssuanceType6CodeDropdownSource _dropdownSource = new NewSecuritiesIssuanceType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INewSecuritiesIssuanceType6CodeDropdownRow GetMetadata(this NewSecuritiesIssuanceType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


