﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BeneficiaryCertificationType4Code.  ISO2002 ID# _GBdPUQE5EeG7DvnR_BzVoA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of certification required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GBdPUQE5EeG7DvnR_BzVoA")]
[Description(@"Specifies the type of certification required.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
public enum BeneficiaryCertificationType4Code
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as "AccreditedInvestor".
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_GBnAVQE5EeG7DvnR_BzVoA")]
    [Description(@"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.")]
    AccreditedInvestor,
    
    /// <summary>
    /// The holder of the security has to certify his domicile.
    /// Encoded/decoded by serializers as "DomicileCountry".
    /// </summary>
    [EnumMember(Value = "DOMI")]
    [IsoId("_GBnAWQE5EeG7DvnR_BzVoA")]
    [Description(@"The holder of the security has to certify his domicile.")]
    DomicileCountry,
    
    /// <summary>
    /// The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// Encoded/decoded by serializers as "NonDomicileCountry".
    /// </summary>
    [EnumMember(Value = "NDOM")]
    [IsoId("_GBnAXQE5EeG7DvnR_BzVoA")]
    [Description(@"The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.")]
    NonDomicileCountry,
    
    /// <summary>
    /// The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose.
    /// Encoded/decoded by serializers as "FullBeneficialOwnerBreakdown".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_GBnAYQE5EeG7DvnR_BzVoA")]
    [Description(@"The holder of the security has to provide his beneficial owner details for disclosure/instruction purpose.")]
    FullBeneficialOwnerBreakdown,
    
    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as "NonCompany".
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_GBnAZQE5EeG7DvnR_BzVoA")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany,
    
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as "QIBCertification".
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_GBnAaQE5EeG7DvnR_BzVoA")]
    [Description(@"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.")]
    QIBCertification,
    
    /// <summary>
    /// The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer.
    /// Encoded/decoded by serializers as "TaxRateBreakdown".
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_GBnAbQE5EeG7DvnR_BzVoA")]
    [Description(@"The holder of the security has to provide basic details on nominals and associated tax rate to be used by the account servicer.")]
    TaxRateBreakdown,
    
    /// <summary>
    /// Indicates if the Beneficial Owner is responsible to fill in the paperwork.
    /// Encoded/decoded by serializers as "BeneficialOwnerPaperwork".
    /// </summary>
    [EnumMember(Value = "PAPW")]
    [IsoId("_GBnAcQE5EeG7DvnR_BzVoA")]
    [Description(@"Indicates if the Beneficial Owner is responsible to fill in the paperwork.")]
    BeneficialOwnerPaperwork,
    
    /// <summary>
    /// The (I)CSD has to provide its participants' details for disclosure purpose to the issuer/issuer’s agent.
    /// Encoded/decoded by serializers as "ICSDParticipantBreakdown".
    /// </summary>
    [EnumMember(Value = "PABD")]
    [IsoId("_GBnAdQE5EeG7DvnR_BzVoA")]
    [Description(@"The (I)CSD has to provide its participants' details for disclosure purpose to the issuer/issuer’s agent.")]
    ICSDParticipantBreakdown,
    
    /// <summary>
    /// Indicates that the rounding rule in the Fraction Disposition component at the option level can be offered at the beneficial owner level.
    /// Encoded/decoded by serializers as "FractionBreakdown".
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_Hb6bJgE5EeG7DvnR_BzVoA")]
    [Description(@"Indicates that the rounding rule in the Fraction Disposition component at the option level can be offered at the beneficial owner level.")]
    FractionBreakdown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BeneficiaryCertificationType4CodeMetadataExtensions
{
    private static readonly BeneficiaryCertificationType4CodeDropdownSource _dropdownSource = new BeneficiaryCertificationType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBeneficiaryCertificationType4CodeDropdownRow GetMetadata(this BeneficiaryCertificationType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


