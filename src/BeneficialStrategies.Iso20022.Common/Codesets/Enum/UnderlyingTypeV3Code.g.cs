﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingTypeV3Code.  ISO2002 ID# _JuMQeH50EeasY4u9QTizPQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JuMQeH50EeasY4u9QTizPQ")]
[Description(@"Specifies the underlying financial instrument.")]
public enum UnderlyingTypeV3Code
{
    /// <summary>
    /// Underlying is a basket.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_JuMQjn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a basket.")]
    BSKT,
    
    /// <summary>
    /// Underlying is a bond.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_JuMQin50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a bond.")]
    BOND,
    
    /// <summary>
    /// Underlying is a bond future.
    /// </summary>
    [EnumMember(Value = "BNDF")]
    [IsoId("_JuMQgH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a bond future.")]
    BNDF,
    
    /// <summary>
    /// Underlying is a commodity.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_JuMQiH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a commodity.")]
    COMM,
    
    /// <summary>
    /// Underlying is a currency.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_JuMQiX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a currency.")]
    CURR,
    
    /// <summary>
    /// Underlying is a dividend index.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_JuMQhX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a dividend index.")]
    DIVI,
    
    /// <summary>
    /// Underlying is an equity.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_JuMQhH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an equity.")]
    EQUI,
    
    /// <summary>
    /// Underlying is an exchange traded fund.
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_JuMQeX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an exchange traded fund.")]
    ETFS,
    
    /// <summary>
    /// Underlying is a future.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_JuMQe350EeasY4u9QTizPQ")]
    [Description(@"Underlying is a future.")]
    FUTR,
    
    /// <summary>
    /// Underlying is a future on equity.
    /// </summary>
    [EnumMember(Value = "FTEQ")]
    [IsoId("_JuMQfH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a future on equity.")]
    FTEQ,
    
    /// <summary>
    /// Underlying is an index.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_JuMQf350EeasY4u9QTizPQ")]
    [Description(@"Underlying is an index.")]
    INDX,
    
    /// <summary>
    /// Underlying is interest rate.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_JuMQfn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is interest rate.")]
    INTR,
    
    /// <summary>
    /// Underlying is an option.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_JuMQgX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an option.")]
    OPTN,
    
    /// <summary>
    /// Underlying is an option on equity.
    /// </summary>
    [EnumMember(Value = "OPEQ")]
    [IsoId("_JuMQjH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an option on equity.")]
    OPEQ,
    
    /// <summary>
    /// Underlying is of other type.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_JuMQen50EeasY4u9QTizPQ")]
    [Description(@"Underlying is of other type.")]
    OTHR,
    
    /// <summary>
    /// Underlying is precious metal.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_JuMQg350EeasY4u9QTizPQ")]
    [Description(@"Underlying is precious metal.")]
    PRME,
    
    /// <summary>
    /// Underlying is a share.
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_JuMQjX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a share.")]
    SHRS,
    
    /// <summary>
    /// Underlying is a stock dividend.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_JuMQgn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a stock dividend.")]
    DVSE,
    
    /// <summary>
    /// Underlying is a stock index.
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_JuMQi350EeasY4u9QTizPQ")]
    [Description(@"Underlying is a stock index.")]
    STIX,
    
    /// <summary>
    /// Underlying is a swap.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_JuMQhn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a swap.")]
    SWAP,
    
    /// <summary>
    /// Underlying is a volatility index.
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_JuMQh350EeasY4u9QTizPQ")]
    [Description(@"Underlying is a volatility index.")]
    VOLI,
    
    /// <summary>
    /// Underlying is an interest rate future or a forward rate agreement (FRA).
    /// </summary>
    [EnumMember(Value = "IFUT")]
    [IsoId("_JuMQj350EeasY4u9QTizPQ")]
    [Description(@"Underlying is an interest rate future or a forward rate agreement (FRA).")]
    IFUT,
    
    /// <summary>
    /// Underlying is an emission allowance.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_JuMQfX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an emission allowance.")]
    EMAL,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingTypeV3CodeMetadataExtensions
{
    private static readonly UnderlyingTypeV3CodeDropdownSource _dropdownSource = new UnderlyingTypeV3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingTypeV3CodeDropdownRow GetMetadata(this UnderlyingTypeV3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


