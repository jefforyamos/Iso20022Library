﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialPartySectorType2Code.  ISO2002 ID# _c2270Ab-EeamHPKpTHjX5Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the reporting counterparty business activities. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c2270Ab-EeamHPKpTHjX5Q")]
[Description(@"Specifies the nature of the reporting counterparty business activities. ")]
[DerivedFrom(typeof(FinancialPartySectorTypeCode))]
public enum FinancialPartySectorType2Code
{
    /// <summary>
    /// Alternative investment fund managed by an alternative investment fund manager (AIFM).
    /// Encoded/decoded by serializers as "AlternativeInvestmentFund".
    /// </summary>
    [EnumMember(Value = "AIFD")]
    [IsoId("_e4uF4Qb-EeamHPKpTHjX5Q")]
    [Description(@"Alternative investment fund managed by an alternative investment fund manager (AIFM).")]
    AlternativeInvestmentFund,
    
    /// <summary>
    /// Central securities depository.
    /// Encoded/decoded by serializers as "CentralSecuritiesDepository".
    /// </summary>
    [EnumMember(Value = "CSDS")]
    [IsoId("_fGjtkQb-EeamHPKpTHjX5Q")]
    [Description(@"Central securities depository.")]
    CentralSecuritiesDepository,
    
    /// <summary>
    /// Central counterparty.
    /// Encoded/decoded by serializers as "CentralCounterparty".
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_fPJo4Qb-EeamHPKpTHjX5Q")]
    [Description(@"Central counterparty.")]
    CentralCounterparty,
    
    /// <summary>
    /// Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.
    /// 
    /// Encoded/decoded by serializers as "CreditInstitution".
    /// </summary>
    [EnumMember(Value = "CDTI")]
    [IsoId("_fRxfEQb-EeamHPKpTHjX5Q")]
    [Description(@"Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account. ")]
    CreditInstitution,
    
    /// <summary>
    /// Insurance undertaking.
    /// Encoded/decoded by serializers as "InsuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "INUN")]
    [IsoId("_flH44gb-EeamHPKpTHjX5Q")]
    [Description(@"Insurance undertaking.")]
    InsuranceUndertaking,
    
    /// <summary>
    /// Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.
    /// Encoded/decoded by serializers as "OccupationalRetirementProvisionInstitution".
    /// </summary>
    [EnumMember(Value = "ORPI")]
    [IsoId("_fp8HcQb-EeamHPKpTHjX5Q")]
    [Description(@"Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.")]
    OccupationalRetirementProvisionInstitution,
    
    /// <summary>
    /// Investment firm.
    /// 
    /// Encoded/decoded by serializers as "InvestmentFirm".
    /// </summary>
    [EnumMember(Value = "INVF")]
    [IsoId("_gBo1wQb-EeamHPKpTHjX5Q")]
    [Description(@"Investment firm. ")]
    InvestmentFirm,
    
    /// <summary>
    /// Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.
    /// Encoded/decoded by serializers as "ReinsuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_gMNHAQb-EeamHPKpTHjX5Q")]
    [Description(@"Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.")]
    ReinsuranceUndertaking,
    
    /// <summary>
    /// Undertaking for collective investment in transferable securities (UCITS) and its management company.
    /// Encoded/decoded by serializers as "UCITSManagementCompany".
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_gR6GYQb-EeamHPKpTHjX5Q")]
    [Description(@"Undertaking for collective investment in transferable securities (UCITS) and its management company.")]
    UCITSManagementCompany,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialPartySectorType2CodeMetadataExtensions
{
    private static readonly FinancialPartySectorType2CodeDropdownSource _dropdownSource = new FinancialPartySectorType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialPartySectorType2CodeDropdownRow GetMetadata(this FinancialPartySectorType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


