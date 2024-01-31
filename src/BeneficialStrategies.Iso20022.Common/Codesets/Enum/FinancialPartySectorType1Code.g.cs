﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialPartySectorType1Code.  ISO2002 ID# _6kfeUBQXEeWSI-Fz8Zwg6g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the taxonomy type of a financial party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6kfeUBQXEeWSI-Fz8Zwg6g")]
[Description(@"Specifies the taxonomy type of a financial party.")]
[DerivedFrom(typeof(FinancialPartySectorTypeCode))]
public enum FinancialPartySectorType1Code
{
    /// <summary>
    /// Alternative investment fund managed by an alternative investment fund manager (AIFM).
    /// Encoded/decoded by serializers as "AIFD".
    /// </summary>
    [EnumMember(Value = "AIFD")]
    [IsoId("__Xky0RQXEeWSI-Fz8Zwg6g")]
    [Description(@"Alternative investment fund managed by an alternative investment fund manager (AIFM).")]
    AlternativeInvestmentFund = FinancialPartySectorTypeCode.AlternativeInvestmentFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Assurance undertaking.
    /// Encoded/decoded by serializers as "ASSU".
    /// </summary>
    [EnumMember(Value = "ASSU")]
    [IsoId("__e6w8RQXEeWSI-Fz8Zwg6g")]
    [Description(@"Assurance undertaking.|")]
    AssuranceUndertaking = FinancialPartySectorTypeCode.AssuranceUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.
    /// Encoded/decoded by serializers as "CDTI".
    /// </summary>
    [EnumMember(Value = "CDTI")]
    [IsoId("__ko-cRQXEeWSI-Fz8Zwg6g")]
    [Description(@"Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.|")]
    CreditInstitution = FinancialPartySectorTypeCode.CreditInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insurance undertaking.
    /// Encoded/decoded by serializers as "INUN".
    /// </summary>
    [EnumMember(Value = "INUN")]
    [IsoId("__q1tERQXEeWSI-Fz8Zwg6g")]
    [Description(@"Insurance undertaking.")]
    InsuranceUndertaking = FinancialPartySectorTypeCode.InsuranceUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment firm.
    /// Encoded/decoded by serializers as "INVF".
    /// </summary>
    [EnumMember(Value = "INVF")]
    [IsoId("__zzb0RQXEeWSI-Fz8Zwg6g")]
    [Description(@"Investment firm.|")]
    InvestmentFirm = FinancialPartySectorTypeCode.InvestmentFirm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.
    /// Encoded/decoded by serializers as "ORPI".
    /// </summary>
    [EnumMember(Value = "ORPI")]
    [IsoId("__6AKcRQXEeWSI-Fz8Zwg6g")]
    [Description(@"Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.")]
    OccupationalRetirementProvisionInstitution = FinancialPartySectorTypeCode.OccupationalRetirementProvisionInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.
    /// Encoded/decoded by serializers as "REIN".
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_AAAr0RQYEeWSI-Fz8Zwg6g")]
    [Description(@"Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.")]
    ReinsuranceUndertaking = FinancialPartySectorTypeCode.ReinsuranceUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undertaking for collective investment in transferable securities (UCITS) and its management company.
    /// Encoded/decoded by serializers as "UCIT".
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_AFu5URQYEeWSI-Fz8Zwg6g")]
    [Description(@"Undertaking for collective investment in transferable securities (UCITS) and its management company.")]
    UCITSManagementCompany = FinancialPartySectorTypeCode.UCITSManagementCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of financial institution.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_FpJ3cQFeEeaDfK-zDSyB6A")]
    [Description(@"Other type of financial institution.")]
    Other = FinancialPartySectorTypeCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialPartySectorType1CodeMetadataExtensions
{
    private static readonly FinancialPartySectorType1CodeDropdownSource _dropdownSource = new FinancialPartySectorType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialPartySectorType1CodeDropdownRow GetMetadata(this FinancialPartySectorType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


