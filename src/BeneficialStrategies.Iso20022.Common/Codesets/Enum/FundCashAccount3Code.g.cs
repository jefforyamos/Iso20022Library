﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundCashAccount3Code.  ISO2002 ID# _asmDldp-Ed-ak6NoX_4Aeg_-525778096.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_asmDltp-Ed-ak6NoX_4Aeg_-525777742")]
    [Description(@"Cash account.")]
    CashAccount = FundCashAccountCode.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central Provident Fund (CPF) ordinary account.
    /// Encoded/decoded by serializers as "CPFO".
    /// </summary>
    [EnumMember(Value = "CPFO")]
    [IsoId("_asmDl9p-Ed-ak6NoX_4Aeg_-525777682")]
    [Description(@"Central Provident Fund (CPF) ordinary account.")]
    PensionFundOrdinary = FundCashAccountCode.PensionFundOrdinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central Provident Fund (CPF) special account.
    /// Encoded/decoded by serializers as "CPFS".
    /// </summary>
    [EnumMember(Value = "CPFS")]
    [IsoId("_asmDmNp-Ed-ak6NoX_4Aeg_-525777399")]
    [Description(@"Central Provident Fund (CPF) special account.")]
    PensionFundSpecial = FundCashAccountCode.PensionFundSpecial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supplementary Retirement Scheme (SRS) account.
    /// Encoded/decoded by serializers as "SRSA".
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_asv0kNp-Ed-ak6NoX_4Aeg_-525777321")]
    [Description(@"Supplementary Retirement Scheme (SRS) account.")]
    RetirementScheme = FundCashAccountCode.RetirementScheme, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hedge fund account.
    /// Encoded/decoded by serializers as "HEDG".
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_asv0kdp-Ed-ak6NoX_4Aeg_1643305890")]
    [Description(@"Hedge fund account.")]
    HedgeFund = FundCashAccountCode.HedgeFund, // same ordinal as derivation source for type conversions
    
}
