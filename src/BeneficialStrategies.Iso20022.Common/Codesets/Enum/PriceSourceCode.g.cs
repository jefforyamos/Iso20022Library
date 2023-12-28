﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceSourceCode.  ISO2002 ID# _aJIKI9p-Ed-ak6NoX_4Aeg_-1943381521.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the source of a price quotation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJIKI9p-Ed-ak6NoX_4Aeg_-1943381521")]
[Description(@"Specifies the source of a price quotation.")]
public enum PriceSourceCode
{
    /// <summary>
    /// Source of price quotation is a fund, eg, transfer agent, fund itself.
    /// Encoded/decoded by serializers as "FUND".
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_aJIKJNp-Ed-ak6NoX_4Aeg_-1823324851")]
    [Description(@"Source of price quotation is a fund, eg, transfer agent, fund itself.")]
    Fund,
    
    /// <summary>
    /// Source of price quotation is a theoretical value based on the market yield.
    /// Encoded/decoded by serializers as "THEO".
    /// </summary>
    [EnumMember(Value = "THEO")]
    [IsoId("_aJIKJdp-Ed-ak6NoX_4Aeg_-1823324834")]
    [Description(@"Source of price quotation is a theoretical value based on the market yield.")]
    Theoretical,
    
    /// <summary>
    /// Source of price quotation is an external vendor.
    /// Encoded/decoded by serializers as "VEND".
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_aJIKJtp-Ed-ak6NoX_4Aeg_-1823324816")]
    [Description(@"Source of price quotation is an external vendor.")]
    Vendor,
    
    /// <summary>
    /// Source of price quotation is a stock exchange.
    /// Encoded/decoded by serializers as "EXCH".
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_5_16kKB6EeOEyO7fCl8lLA")]
    [Description(@"Source of price quotation is a stock exchange.")]
    StockExchange,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceSourceCodeMetadataExtensions
{
    private static readonly PriceSourceCodeDropdownSource _dropdownSource = new PriceSourceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceSourceCodeDropdownRow GetMetadata(this PriceSourceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


