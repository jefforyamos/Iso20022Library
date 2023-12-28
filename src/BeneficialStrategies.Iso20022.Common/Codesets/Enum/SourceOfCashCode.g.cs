﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SourceOfCashCode.  ISO2002 ID# _2DXCYDlEEealR6-8aQ15BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the origin of cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2DXCYDlEEealR6-8aQ15BA")]
[Description(@"Specifies the origin of cash.")]
public enum SourceOfCashCode
{
    /// <summary>
    /// Income from a retirement policy.
    /// Encoded/decoded by serializers as "REPY".
    /// </summary>
    [EnumMember(Value = "REPY")]
    [IsoId("_LMUZIDlFEealR6-8aQ15BA")]
    [Description(@"Income from a retirement policy.")]
    RetirementPolicy,
    
    /// <summary>
    /// Income from self-employment.
    /// Encoded/decoded by serializers as "SELF".
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_LSIGMDlFEealR6-8aQ15BA")]
    [Description(@"Income from self-employment.")]
    SelfEmploymentIncome,
    
    /// <summary>
    /// Employee income.
    /// Encoded/decoded by serializers as "EMIN".
    /// </summary>
    [EnumMember(Value = "EMIN")]
    [IsoId("_LWu5YDlFEealR6-8aQ15BA")]
    [Description(@"Employee income.")]
    EmployeeIncome,
    
    /// <summary>
    /// Income from a savings plan.
    /// Encoded/decoded by serializers as "SVGS".
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_La5nsDlFEealR6-8aQ15BA")]
    [Description(@"Income from a savings plan.")]
    Savings,
    
    /// <summary>
    /// Income was a cash gift.
    /// Encoded/decoded by serializers as "GIFT".
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_R35gUDlFEealR6-8aQ15BA")]
    [Description(@"Income was a cash gift.")]
    Gift,
    
    /// <summary>
    /// Cash from an inheritance.
    /// Encoded/decoded by serializers as "INHE".
    /// </summary>
    [EnumMember(Value = "INHE")]
    [IsoId("_R-J5UDlFEealR6-8aQ15BA")]
    [Description(@"Cash from an inheritance.")]
    Inheritance,
    
    /// <summary>
    /// Redemption of an investment fund.
    /// Encoded/decoded by serializers as "REDM".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_UxIXQDlFEealR6-8aQ15BA")]
    [Description(@"Redemption of an investment fund.")]
    Redemption,
    
    /// <summary>
    /// Income from a cash win.
    /// Encoded/decoded by serializers as "WINS".
    /// </summary>
    [EnumMember(Value = "WINS")]
    [IsoId("_U5UC4DlFEealR6-8aQ15BA")]
    [Description(@"Income from a cash win.")]
    Winnings,
    
    /// <summary>
    /// Income from the liquidation of an insurance premium.
    /// Encoded/decoded by serializers as "INLQ".
    /// </summary>
    [EnumMember(Value = "INLQ")]
    [IsoId("_XwwKEDlFEealR6-8aQ15BA")]
    [Description(@"Income from the liquidation of an insurance premium.")]
    InsurancePremiumLiquidation,
    
    /// <summary>
    /// Sale of goods.
    /// Encoded/decoded by serializers as "SALE".
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_azpTUDlFEealR6-8aQ15BA")]
    [Description(@"Sale of goods.")]
    SaleOfGoods,
    
    /// <summary>
    /// Income from the sale of real estate.
    /// Encoded/decoded by serializers as "REST".
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_fy6psDlFEealR6-8aQ15BA")]
    [Description(@"Income from the sale of real estate.")]
    RealEstateSale,
    
    /// <summary>
    /// Sale and acquisition of a corporation.
    /// Encoded/decoded by serializers as "SEAQ".
    /// </summary>
    [EnumMember(Value = "SEAQ")]
    [IsoId("_heCHsDlFEealR6-8aQ15BA")]
    [Description(@"Sale and acquisition of a corporation.")]
    SaleAquisitionCorporation,
    
    /// <summary>
    /// Income is cash proceeds from customers.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_nWlPcDlFEealR6-8aQ15BA")]
    [Description(@"Income is cash proceeds from customers.")]
    CashProceeds,
    
    /// <summary>
    /// Income as a result of alimony.
    /// Encoded/decoded by serializers as "ALMY".
    /// </summary>
    [EnumMember(Value = "ALMY")]
    [IsoId("_poFYADlFEealR6-8aQ15BA")]
    [Description(@"Income as a result of alimony.")]
    Alimony,
    
    /// <summary>
    /// Income is from compensation received.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_puor8DlFEealR6-8aQ15BA")]
    [Description(@"Income is from compensation received.")]
    Compensation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SourceOfCashCodeMetadataExtensions
{
    private static readonly SourceOfCashCodeDropdownSource _dropdownSource = new SourceOfCashCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISourceOfCashCodeDropdownRow GetMetadata(this SourceOfCashCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

