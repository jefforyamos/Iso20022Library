﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NewSecuritiesIssuanceTypeCode.  ISO2002 ID# _WghhgBHzEeKKuerhIbkpig.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WghhgBHzEeKKuerhIbkpig")]
[Description(@"Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.")]
public enum NewSecuritiesIssuanceTypeCode
{
    /// <summary>
    /// Securities proceeds are not new issues.
    /// Encoded/decoded by serializers as "EXIS".
    /// </summary>
    [EnumMember(Value = "EXIS")]
    [IsoId("_Firq4BH0EeKKuerhIbkpig")]
    [Description(@"Securities proceeds are not new issues.")]
    ExistingIssue,
    
    /// <summary>
    /// Securities proceeds are newly issued.
    /// Encoded/decoded by serializers as "NEIS".
    /// </summary>
    [EnumMember(Value = "NEIS")]
    [IsoId("_j4OtABH0EeKKuerhIbkpig")]
    [Description(@"Securities proceeds are newly issued.")]
    NewIssue,
    
    /// <summary>
    /// Not known whether the securities proceeds are newly issued or not.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_nzdzgBH0EeKKuerhIbkpig")]
    [Description(@"Not known whether the securities proceeds are newly issued or not.")]
    Unknown,
    
    /// <summary>
    /// Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "DEFE".
    /// </summary>
    [EnumMember(Value = "DEFE")]
    [IsoId("_OBhI8Cp2EeO3oOoGGWHH4A")]
    [Description(@"Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    DefeasedSecurityIndicator,
    
    /// <summary>
    /// Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "NDEF".
    /// </summary>
    [EnumMember(Value = "NDEF")]
    [IsoId("_WvRjQCp2EeO3oOoGGWHH4A")]
    [Description(@"Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    NonDefeasedSecurityIndicator,
    
    /// <summary>
    /// New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "REFU".
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_plNeQKFOEeSK_vfd3NHBGg")]
    [Description(@"New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.")]
    RefundedSecurityIndicator,
    
    /// <summary>
    /// New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "NREF".
    /// </summary>
    [EnumMember(Value = "NREF")]
    [IsoId("_26bL4KFOEeSK_vfd3NHBGg")]
    [Description(@"New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    NonRefundedSecurityIndicator,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NewSecuritiesIssuanceTypeCodeMetadataExtensions
{
    private static readonly NewSecuritiesIssuanceTypeCodeDropdownSource _dropdownSource = new NewSecuritiesIssuanceTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INewSecuritiesIssuanceTypeCodeDropdownRow GetMetadata(this NewSecuritiesIssuanceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


