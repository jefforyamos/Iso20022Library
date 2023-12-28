﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SourceOfCash1Code.  ISO2002 ID# _kWhF0DlHEealR6-8aQ15BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the origin of cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kWhF0DlHEealR6-8aQ15BA")]
[Description(@"Specifies the origin of cash.")]
[DerivedFrom(typeof(SourceOfCashCode))]
public enum SourceOfCash1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Alimony".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ml8KwTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    Alimony,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashProceeds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mwDwETlHEealR6-8aQ15BA")]
    [Description(@"??")]
    CashProceeds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Compensation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mzLVgTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    Compensation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EmployeeIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9S60TlHEealR6-8aQ15BA")]
    [Description(@"??")]
    EmployeeIncome,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Gift".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nAbHUTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    Gift,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Inheritance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nKPKoTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    Inheritance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsurancePremiumLiquidation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nNXXITlHEealR6-8aQ15BA")]
    [Description(@"??")]
    InsurancePremiumLiquidation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RealEstateSale".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nXe8cTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    RealEstateSale,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ngtJ4TlHEealR6-8aQ15BA")]
    [Description(@"??")]
    Redemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RetirementPolicy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_np7XUTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    RetirementPolicy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SaleAquisitionCorporation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nzJkwTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    SaleAquisitionCorporation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SaleOfGoods".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_n2biQTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    SaleOfGoods,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Savings".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oAiggTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    Savings,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SelfEmploymentIncome".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oDqtATlHEealR6-8aQ15BA")]
    [Description(@"??")]
    SelfEmploymentIncome,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Winnings".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oMvwgTlHEealR6-8aQ15BA")]
    [Description(@"??")]
    Winnings,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SourceOfCash1CodeMetadataExtensions
{
    private static readonly SourceOfCash1CodeDropdownSource _dropdownSource = new SourceOfCash1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISourceOfCash1CodeDropdownRow GetMetadata(this SourceOfCash1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

