﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestorType4Code.  ISO2002 ID# _7VIwsLVMEeqkjqDuFVh1-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7VIwsLVMEeqkjqDuFVh1-A")]
[Description(@"Specifies the type of investor.")]
[DerivedFrom(typeof(InvestorTypeV2Code))]
public enum InvestorType4Code
{
    /// <summary>
    /// Investor is both professional per se and elective professional.
    /// Encoded/decoded by serializers as "BOT3".
    /// </summary>
    [EnumMember(Value = "BOT3")]
    [IsoId("__1XaobVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is both professional per se and elective professional.")]
    BothProfessionalPerSeAndElectiveProfessional = InvestorTypeV2Code.BothProfessionalPerSeAndElectiveProfessional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is neither professional per se or elective professional.
    /// Encoded/decoded by serializers as "NPRF".
    /// </summary>
    [EnumMember(Value = "NPRF")]
    [IsoId("_A9C0YbVNEeqkjqDuFVh1-A")]
    [Description(@"Investor is neither professional per se or elective professional.")]
    NotProfessionalPerSeElectiveProfessional = InvestorTypeV2Code.NotProfessionalPerSeElectiveProfessional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is professional per se but not elective professional.
    /// Encoded/decoded by serializers as "PRF3".
    /// </summary>
    [EnumMember(Value = "PRF3")]
    [IsoId("_BkOJIbVNEeqkjqDuFVh1-A")]
    [Description(@"Investor is professional per se but not elective professional.")]
    ProfessionalPerSeNotElectiveProfessional = InvestorTypeV2Code.ProfessionalPerSeNotElectiveProfessional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is an elective professional but not professional per se.
    /// Encoded/decoded by serializers as "PRF4".
    /// </summary>
    [EnumMember(Value = "PRF4")]
    [IsoId("_CeL3AbVNEeqkjqDuFVh1-A")]
    [Description(@"Investor is an elective professional but not professional per se.")]
    ElectiveProfessionalNotProfessionalPerSe = InvestorTypeV2Code.ElectiveProfessionalNotProfessionalPerSe, // same ordinal as derivation source for type conversions
    
}
