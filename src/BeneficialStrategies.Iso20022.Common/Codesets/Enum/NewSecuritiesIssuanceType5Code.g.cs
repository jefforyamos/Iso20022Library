﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NewSecuritiesIssuanceType5Code.  ISO2002 ID# _5Y2eEWKZEeWR9ZSfjmHwUA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5Y2eEWKZEeWR9ZSfjmHwUA")]
[Description(@"Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.")]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
public enum NewSecuritiesIssuanceType5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DefeasedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_59TO8WKZEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    DefeasedSecurityIndicator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExistingIssue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_59TO82KZEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    ExistingIssue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NewIssue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_59TO9WKZEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    NewIssue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonDefeasedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_59TO92KZEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    NonDefeasedSecurityIndicator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_59TO-WKZEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    Unknown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonRefundedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_QnFfQWKaEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    NonRefundedSecurityIndicator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RefundedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xauNEWKdEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    RefundedSecurityIndicator,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NewSecuritiesIssuanceType5CodeMetadataExtensions
{
    private static readonly NewSecuritiesIssuanceType5CodeDropdownSource _dropdownSource = new NewSecuritiesIssuanceType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INewSecuritiesIssuanceType5CodeDropdownRow GetMetadata(this NewSecuritiesIssuanceType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

