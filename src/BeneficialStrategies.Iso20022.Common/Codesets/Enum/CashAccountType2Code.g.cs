﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashAccountType2Code.  ISO2002 ID# _a24A9dp-Ed-ak6NoX_4Aeg_1132707295.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a24A9dp-Ed-ak6NoX_4Aeg_1132707295")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType2Code
{
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as "CashPayment".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a24A9tp-Ed-ak6NoX_4Aeg_1132707296")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment,
    
    /// <summary>
    /// Account used for charges if different from the account for payment.
    /// Encoded/decoded by serializers as "Charges".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a24A99p-Ed-ak6NoX_4Aeg_1132707297")]
    [Description(@"Account used for charges if different from the account for payment.")]
    Charges,
    
    /// <summary>
    /// Account used for commission if different from the account for payment.
    /// Encoded/decoded by serializers as "Commission".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_a24A-Np-Ed-ak6NoX_4Aeg_1132707523")]
    [Description(@"Account used for commission if different from the account for payment.")]
    Commission,
    
    /// <summary>
    /// Account used for taxes if different from the account for payment.
    /// Encoded/decoded by serializers as "Tax".
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_a24A-dp-Ed-ak6NoX_4Aeg_1132707524")]
    [Description(@"Account used for taxes if different from the account for payment.")]
    Tax,
    
    /// <summary>
    /// Account used for payment of income if different from the current cash account.
    /// Encoded/decoded by serializers as "CashIncome".
    /// </summary>
    [EnumMember(Value = "CISH")]
    [IsoId("_a3Bx8Np-Ed-ak6NoX_4Aeg_1132707525")]
    [Description(@"Account used for payment of income if different from the current cash account.")]
    CashIncome,
    
    /// <summary>
    /// Account used for trading if different from the current cash account.
    /// Encoded/decoded by serializers as "CashTrading".
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_a3Bx8dp-Ed-ak6NoX_4Aeg_1132707526")]
    [Description(@"Account used for trading if different from the current cash account.")]
    CashTrading,
    
    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as "Settlement".
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a3Bx8tp-Ed-ak6NoX_4Aeg_1132707528")]
    [Description(@"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.")]
    Settlement,
    
    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a3Bx89p-Ed-ak6NoX_4Aeg_1132707529")]
    [Description(@"Account used to post debits and credits when no specific account has been nominated.")]
    Current,
    
    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as "Savings".
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a3Bx9Np-Ed-ak6NoX_4Aeg_1132707530")]
    [Description(@"Account used for savings.")]
    Savings,
    
    /// <summary>
    /// Account used for overnight deposits.
    /// Encoded/decoded by serializers as "OverNightDeposit".
    /// </summary>
    [EnumMember(Value = "ONDP")]
    [IsoId("_a3Bx9dp-Ed-ak6NoX_4Aeg_1132707531")]
    [Description(@"Account used for overnight deposits.")]
    OverNightDeposit,
    
    /// <summary>
    /// Account used for a marginal lending facility.
    /// Encoded/decoded by serializers as "MarginalLending".
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_a3Bx9tp-Ed-ak6NoX_4Aeg_1132707532")]
    [Description(@"Account used for a marginal lending facility.")]
    MarginalLending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashAccountType2CodeMetadataExtensions
{
    private static readonly CashAccountType2CodeDropdownSource _dropdownSource = new CashAccountType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashAccountType2CodeDropdownRow GetMetadata(this CashAccountType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


