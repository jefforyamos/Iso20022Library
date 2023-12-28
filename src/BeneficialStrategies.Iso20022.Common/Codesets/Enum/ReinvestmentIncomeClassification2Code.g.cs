﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReinvestmentIncomeClassification2Code.  ISO2002 ID# _WqyN4HngEeO2o_OAyvnbZw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of cash proceeds that the holder is eligible to reinvest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WqyN4HngEeO2o_OAyvnbZw")]
[Description(@"Specifies the type of cash proceeds that the holder is eligible to reinvest.")]
[DerivedFrom(typeof(ReinvestmentIncomeClassificationCode))]
public enum ReinvestmentIncomeClassification2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CapitalGains".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZGVDQXngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    CapitalGains,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aOY3gHngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    CashDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashDividendSpecial".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_akEMkXngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    CashDividendSpecial,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_byd5YXngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    Interest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LongTermCapitalGains".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_b8HkoXngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    LongTermCapitalGains,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Principal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cDn60XngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    Principal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReturnOfCapital".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cJHe0XngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    ReturnOfCapital,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShortTermCapitalGains".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cOV9EXngEeO2o_OAyvnbZw")]
    [Description(@"??")]
    ShortTermCapitalGains,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReinvestmentIncomeClassification2CodeMetadataExtensions
{
    private static readonly ReinvestmentIncomeClassification2CodeDropdownSource _dropdownSource = new ReinvestmentIncomeClassification2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReinvestmentIncomeClassification2CodeDropdownRow GetMetadata(this ReinvestmentIncomeClassification2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


