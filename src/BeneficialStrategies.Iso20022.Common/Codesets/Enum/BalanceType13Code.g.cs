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
    /// ??
    /// Encoded/decoded by serializers as "Investments".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m5rEcPNBEeCuA5Tr22BnwA_937976833")]
    [Description(@"??")]
    Investments,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashAndCashEquivalents".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m5rEcfNBEeCuA5Tr22BnwA_937976858")]
    [Description(@"??")]
    CashAndCashEquivalents,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Borrowings".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m5rEcvNBEeCuA5Tr22BnwA_937976893")]
    [Description(@"??")]
    Borrowings,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Revenues".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m5rEc_NBEeCuA5Tr22BnwA_937976935")]
    [Description(@"??")]
    Revenues,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Expenses".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m5rEdPNBEeCuA5Tr22BnwA_937976988")]
    [Description(@"??")]
    Expenses,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvestorInflowOutflow".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m5rEdfNBEeCuA5Tr22BnwA_481531555")]
    [Description(@"??")]
    InvestorInflowOutflow,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m50OYPNBEeCuA5Tr22BnwA_1924228507")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Payables".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m50OYfNBEeCuA5Tr22BnwA_236468793")]
    [Description(@"??")]
    Payables,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Receivables".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m50OYvNBEeCuA5Tr22BnwA_147557580")]
    [Description(@"??")]
    Receivables,
    
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

