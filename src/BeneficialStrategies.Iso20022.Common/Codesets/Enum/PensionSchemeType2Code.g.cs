﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PensionSchemeType2Code.  ISO2002 ID# _spkUwDOSEeqKY_RYlDm6Pw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of pension scheme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_spkUwDOSEeqKY_RYlDm6Pw")]
[Description(@"Specifies a type of pension scheme.")]
[DerivedFrom(typeof(PensionSchemeTypeV2Code))]
public enum PensionSchemeType2Code
{
    /// <summary>
    /// Pension plan is an additional voluntary contribution plan.
    /// Encoded/decoded by serializers as "AdditionalVoluntaryContribution".
    /// </summary>
    [EnumMember(Value = "AAVC")]
    [IsoId("_0uaU8TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an additional voluntary contribution plan.")]
    AdditionalVoluntaryContribution,
    
    /// <summary>
    /// Pension plan is a defined benefit plan.
    /// Encoded/decoded by serializers as "DefinedBenefit".
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_01P8wTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a defined benefit plan.")]
    DefinedBenefit,
    
    /// <summary>
    /// Pension plan is an executive pension plan.
    /// Encoded/decoded by serializers as "ExecutivePensionPlan".
    /// </summary>
    [EnumMember(Value = "EXPP")]
    [IsoId("_07Dp0TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an executive pension plan.")]
    ExecutivePensionPlan,
    
    /// <summary>
    /// Pension plan is a free standing additional voluntary contribution plan.
    /// Encoded/decoded by serializers as "FreeStandingAdditionalVoluntaryContribution".
    /// </summary>
    [EnumMember(Value = "FAVC")]
    [IsoId("_1A2v0TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a free standing additional voluntary contribution plan.")]
    FreeStandingAdditionalVoluntaryContribution,
    
    /// <summary>
    /// Pension is a group personal pension.
    /// Encoded/decoded by serializers as "GroupPersonalPension".
    /// </summary>
    [EnumMember(Value = "GPPS")]
    [IsoId("_1Gqc4TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a group personal pension.")]
    GroupPersonalPension,
    
    /// <summary>
    /// Pension plan is a group self-invested pension plan.
    /// Encoded/decoded by serializers as "GroupSelfInvestedPension".
    /// </summary>
    [EnumMember(Value = "SIPG")]
    [IsoId("_1Mdi4TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a group self-invested pension plan.")]
    GroupSelfInvestedPension,
    
    /// <summary>
    /// Pension plan is a group stakeholder pension plan.
    /// Encoded/decoded by serializers as "GroupStakeholder".
    /// </summary>
    [EnumMember(Value = "STKG")]
    [IsoId("_1Tc7sTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a group stakeholder pension plan.")]
    GroupStakeholder,
    
    /// <summary>
    /// Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.
    /// Encoded/decoded by serializers as "IndividualPensionWithTaxBenefit".
    /// </summary>
    [EnumMember(Value = "IPST")]
    [IsoId("_1aAPoTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.")]
    IndividualPensionWithTaxBenefit,
    
    /// <summary>
    /// Pension plan is an individual stakeholder pension.
    /// Encoded/decoded by serializers as "IndividualStakeholder".
    /// </summary>
    [EnumMember(Value = "STKI")]
    [IsoId("_1gi8gTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an individual stakeholder pension.")]
    IndividualStakeholder,
    
    /// <summary>
    /// Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.
    /// Encoded/decoded by serializers as "MandatoryOccupationalPension".
    /// </summary>
    [EnumMember(Value = "OTPM")]
    [IsoId("_1m8fcTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.")]
    MandatoryOccupationalPension,
    
    /// <summary>
    /// Pension plan is an occupational defined contribution plan.
    /// Encoded/decoded by serializers as "OccupationalDefinedContribution".
    /// </summary>
    [EnumMember(Value = "OCDC")]
    [IsoId("_1smbgTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an occupational defined contribution plan.")]
    OccupationalDefinedContribution,
    
    /// <summary>
    /// Pension is a personal pension plan.
    /// Encoded/decoded by serializers as "PersonalPension".
    /// </summary>
    [EnumMember(Value = "PPNS")]
    [IsoId("_1yGmkTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a personal pension plan.")]
    PersonalPension,
    
    /// <summary>
    /// Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.
    /// Encoded/decoded by serializers as "PersonalPensionAccount".
    /// </summary>
    [EnumMember(Value = "EPKA")]
    [IsoId("_135skTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.")]
    PersonalPensionAccount,
    
    /// <summary>
    /// Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.
    /// Encoded/decoded by serializers as "PrivateOccupationalPension".
    /// </summary>
    [EnumMember(Value = "ITPO")]
    [IsoId("_1-AUkTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.")]
    PrivateOccupationalPension,
    
    /// <summary>
    /// Pension plan is a retirement annuity.
    /// Encoded/decoded by serializers as "RetirementAnnuity".
    /// </summary>
    [EnumMember(Value = "REAN")]
    [IsoId("_2EQGgTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a retirement annuity.")]
    RetirementAnnuity,
    
    /// <summary>
    /// Pension type covered by section 32.
    /// Encoded/decoded by serializers as "Section32".
    /// </summary>
    [EnumMember(Value = "SC32")]
    [IsoId("_2KM9gTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension type covered by section 32.")]
    Section32,
    
    /// <summary>
    /// Pension type covered by section 32A.
    /// Encoded/decoded by serializers as "Section32A".
    /// </summary>
    [EnumMember(Value = "S32A")]
    [IsoId("_2QcvcTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension type covered by section 32A.")]
    Section32A,
    
    /// <summary>
    /// Pension is a self-invested personal pension plan.
    /// Encoded/decoded by serializers as "SelfInvestedPersonalPension".
    /// </summary>
    [EnumMember(Value = "SIPP")]
    [IsoId("_2XJNUTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a self-invested personal pension plan.")]
    SelfInvestedPersonalPension,
    
    /// <summary>
    /// Pension is a small self-administered pension scheme.
    /// Encoded/decoded by serializers as "SmallSelfAdministeredScheme".
    /// </summary>
    [EnumMember(Value = "SSAS")]
    [IsoId("_2ecIITOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a small self-administered pension scheme.")]
    SmallSelfAdministeredScheme,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PensionSchemeType2CodeMetadataExtensions
{
    private static readonly PensionSchemeType2CodeDropdownSource _dropdownSource = new PensionSchemeType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPensionSchemeType2CodeDropdownRow GetMetadata(this PensionSchemeType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


