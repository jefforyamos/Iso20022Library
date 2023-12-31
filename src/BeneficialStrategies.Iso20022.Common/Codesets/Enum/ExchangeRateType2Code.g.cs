﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExchangeRateType2Code.  ISO2002 ID# _YuZqcIZ3Eeufof77RM8ObQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code used to define the type of the currency exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuZqcIZ3Eeufof77RM8ObQ")]
[Description(@"Code used to define the type of the currency exchange.")]
[DerivedFrom(typeof(ExchangeRateTypeCode))]
public enum ExchangeRateType2Code
{
    /// <summary>
    /// Exchange rate is the Sell rate.
    /// Encoded/decoded by serializers as "Sell".
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_cstTEYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Sell rate.")]
    Sell,
    
    /// <summary>
    /// Exchange rate type is privately defined.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_dMtBwYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate type is privately defined.")]
    OtherPrivate,
    
    /// <summary>
    /// Exchange rate type that is defined at the National level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_dsjmgYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate type that is defined at the National level.")]
    OtherNational,
    
    /// <summary>
    /// Exchange rate is the Middle rate.
    /// Encoded/decoded by serializers as "Middle".
    /// </summary>
    [EnumMember(Value = "MIDL")]
    [IsoId("_eNdUIYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Middle rate.")]
    Middle,
    
    /// <summary>
    /// Exchange rate is the Buy rate.
    /// Encoded/decoded by serializers as "Buy".
    /// </summary>
    [EnumMember(Value = "BUYR")]
    [IsoId("_eNfJUYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Buy rate.")]
    Buy,
    
    /// <summary>
    /// Exchange rate applied is the rate agreed between the parties.
    /// Encoded/decoded by serializers as "Agreed".
    /// </summary>
    [EnumMember(Value = "AGRD")]
    [IsoId("_ewAnkYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate applied is the rate agreed between the parties.")]
    Agreed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExchangeRateType2CodeMetadataExtensions
{
    private static readonly ExchangeRateType2CodeDropdownSource _dropdownSource = new ExchangeRateType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExchangeRateType2CodeDropdownRow GetMetadata(this ExchangeRateType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


