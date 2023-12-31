﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialPartySectorType3Code.  ISO2002 ID# _WZwpASI5Ee2zWP9pqvmqdw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the reporting counterparty business activities. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WZwpASI5Ee2zWP9pqvmqdw")]
[Description(@"Specifies the nature of the reporting counterparty business activities. ")]
[DerivedFrom(typeof(FinancialPartySectorTypeCode))]
public enum FinancialPartySectorType3Code
{
    /// <summary>
    /// Alternative investment fund managed by an alternative investment fund manager (AIFM).
    /// Encoded/decoded by serializers as "AlternativeInvestmentFund".
    /// </summary>
    [EnumMember(Value = "AIFD")]
    [IsoId("_WatrQSI5Ee2zWP9pqvmqdw")]
    [Description(@"Alternative investment fund managed by an alternative investment fund manager (AIFM).")]
    AlternativeInvestmentFund,
    
    /// <summary>
    /// Central securities depository.
    /// Encoded/decoded by serializers as "CentralSecuritiesDepository".
    /// </summary>
    [EnumMember(Value = "CSDS")]
    [IsoId("_WatrQyI5Ee2zWP9pqvmqdw")]
    [Description(@"Central securities depository.")]
    CentralSecuritiesDepository,
    
    /// <summary>
    /// Central counterparty.
    /// Encoded/decoded by serializers as "CentralCounterparty".
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_WatrRSI5Ee2zWP9pqvmqdw")]
    [Description(@"Central counterparty.")]
    CentralCounterparty,
    
    /// <summary>
    /// Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.
    /// 
    /// Encoded/decoded by serializers as "CreditInstitution".
    /// </summary>
    [EnumMember(Value = "CDTI")]
    [IsoId("_WatrRyI5Ee2zWP9pqvmqdw")]
    [Description(@"Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account. ")]
    CreditInstitution,
    
    /// <summary>
    /// Insurance undertaking.
    /// Encoded/decoded by serializers as "InsuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "INUN")]
    [IsoId("_WatrSSI5Ee2zWP9pqvmqdw")]
    [Description(@"Insurance undertaking.")]
    InsuranceUndertaking,
    
    /// <summary>
    /// Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.
    /// Encoded/decoded by serializers as "OccupationalRetirementProvisionInstitution".
    /// </summary>
    [EnumMember(Value = "ORPI")]
    [IsoId("_WatrSyI5Ee2zWP9pqvmqdw")]
    [Description(@"Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.")]
    OccupationalRetirementProvisionInstitution,
    
    /// <summary>
    /// Investment firm.
    /// 
    /// Encoded/decoded by serializers as "InvestmentFirm".
    /// </summary>
    [EnumMember(Value = "INVF")]
    [IsoId("_WatrTSI5Ee2zWP9pqvmqdw")]
    [Description(@"Investment firm. ")]
    InvestmentFirm,
    
    /// <summary>
    /// Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.
    /// Encoded/decoded by serializers as "ReinsuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_WatrTyI5Ee2zWP9pqvmqdw")]
    [Description(@"Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.")]
    ReinsuranceUndertaking,
    
    /// <summary>
    /// Undertaking for collective investment in transferable securities (UCITS) and its management company.
    /// Encoded/decoded by serializers as "UCITSManagementCompany".
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_WatrUSI5Ee2zWP9pqvmqdw")]
    [Description(@"Undertaking for collective investment in transferable securities (UCITS) and its management company.")]
    UCITSManagementCompany,
    
    /// <summary>
    /// Assurance undertaking.
    /// 
    /// Encoded/decoded by serializers as "AssuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "ASSU")]
    [IsoId("_XLlukSI5Ee2zWP9pqvmqdw")]
    [Description(@"Assurance undertaking. ")]
    AssuranceUndertaking,
    
    /// <summary>
    /// Other type of financial institution.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_XS7ssSI5Ee2zWP9pqvmqdw")]
    [Description(@"Other type of financial institution.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialPartySectorType3CodeMetadataExtensions
{
    private static readonly FinancialPartySectorType3CodeDropdownSource _dropdownSource = new FinancialPartySectorType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialPartySectorType3CodeDropdownRow GetMetadata(this FinancialPartySectorType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


