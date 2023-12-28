﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingTypeV2Code.  ISO2002 ID# _01GtYOJOEeWKDJcMqE1cSA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_01GtYOJOEeWKDJcMqE1cSA")]
[Description(@"Specifies the underlying financial instrument.")]
public enum UnderlyingTypeV2Code
{
    /// <summary>
    /// Underlying is a basket.
    /// Encoded/decoded by serializers as "BSKT".
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_Bv_2gOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a basket.")]
    Basket,
    
    /// <summary>
    /// Underlying is a bond.
    /// Encoded/decoded by serializers as "BOND".
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_DCjDgOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a bond.")]
    Bond,
    
    /// <summary>
    /// Underlying is a bond future.
    /// Encoded/decoded by serializers as "BNDF".
    /// </summary>
    [EnumMember(Value = "BNDF")]
    [IsoId("_El5FkOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a bond future.")]
    BondFuture,
    
    /// <summary>
    /// Underlying is a commodity.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_GewEoOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a commodity.")]
    Commodity,
    
    /// <summary>
    /// Underlying is a currency.
    /// Encoded/decoded by serializers as "CURR".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_IJ9CMOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a currency.")]
    Currency,
    
    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as "DIVI".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_KLIPwOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex,
    
    /// <summary>
    /// Underlying is an equity.
    /// Encoded/decoded by serializers as "EQUI".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_MapbUOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an equity.")]
    Equity,
    
    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as "ETFT".
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_ODfBYOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund,
    
    /// <summary>
    /// Underlying is a future.
    /// Encoded/decoded by serializers as "FUTR".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_dMyi0OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a future.")]
    Future,
    
    /// <summary>
    /// Underlying is a future on equity.
    /// Encoded/decoded by serializers as "FTEQ".
    /// </summary>
    [EnumMember(Value = "FTEQ")]
    [IsoId("_gEvnYOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a future on equity.")]
    FutureOnEquity,
    
    /// <summary>
    /// Underlying is an index.
    /// Encoded/decoded by serializers as "INDX".
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_iIhdAOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an index.")]
    Index,
    
    /// <summary>
    /// Underlying is interest.
    /// Encoded/decoded by serializers as "INTR".
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_jmvugOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is interest.")]
    Interest,
    
    /// <summary>
    /// Underlying is an option.
    /// Encoded/decoded by serializers as "OPTN".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_lnYwkOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an option.")]
    Option,
    
    /// <summary>
    /// Underlying is an option on equity.
    /// Encoded/decoded by serializers as "OPEQ".
    /// </summary>
    [EnumMember(Value = "OPEQ")]
    [IsoId("_m9iEIOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an option on equity.")]
    OptionOnEquity,
    
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_olTTMOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is of other type.")]
    Other,
    
    /// <summary>
    /// Underlying is precious metal.
    /// Encoded/decoded by serializers as "PRME".
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_pvdZMOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is precious metal.")]
    PreciousMetal,
    
    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as "SHAR".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_rj0SwOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a share.")]
    Share,
    
    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as "DVSE".
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_strd0OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend,
    
    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as "STIX".
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_vALE4OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a stock index.")]
    StockIndex,
    
    /// <summary>
    /// Underlying is a swap.
    /// Encoded/decoded by serializers as "SWAP".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_w5PfUOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a swap.")]
    Swap,
    
    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as "VOLI".
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_yJSK4OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex,
    
    /// <summary>
    /// Underlying is an interest rate future or a forward rate agreement (FRA).
    /// Encoded/decoded by serializers as "IFUT".
    /// </summary>
    [EnumMember(Value = "IFUT")]
    [IsoId("_UQtCgDfLEeaXwbucHIjFhw")]
    [Description(@"Underlying is an interest rate future or a forward rate agreement (FRA).")]
    InterestRateFutureFRA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingTypeV2CodeMetadataExtensions
{
    private static readonly UnderlyingTypeV2CodeDropdownSource _dropdownSource = new UnderlyingTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingTypeV2CodeDropdownRow GetMetadata(this UnderlyingTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


