﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BeneficiaryCertificationType3Code.  ISO2002 ID# _beD8wdp-Ed-ak6NoX_4Aeg_-1668346228.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of certification required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beD8wdp-Ed-ak6NoX_4Aeg_-1668346228")]
[Description(@"Specifies the type of certification required.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
public enum BeneficiaryCertificationType3Code
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as "ACCI".
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_beD8wtp-Ed-ak6NoX_4Aeg_-1668344657")]
    [Description(@"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.")]
    AccreditedInvestor = BeneficiaryCertificationTypeCode.AccreditedInvestor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as "NCOM".
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_beD8w9p-Ed-ak6NoX_4Aeg_-1667421525")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany = BeneficiaryCertificationTypeCode.NonCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as "QIBB".
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_beD8xNp-Ed-ak6NoX_4Aeg_-1667421153")]
    [Description(@"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.")]
    QIBCertification = BeneficiaryCertificationTypeCode.QIBCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// See narrative field for certification requirements.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_beD8xdp-Ed-ak6NoX_4Aeg_1359889133")]
    [Description(@"See narrative field for certification requirements.")]
    NarrativeDescription = BeneficiaryCertificationTypeCode.NarrativeDescription, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BeneficiaryCertificationType3CodeMetadataExtensions
{
    private static readonly BeneficiaryCertificationType3CodeDropdownSource _dropdownSource = new BeneficiaryCertificationType3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBeneficiaryCertificationType3CodeDropdownRow GetMetadata(this BeneficiaryCertificationType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


