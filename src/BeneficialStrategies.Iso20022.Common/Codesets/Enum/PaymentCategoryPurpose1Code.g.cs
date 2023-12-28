﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentCategoryPurpose1Code.  ISO2002 ID# _ZzFBo9p-Ed-ak6NoX_4Aeg_11813322.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction that resulted in the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZzFBo9p-Ed-ak6NoX_4Aeg_11813322")]
[Description(@"Specifies the type of transaction that resulted in the payment.")]
[DerivedFrom(typeof(PaymentCategoryPurposeCode))]
public enum PaymentCategoryPurpose1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeSettlementPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzFBpNp-Ed-ak6NoX_4Aeg_11813796")]
    [Description(@"??")]
    TradeSettlementPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SalaryPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzFBpdp-Ed-ak6NoX_4Aeg_11813831")]
    [Description(@"??")]
    SalaryPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TreasuryPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzFBptp-Ed-ak6NoX_4Aeg_11813874")]
    [Description(@"??")]
    TreasuryPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashManagementTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLkNp-Ed-ak6NoX_4Aeg_11814294")]
    [Description(@"??")]
    CashManagementTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Dividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLkdp-Ed-ak6NoX_4Aeg_11814432")]
    [Description(@"??")]
    Dividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GovernmentPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLktp-Ed-ak6NoX_4Aeg_11814840")]
    [Description(@"??")]
    GovernmentPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLk9p-Ed-ak6NoX_4Aeg_11815657")]
    [Description(@"??")]
    Interest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Loan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLlNp-Ed-ak6NoX_4Aeg_11815735")]
    [Description(@"??")]
    Loan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PensionPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLldp-Ed-ak6NoX_4Aeg_11816173")]
    [Description(@"??")]
    PensionPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Securities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLltp-Ed-ak6NoX_4Aeg_11816275")]
    [Description(@"??")]
    Securities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SocialSecurityBenefit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLl9p-Ed-ak6NoX_4Aeg_11816605")]
    [Description(@"??")]
    SocialSecurityBenefit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SupplierPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLmNp-Ed-ak6NoX_4Aeg_12736929")]
    [Description(@"??")]
    SupplierPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzOLmdp-Ed-ak6NoX_4Aeg_12737259")]
    [Description(@"??")]
    TaxPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Trade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzX8kNp-Ed-ak6NoX_4Aeg_12737379")]
    [Description(@"??")]
    Trade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ValueAddedTaxPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzX8kdp-Ed-ak6NoX_4Aeg_12737800")]
    [Description(@"??")]
    ValueAddedTaxPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Hedging".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzX8ktp-Ed-ak6NoX_4Aeg_12738232")]
    [Description(@"??")]
    Hedging,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntraCompanyPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzX8k9p-Ed-ak6NoX_4Aeg_12738747")]
    [Description(@"??")]
    IntraCompanyPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithHolding".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZzX8lNp-Ed-ak6NoX_4Aeg_26591144")]
    [Description(@"??")]
    WithHolding,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentCategoryPurpose1CodeMetadataExtensions
{
    private static readonly PaymentCategoryPurpose1CodeDropdownSource _dropdownSource = new PaymentCategoryPurpose1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentCategoryPurpose1CodeDropdownRow GetMetadata(this PaymentCategoryPurpose1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


