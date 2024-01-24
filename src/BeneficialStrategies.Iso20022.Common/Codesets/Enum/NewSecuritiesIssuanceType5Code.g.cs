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
    /// Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "DEFE".
    /// </summary>
    [EnumMember(Value = "DEFE")]
    [IsoId("_59TO8WKZEeWR9ZSfjmHwUA")]
    [Description(@"Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    DefeasedSecurityIndicator = NewSecuritiesIssuanceTypeCode.DefeasedSecurityIndicator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities proceeds are not new issues.
    /// Encoded/decoded by serializers as "EXIS".
    /// </summary>
    [EnumMember(Value = "EXIS")]
    [IsoId("_59TO82KZEeWR9ZSfjmHwUA")]
    [Description(@"Securities proceeds are not new issues.")]
    ExistingIssue = NewSecuritiesIssuanceTypeCode.ExistingIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities proceeds are newly issued.
    /// Encoded/decoded by serializers as "NEIS".
    /// </summary>
    [EnumMember(Value = "NEIS")]
    [IsoId("_59TO9WKZEeWR9ZSfjmHwUA")]
    [Description(@"Securities proceeds are newly issued.")]
    NewIssue = NewSecuritiesIssuanceTypeCode.NewIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "NDEF".
    /// </summary>
    [EnumMember(Value = "NDEF")]
    [IsoId("_59TO92KZEeWR9ZSfjmHwUA")]
    [Description(@"Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    NonDefeasedSecurityIndicator = NewSecuritiesIssuanceTypeCode.NonDefeasedSecurityIndicator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not known whether the securities proceeds are newly issued or not.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_59TO-WKZEeWR9ZSfjmHwUA")]
    [Description(@"Not known whether the securities proceeds are newly issued or not.")]
    Unknown = NewSecuritiesIssuanceTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "NREF".
    /// </summary>
    [EnumMember(Value = "NREF")]
    [IsoId("_QnFfQWKaEeWR9ZSfjmHwUA")]
    [Description(@"New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    NonRefundedSecurityIndicator = NewSecuritiesIssuanceTypeCode.NonRefundedSecurityIndicator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "REFU".
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_xauNEWKdEeWR9ZSfjmHwUA")]
    [Description(@"New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.")]
    RefundedSecurityIndicator = NewSecuritiesIssuanceTypeCode.RefundedSecurityIndicator, // same ordinal as derivation source for type conversions
    
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


