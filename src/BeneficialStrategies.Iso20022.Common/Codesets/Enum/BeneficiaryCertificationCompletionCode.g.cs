﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BeneficiaryCertificationCompletionCode.  ISO2002 ID# _bdn359p-Ed-ak6NoX_4Aeg_-1583381957.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certification completion required for a beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bdn359p-Ed-ak6NoX_4Aeg_-1583381957")]
[Description(@"Specifies the type of certification completion required for a beneficiary.")]
[Derivations(typeof(BeneficiaryCertificationCompletion1Code))]
public enum BeneficiaryCertificationCompletionCode
{
    /// <summary>
    /// Certification is not required for this fund.
    /// Encoded/decoded by serializers as "NCER".
    /// </summary>
    [EnumMember(Value = "NCER")]
    [IsoId("_bdn36Np-Ed-ak6NoX_4Aeg_-1094836874")]
    [Description(@"Certification is not required for this fund.")]
    CertificationNotRequired,
    
    /// <summary>
    /// Electronic certification is acceptable.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_bdxB0Np-Ed-ak6NoX_4Aeg_-1077290004")]
    [Description(@"Electronic certification is acceptable.")]
    ElectronicCertification,
    
    /// <summary>
    /// Electronic certification is not acceptable and is required in physical form.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_bdxB0dp-Ed-ak6NoX_4Aeg_-1039426173")]
    [Description(@"Electronic certification is not acceptable and is required in physical form.")]
    PhysicalCertification,
    
}
