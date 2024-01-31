﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundCashAccount1Code.  ISO2002 ID# _Virjctp-Ed-ak6NoX_4Aeg_1769080400.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Virjctp-Ed-ak6NoX_4Aeg_1769080400")]
[Description(@"Specifies the cash account type.")]
[DerivedFrom(typeof(FundCashAccountCode))]
public enum FundCashAccount1Code
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Virjc9p-Ed-ak6NoX_4Aeg_-2028108164")]
    [Description(@"Cash account.")]
    CashAccount = FundCashAccountCode.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central Provident Fund (CPF) ordinary account.
    /// Encoded/decoded by serializers as "CPFO".
    /// </summary>
    [EnumMember(Value = "CPFO")]
    [IsoId("_VirjdNp-Ed-ak6NoX_4Aeg_-2028108147")]
    [Description(@"Central Provident Fund (CPF) ordinary account.")]
    PensionFundOrdinary = FundCashAccountCode.PensionFundOrdinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central Provident Fund (CPF) special account.
    /// Encoded/decoded by serializers as "CPFS".
    /// </summary>
    [EnumMember(Value = "CPFS")]
    [IsoId("_Virjddp-Ed-ak6NoX_4Aeg_-2028108129")]
    [Description(@"Central Provident Fund (CPF) special account.")]
    PensionFundSpecial = FundCashAccountCode.PensionFundSpecial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supplementary Retirement Scheme (SRS) account.
    /// Encoded/decoded by serializers as "SRSA".
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_Virjdtp-Ed-ak6NoX_4Aeg_-2028108104")]
    [Description(@"Supplementary Retirement Scheme (SRS) account.")]
    RetirementScheme = FundCashAccountCode.RetirementScheme, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type cash account.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Virjd9p-Ed-ak6NoX_4Aeg_-2021642544")]
    [Description(@"Another type cash account.")]
    Other = FundCashAccountCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundCashAccount1CodeMetadataExtensions
{
    private static readonly FundCashAccount1CodeDropdownSource _dropdownSource = new FundCashAccount1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundCashAccount1CodeDropdownRow GetMetadata(this FundCashAccount1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


