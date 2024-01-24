﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PensionSchemeTypeV2Code.  ISO2002 ID# _BGikxDOSEeqKY_RYlDm6Pw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of pension scheme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BGikxDOSEeqKY_RYlDm6Pw")]
[Description(@"Specifies a type of pension scheme.")]
[Derivations(typeof(PensionSchemeType2Code),typeof(PensionSchemeType3Code))]
public enum PensionSchemeTypeV2Code
{
    /// <summary>
    /// Pension is a group personal pension.
    /// Encoded/decoded by serializers as "GPPS".
    /// </summary>
    [EnumMember(Value = "GPPS")]
    [IsoId("_BGikxzOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a group personal pension.")]
    GroupPersonalPension,
    
    /// <summary>
    /// Pension is a personal pension plan.
    /// Encoded/decoded by serializers as "PPNS".
    /// </summary>
    [EnumMember(Value = "PPNS")]
    [IsoId("_BGikxjOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a personal pension plan.")]
    PersonalPension,
    
    /// <summary>
    /// Pension is a self-invested personal pension plan.
    /// Encoded/decoded by serializers as "SIPP".
    /// </summary>
    [EnumMember(Value = "SIPP")]
    [IsoId("_BGik0TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a self-invested personal pension plan.")]
    SelfInvestedPersonalPension,
    
    /// <summary>
    /// Pension plan is a group self-invested pension plan.
    /// Encoded/decoded by serializers as "SIPG".
    /// </summary>
    [EnumMember(Value = "SIPG")]
    [IsoId("_BGikxTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a group self-invested pension plan.")]
    GroupSelfInvestedPension,
    
    /// <summary>
    /// Pension is a small self-administered pension scheme.
    /// Encoded/decoded by serializers as "SSAS".
    /// </summary>
    [EnumMember(Value = "SSAS")]
    [IsoId("_BGikyjOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a small self-administered pension scheme.")]
    SmallSelfAdministeredScheme,
    
    /// <summary>
    /// Pension plan is an individual stakeholder pension.
    /// Encoded/decoded by serializers as "STKI".
    /// </summary>
    [EnumMember(Value = "STKI")]
    [IsoId("_BGikzDOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an individual stakeholder pension.")]
    IndividualStakeholder,
    
    /// <summary>
    /// Pension plan is a group stakeholder pension plan.
    /// Encoded/decoded by serializers as "STKG".
    /// </summary>
    [EnumMember(Value = "STKG")]
    [IsoId("_BGikzjOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a group stakeholder pension plan.")]
    GroupStakeholder,
    
    /// <summary>
    /// Pension type covered by section 32.
    /// Encoded/decoded by serializers as "SC32".
    /// </summary>
    [EnumMember(Value = "SC32")]
    [IsoId("_BGik1zOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension type covered by section 32.")]
    Section32,
    
    /// <summary>
    /// Pension type covered by section 32A.
    /// Encoded/decoded by serializers as "S32A".
    /// </summary>
    [EnumMember(Value = "S32A")]
    [IsoId("_BGikzzOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension type covered by section 32A.")]
    Section32A,
    
    /// <summary>
    /// Pension plan is a retirement annuity.
    /// Encoded/decoded by serializers as "REAN".
    /// </summary>
    [EnumMember(Value = "REAN")]
    [IsoId("_BGikyzOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a retirement annuity.")]
    RetirementAnnuity,
    
    /// <summary>
    /// Pension plan is an occupational defined contribution plan.
    /// Encoded/decoded by serializers as "OCDC".
    /// </summary>
    [EnumMember(Value = "OCDC")]
    [IsoId("_BGik0jOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an occupational defined contribution plan.")]
    OccupationalDefinedContribution,
    
    /// <summary>
    /// Pension plan is an executive pension plan.
    /// Encoded/decoded by serializers as "EXPP".
    /// </summary>
    [EnumMember(Value = "EXPP")]
    [IsoId("_BGikyDOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an executive pension plan.")]
    ExecutivePensionPlan,
    
    /// <summary>
    /// Pension plan is an additional voluntary contribution plan.
    /// Encoded/decoded by serializers as "AAVC".
    /// </summary>
    [EnumMember(Value = "AAVC")]
    [IsoId("_BGik0DOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an additional voluntary contribution plan.")]
    AdditionalVoluntaryContribution,
    
    /// <summary>
    /// Pension plan is a free standing additional voluntary contribution plan.
    /// Encoded/decoded by serializers as "FAVC".
    /// </summary>
    [EnumMember(Value = "FAVC")]
    [IsoId("_BGik1jOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a free standing additional voluntary contribution plan.")]
    FreeStandingAdditionalVoluntaryContribution,
    
    /// <summary>
    /// Pension plan is a defined benefit plan.
    /// Encoded/decoded by serializers as "DBEN".
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_BGik1DOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a defined benefit plan.")]
    DefinedBenefit,
    
    /// <summary>
    /// Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.
    /// Encoded/decoded by serializers as "IPST".
    /// </summary>
    [EnumMember(Value = "IPST")]
    [IsoId("_BGik0zOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.")]
    IndividualPensionWithTaxBenefit,
    
    /// <summary>
    /// Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.
    /// Encoded/decoded by serializers as "OTPM".
    /// </summary>
    [EnumMember(Value = "OTPM")]
    [IsoId("_BGik1TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.")]
    MandatoryOccupationalPension,
    
    /// <summary>
    /// Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.
    /// Encoded/decoded by serializers as "EPKA".
    /// </summary>
    [EnumMember(Value = "EPKA")]
    [IsoId("_BGikzTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.")]
    PersonalPensionAccount,
    
    /// <summary>
    /// Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.
    /// Encoded/decoded by serializers as "ITPO".
    /// </summary>
    [EnumMember(Value = "ITPO")]
    [IsoId("_BGikyTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.")]
    PrivateOccupationalPension,
    
    /// <summary>
    /// Indicates that the party does not operate the pension wrapper.
    /// Encoded/decoded by serializers as "NWRP".
    /// </summary>
    [EnumMember(Value = "NWRP")]
    [IsoId("_LnCUoOlpEeuvhrZwLF0fDg")]
    [Description(@"Indicates that the party does not operate the pension wrapper.")]
    NonWrapperPension,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PensionSchemeTypeV2CodeMetadataExtensions
{
    private static readonly PensionSchemeTypeV2CodeDropdownSource _dropdownSource = new PensionSchemeTypeV2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPensionSchemeTypeV2CodeDropdownRow GetMetadata(this PensionSchemeTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


