﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarketTypeCode.  ISO2002 ID# _aUwLU9p-Ed-ak6NoX_4Aeg_1124995296.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUwLU9p-Ed-ak6NoX_4Aeg_1124995296")]
[Description(@"Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.")]
public enum MarketTypeCode
{
    /// <summary>
    /// The place is a primary market.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_aUwLVNp-Ed-ak6NoX_4Aeg_1011156230")]
    [Description(@"The place is a primary market.")]
    PRIM,
    
    /// <summary>
    /// The place is a secondary market.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_aUwLVdp-Ed-ak6NoX_4Aeg_306041615")]
    [Description(@"The place is a secondary market.")]
    SECM,
    
    /// <summary>
    /// The place is a third market.
    /// </summary>
    [EnumMember(Value = "THIM")]
    [IsoId("_aUwLVtp-Ed-ak6NoX_4Aeg_-869149410")]
    [Description(@"The place is a third market.")]
    THIM,
    
    /// <summary>
    /// The place is a fourth market.
    /// </summary>
    [EnumMember(Value = "FOUM")]
    [IsoId("_aUwLV9p-Ed-ak6NoX_4Aeg_776118025")]
    [Description(@"The place is a fourth market.")]
    FOUM,
    
    /// <summary>
    /// The place is over the counter.
    /// </summary>
    [EnumMember(Value = "OTCO")]
    [IsoId("_aUwLWNp-Ed-ak6NoX_4Aeg_-1980060829")]
    [Description(@"The place is over the counter.")]
    OTCO,
    
    /// <summary>
    /// Various places.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_aU58UNp-Ed-ak6NoX_4Aeg_1609791852")]
    [Description(@"Various places.")]
    VARI,
    
    /// <summary>
    /// The place is a stock exchange.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_aU58Udp-Ed-ak6NoX_4Aeg_434600827")]
    [Description(@"The place is a stock exchange.")]
    EXCH,
    
    /// <summary>
    /// The place is a fund (transfer agent, fund itself, etc.).
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_aU58Utp-Ed-ak6NoX_4Aeg_-1340620878")]
    [Description(@"The place is a fund (transfer agent, fund itself, etc.).")]
    FUND,
    
    /// <summary>
    /// The place is a local market.
    /// </summary>
    [EnumMember(Value = "LMAR")]
    [IsoId("_aU58U9p-Ed-ak6NoX_4Aeg_1499568600")]
    [Description(@"The place is a local market.")]
    LMAR,
    
    /// <summary>
    /// The place is theoretical.
    /// </summary>
    [EnumMember(Value = "THEO")]
    [IsoId("_aU58VNp-Ed-ak6NoX_4Aeg_-1975383519")]
    [Description(@"The place is theoretical.")]
    THEO,
    
    /// <summary>
    /// The place is a vendor.
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_aU58Vdp-Ed-ak6NoX_4Aeg_-692811024")]
    [Description(@"The place is a vendor.")]
    VEND,
    
    /// <summary>
    /// Specified type of market is inter bank market.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_l8xukDxHEeWZTovCemTvqg")]
    [Description(@"Specified type of market is inter bank market.")]
    INBA,
    
    /// <summary>
    /// Specified type of market is counter market.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_tWXyUDxHEeWZTovCemTvqg")]
    [Description(@"Specified type of market is counter market.")]
    COUN,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MarketTypeCodeMetadataExtensions
{
    private static readonly MarketTypeCodeDropdownSource _dropdownSource = new MarketTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMarketTypeCodeDropdownRow GetMetadata(this MarketTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


