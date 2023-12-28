﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialPartySectorType1Code.  ISO2002 ID# _6kfeUBQXEeWSI-Fz8Zwg6g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "AlternativeInvestmentFund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__Xky0RQXEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    AlternativeInvestmentFund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AssuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__e6w8RQXEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    AssuranceUndertaking,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditInstitution".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__ko-cRQXEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    CreditInstitution,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__q1tERQXEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    InsuranceUndertaking,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvestmentFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zzb0RQXEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    InvestmentFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OccupationalRetirementProvisionInstitution".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__6AKcRQXEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    OccupationalRetirementProvisionInstitution,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReinsuranceUndertaking".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AAAr0RQYEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    ReinsuranceUndertaking,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UCITSManagementCompany".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AFu5URQYEeWSI-Fz8Zwg6g")]
    [Description(@"??")]
    UCITSManagementCompany,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_FpJ3cQFeEeaDfK-zDSyB6A")]
    [Description(@"??")]
    Other,
    
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


