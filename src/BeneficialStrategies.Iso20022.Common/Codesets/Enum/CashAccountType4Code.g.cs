﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashAccountType4Code.  ISO2002 ID# _a3K75Np-Ed-ak6NoX_4Aeg_-1444721348.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3K75Np-Ed-ak6NoX_4Aeg_-1444721348")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType4Code
{
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as "CashPayment".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a3Us4Np-Ed-ak6NoX_4Aeg_-1444721331")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment,
    
    /// <summary>
    /// Account used for charges if different from the account for payment.
    /// Encoded/decoded by serializers as "Charges".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a3Us4dp-Ed-ak6NoX_4Aeg_-1444721313")]
    [Description(@"Account used for charges if different from the account for payment.")]
    Charges,
    
    /// <summary>
    /// Account used for commission if different from the account for payment.
    /// Encoded/decoded by serializers as "Commission".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_a3Us4tp-Ed-ak6NoX_4Aeg_-1444721288")]
    [Description(@"Account used for commission if different from the account for payment.")]
    Commission,
    
    /// <summary>
    /// Account used for taxes if different from the account for payment.
    /// Encoded/decoded by serializers as "Tax".
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_a3Us49p-Ed-ak6NoX_4Aeg_-1444721271")]
    [Description(@"Account used for taxes if different from the account for payment.")]
    Tax,
    
    /// <summary>
    /// Account used for payment of income if different from the current cash account.
    /// Encoded/decoded by serializers as "CashIncome".
    /// </summary>
    [EnumMember(Value = "CISH")]
    [IsoId("_a3Us5Np-Ed-ak6NoX_4Aeg_-1444721036")]
    [Description(@"Account used for payment of income if different from the current cash account.")]
    CashIncome,
    
    /// <summary>
    /// Account used for trading if different from the current cash account.
    /// Encoded/decoded by serializers as "CashTrading".
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_a3Us5dp-Ed-ak6NoX_4Aeg_-1444721019")]
    [Description(@"Account used for trading if different from the current cash account.")]
    CashTrading,
    
    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as "Settlement".
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a3Us5tp-Ed-ak6NoX_4Aeg_-1444721018")]
    [Description(@"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.")]
    Settlement,
    
    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a3Us59p-Ed-ak6NoX_4Aeg_-1444721001")]
    [Description(@"Account used to post debits and credits when no specific account has been nominated.")]
    Current,
    
    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as "Savings".
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a3Us6Np-Ed-ak6NoX_4Aeg_-1444720976")]
    [Description(@"Account used for savings.")]
    Savings,
    
    /// <summary>
    /// Account used for overnight deposits.
    /// Encoded/decoded by serializers as "OverNightDeposit".
    /// </summary>
    [EnumMember(Value = "ONDP")]
    [IsoId("_a3Us6dp-Ed-ak6NoX_4Aeg_-1444720959")]
    [Description(@"Account used for overnight deposits.")]
    OverNightDeposit,
    
    /// <summary>
    /// Account used for a marginal lending facility.
    /// Encoded/decoded by serializers as "MarginalLending".
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_a3ed4Np-Ed-ak6NoX_4Aeg_-1444720940")]
    [Description(@"Account used for a marginal lending facility.")]
    MarginalLending,
    
    /// <summary>
    /// Account used for non-resident external.
    /// Encoded/decoded by serializers as "NonResidentExternal".
    /// </summary>
    [EnumMember(Value = "NREX")]
    [IsoId("_a3ed4dp-Ed-ak6NoX_4Aeg_-1385617969")]
    [Description(@"Account used for non-resident external.")]
    NonResidentExternal,
    
    /// <summary>
    /// Account used for money markets if different from the cash account.
    /// Encoded/decoded by serializers as "MoneyMarket".
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_a3ed4tp-Ed-ak6NoX_4Aeg_-1385617950")]
    [Description(@"Account used for money markets if different from the cash account.")]
    MoneyMarket,
    
    /// <summary>
    /// Account used for loans.
    /// Encoded/decoded by serializers as "Loan".
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_a3ed49p-Ed-ak6NoX_4Aeg_-1385617925")]
    [Description(@"Account used for loans.")]
    Loan,
    
    /// <summary>
    /// Accounts used for salary payments.
    /// Encoded/decoded by serializers as "Salary".
    /// </summary>
    [EnumMember(Value = "SLRY")]
    [IsoId("_a3ed5Np-Ed-ak6NoX_4Aeg_-1385617908")]
    [Description(@"Accounts used for salary payments.")]
    Salary,
    
    /// <summary>
    /// Account is used for overdrafts.
    /// Encoded/decoded by serializers as "Overdraft".
    /// </summary>
    [EnumMember(Value = "ODFT")]
    [IsoId("_a3ed5dp-Ed-ak6NoX_4Aeg_-1385617890")]
    [Description(@"Account is used for overdrafts.")]
    Overdraft,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashAccountType4CodeMetadataExtensions
{
    private static readonly CashAccountType4CodeDropdownSource _dropdownSource = new CashAccountType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashAccountType4CodeDropdownRow GetMetadata(this CashAccountType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


