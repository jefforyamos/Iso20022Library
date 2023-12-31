﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundCashAccount3Code.  ISO2002 ID# _asmDldp-Ed-ak6NoX_4Aeg_-525778096.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cash account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_asmDldp-Ed-ak6NoX_4Aeg_-525778096")]
[Description(@"Specifies the cash account type.")]
[DerivedFrom(typeof(FundCashAccountCode))]
public enum FundCashAccount3Code
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_asmDltp-Ed-ak6NoX_4Aeg_-525777742")]
    [Description(@"Cash account.")]
    CashAccount,
    
    /// <summary>
    /// Central Provident Fund (CPF) ordinary account.
    /// Encoded/decoded by serializers as "PensionFundOrdinary".
    /// </summary>
    [EnumMember(Value = "CPFO")]
    [IsoId("_asmDl9p-Ed-ak6NoX_4Aeg_-525777682")]
    [Description(@"Central Provident Fund (CPF) ordinary account.")]
    PensionFundOrdinary,
    
    /// <summary>
    /// Central Provident Fund (CPF) special account.
    /// Encoded/decoded by serializers as "PensionFundSpecial".
    /// </summary>
    [EnumMember(Value = "CPFS")]
    [IsoId("_asmDmNp-Ed-ak6NoX_4Aeg_-525777399")]
    [Description(@"Central Provident Fund (CPF) special account.")]
    PensionFundSpecial,
    
    /// <summary>
    /// Supplementary Retirement Scheme (SRS) account.
    /// Encoded/decoded by serializers as "RetirementScheme".
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_asv0kNp-Ed-ak6NoX_4Aeg_-525777321")]
    [Description(@"Supplementary Retirement Scheme (SRS) account.")]
    RetirementScheme,
    
    /// <summary>
    /// Hedge fund account.
    /// Encoded/decoded by serializers as "HedgeFund".
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_asv0kdp-Ed-ak6NoX_4Aeg_1643305890")]
    [Description(@"Hedge fund account.")]
    HedgeFund,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundCashAccount3CodeMetadataExtensions
{
    private static readonly FundCashAccount3CodeDropdownSource _dropdownSource = new FundCashAccount3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundCashAccount3CodeDropdownRow GetMetadata(this FundCashAccount3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


