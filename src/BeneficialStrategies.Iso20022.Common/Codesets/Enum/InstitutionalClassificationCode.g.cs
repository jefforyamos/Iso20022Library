﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstitutionalClassificationCode.  ISO2002 ID# _Sn2ckFIhEeGxk_7PmgdPEg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// TSE/JASDEC extension codes for mergers.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sn2ckFIhEeGxk_7PmgdPEg")]
[Description(@"TSE/JASDEC extension codes for mergers.")]
public enum InstitutionalClassificationCode
{
    /// <summary>
    /// In the case of a merger, the Issuer or the Counterparty is the surviving company.
    /// Encoded/decoded by serializers as "SURV".
    /// </summary>
    [EnumMember(Value = "SURV")]
    [IsoId("_D2jWAFIiEeGxk_7PmgdPEg")]
    [Description(@"In the case of a merger, the Issuer or the Counterparty is the surviving company.")]
    SurvivingCompany,
    
    /// <summary>
    /// In the case of a merger, the Issuer or the Counterparty is the discontinued company.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_SD0F8FIiEeGxk_7PmgdPEg")]
    [Description(@"In the case of a merger, the Issuer or the Counterparty is the discontinued company.")]
    DiscontinuedCompany,
    
    /// <summary>
    /// In the case of a merger, the Issuer or the Counterparty is a subsidiary.
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_hV7lIFIiEeGxk_7PmgdPEg")]
    [Description(@"In the case of a merger, the Issuer or the Counterparty is a subsidiary.")]
    Subsidiary,
    
    /// <summary>
    /// In the case of a merger, the classification of the Issuer or the Counterparty is unknown.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_2iiFwFIiEeGxk_7PmgdPEg")]
    [Description(@"In the case of a merger, the classification of the Issuer or the Counterparty is unknown.")]
    Unknown,
    
    /// <summary>
    /// In the case of a merger, the Issuer or the Counterparty is a parent company.
    /// Encoded/decoded by serializers as "PRNT".
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_NJOBIHb2EeGgn5GmpWx6yw")]
    [Description(@"In the case of a merger, the Issuer or the Counterparty is a parent company.")]
    Parent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstitutionalClassificationCodeMetadataExtensions
{
    private static readonly InstitutionalClassificationCodeDropdownSource _dropdownSource = new InstitutionalClassificationCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstitutionalClassificationCodeDropdownRow GetMetadata(this InstitutionalClassificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


