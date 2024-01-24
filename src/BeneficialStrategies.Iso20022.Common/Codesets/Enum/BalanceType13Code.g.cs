﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceType13Code.  ISO2002 ID# _m5hTdfNBEeCuA5Tr22BnwA_454049868.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the kind of the balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m5hTdfNBEeCuA5Tr22BnwA_454049868")]
[Description(@"Specifies the kind of the balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType13Code
{
    /// <summary>
    /// Balance attributed to investments at value.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_m5rEcPNBEeCuA5Tr22BnwA_937976833")]
    [Description(@"Balance attributed to investments at value.")]
    Investments = BalanceTypeCode.Investments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to cash and cash equivalents.
    /// Encoded/decoded by serializers as "CASE".
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_m5rEcfNBEeCuA5Tr22BnwA_937976858")]
    [Description(@"Balance attributed to cash and cash equivalents.")]
    CashAndCashEquivalents = BalanceTypeCode.CashAndCashEquivalents, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to borrowings.
    /// Encoded/decoded by serializers as "BORR".
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_m5rEcvNBEeCuA5Tr22BnwA_937976893")]
    [Description(@"Balance attributed to borrowings.")]
    Borrowings = BalanceTypeCode.Borrowings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to revenues; including dividends, interest, net realised gains/losses etc.
    /// Encoded/decoded by serializers as "REVE".
    /// </summary>
    [EnumMember(Value = "REVE")]
    [IsoId("_m5rEc_NBEeCuA5Tr22BnwA_937976935")]
    [Description(@"Balance attributed to revenues; including dividends, interest, net realised gains/losses etc.")]
    Revenues = BalanceTypeCode.Revenues, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to expenses.
    /// Encoded/decoded by serializers as "EXPN".
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_m5rEdPNBEeCuA5Tr22BnwA_937976988")]
    [Description(@"Balance attributed to expenses.")]
    Expenses = BalanceTypeCode.Expenses, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to investor inflow/outflow (creations, cancellations, income distributions).
    /// Encoded/decoded by serializers as "IIOF".
    /// </summary>
    [EnumMember(Value = "IIOF")]
    [IsoId("_m5rEdfNBEeCuA5Tr22BnwA_481531555")]
    [Description(@"Balance attributed to investor inflow/outflow (creations, cancellations, income distributions).")]
    InvestorInflowOutflow = BalanceTypeCode.InvestorInflowOutflow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed according to a different classification, which is not explictly defined.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_m50OYPNBEeCuA5Tr22BnwA_1924228507")]
    [Description(@"Balance attributed according to a different classification, which is not explictly defined.")]
    Other = BalanceTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to payables.
    /// Encoded/decoded by serializers as "PAYA".
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_m50OYfNBEeCuA5Tr22BnwA_236468793")]
    [Description(@"Balance attributed to payables.")]
    Payables = BalanceTypeCode.Payables, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to receivables.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_m50OYvNBEeCuA5Tr22BnwA_147557580")]
    [Description(@"Balance attributed to receivables.")]
    Receivables = BalanceTypeCode.Receivables, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceType13CodeMetadataExtensions
{
    private static readonly BalanceType13CodeDropdownSource _dropdownSource = new BalanceType13CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceType13CodeDropdownRow GetMetadata(this BalanceType13Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


