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
    /// Cash proceeds being reinvested is classified as capital gains.
    /// Encoded/decoded by serializers as "CAPG".
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_ZGVDQXngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as capital gains.")]
    CapitalGains = ReinvestmentIncomeClassificationCode.CapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend.
    /// Encoded/decoded by serializers as "DVCA".
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_aOY3gHngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as cash dividend.")]
    CashDividend = ReinvestmentIncomeClassificationCode.CashDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as special cash dividend.
    /// Encoded/decoded by serializers as "CDPS".
    /// </summary>
    [EnumMember(Value = "CDPS")]
    [IsoId("_akEMkXngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as special cash dividend.")]
    CashDividendSpecial = ReinvestmentIncomeClassificationCode.CashDividendSpecial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as interest.
    /// Encoded/decoded by serializers as "INTR".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_byd5YXngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as interest.")]
    Interest = ReinvestmentIncomeClassificationCode.Interest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as long term capital gains.
    /// Encoded/decoded by serializers as "LTCG".
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_b8HkoXngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as long term capital gains.")]
    LongTermCapitalGains = ReinvestmentIncomeClassificationCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as principal.
    /// Encoded/decoded by serializers as "PRPL".
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_cDn60XngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as principal.")]
    Principal = ReinvestmentIncomeClassificationCode.Principal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as return of capital.
    /// Encoded/decoded by serializers as "ROCA".
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_cJHe0XngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as return of capital.")]
    ReturnOfCapital = ReinvestmentIncomeClassificationCode.ReturnOfCapital, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as short term capital gains.
    /// Encoded/decoded by serializers as "STCG".
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_cOV9EXngEeO2o_OAyvnbZw")]
    [Description(@"Cash proceeds being reinvested is classified as short term capital gains.")]
    ShortTermCapitalGains = ReinvestmentIncomeClassificationCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions
    
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


