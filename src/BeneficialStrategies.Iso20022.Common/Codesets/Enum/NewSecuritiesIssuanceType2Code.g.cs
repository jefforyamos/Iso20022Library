﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NewSecuritiesIssuanceType2Code.  ISO2002 ID# _z_UgcCp3EeO3oOoGGWHH4A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_z_UgcCp3EeO3oOoGGWHH4A")]
[Description(@"Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.")]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
public enum NewSecuritiesIssuanceType2Code
{
    /// <summary>
    /// Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "DEFE".
    /// </summary>
    [EnumMember(Value = "DEFE")]
    [IsoId("_27hL0Sp3EeO3oOoGGWHH4A")]
    [Description(@"Funds have been placed in escrow by a trustee or agent to ensure payment on a portion of the outstanding balance of the original security on maturity date. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    DefeasedSecurityIndicator = NewSecuritiesIssuanceTypeCode.DefeasedSecurityIndicator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities proceeds are not new issues.
    /// Encoded/decoded by serializers as "EXIS".
    /// </summary>
    [EnumMember(Value = "EXIS")]
    [IsoId("_3AbhASp3EeO3oOoGGWHH4A")]
    [Description(@"Securities proceeds are not new issues.")]
    ExistingIssue = NewSecuritiesIssuanceTypeCode.ExistingIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities proceeds are newly issued.
    /// Encoded/decoded by serializers as "NEIS".
    /// </summary>
    [EnumMember(Value = "NEIS")]
    [IsoId("_3FoxISp3EeO3oOoGGWHH4A")]
    [Description(@"Securities proceeds are newly issued.")]
    NewIssue = NewSecuritiesIssuanceTypeCode.NewIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "NDEF".
    /// </summary>
    [EnumMember(Value = "NDEF")]
    [IsoId("_3Ks3USp3EeO3oOoGGWHH4A")]
    [Description(@"Funds will not be guaranteed at maturity by the issuer or paying agent for this newly issued non-defeased security. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    NonDefeasedSecurityIndicator = NewSecuritiesIssuanceTypeCode.NonDefeasedSecurityIndicator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not known whether the securities proceeds are newly issued or not.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_3PdbgSp3EeO3oOoGGWHH4A")]
    [Description(@"Not known whether the securities proceeds are newly issued or not.")]
    Unknown = NewSecuritiesIssuanceTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NewSecuritiesIssuanceType2CodeMetadataExtensions
{
    private static readonly NewSecuritiesIssuanceType2CodeDropdownSource _dropdownSource = new NewSecuritiesIssuanceType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INewSecuritiesIssuanceType2CodeDropdownRow GetMetadata(this NewSecuritiesIssuanceType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


