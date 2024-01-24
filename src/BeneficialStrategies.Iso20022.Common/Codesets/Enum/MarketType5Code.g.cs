﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarketType5Code.  ISO2002 ID# _aUwLUNp-Ed-ak6NoX_4Aeg_270418666.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUwLUNp-Ed-ak6NoX_4Aeg_270418666")]
[Description(@"Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.")]
[DerivedFrom(typeof(MarketTypeCode))]
public enum MarketType5Code
{
    /// <summary>
    /// The place is over the counter.
    /// Encoded/decoded by serializers as "OTCO".
    /// </summary>
    [EnumMember(Value = "OTCO")]
    [IsoId("_aUwLUdp-Ed-ak6NoX_4Aeg_1589066038")]
    [Description(@"The place is over the counter.")]
    OverTheCounter = MarketTypeCode.OverTheCounter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The place is a stock exchange.
    /// Encoded/decoded by serializers as "EXCH".
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_aUwLUtp-Ed-ak6NoX_4Aeg_-1956234882")]
    [Description(@"The place is a stock exchange.")]
    StockExchange = MarketTypeCode.StockExchange, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MarketType5CodeMetadataExtensions
{
    private static readonly MarketType5CodeDropdownSource _dropdownSource = new MarketType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMarketType5CodeDropdownRow GetMetadata(this MarketType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


