﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProductTypeV2Code.  ISO2002 ID# _g9bYnwOEEeWs3sTa9Sj6Lg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_g9bYnwOEEeWs3sTa9Sj6Lg")]
[Description(@"Specifies the type of product or financial instrument.")]
public enum ProductTypeV2Code
{
    /// <summary>
    /// Identifies categories of instruments issued by federal agencies.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_g9bYoAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments issued by federal agencies.")]
    AGEN,
    
    /// <summary>
    /// Identifies categories of instruments that are commodities.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_g9bYqAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    COMM,
    
    /// <summary>
    /// Identifies categories of instruments issued by corporates.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_g9bYrQOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments issued by corporates.")]
    CORP,
    
    /// <summary>
    /// Identifies categories of currency instruments.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_g9bYpgOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of currency instruments.")]
    CURR,
    
    /// <summary>
    /// Identifies the nature or type of an equity.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_g9bYoQOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies the nature or type of an equity.")]
    EQUI,
    
    /// <summary>
    /// Identifies categories of obligations issued by a government.
    /// </summary>
    [EnumMember(Value = "GOVE")]
    [IsoId("_g9bYpAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of obligations issued by a government.")]
    GOVE,
    
    /// <summary>
    /// Identifies categories of loans.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_g9bYqgOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of loans.")]
    LOAN,
    
    /// <summary>
    /// Identifies categories of short-term debt securities maturing in less than one year.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_g9bYqwOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of short-term debt securities maturing in less than one year.")]
    MOMA,
    
    /// <summary>
    /// Identifies categories of mortgage securities.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_g9bYqQOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of mortgage securities.")]
    MORT,
    
    /// <summary>
    /// Identifies categories of securities issued by states and local governments.
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_g9bYrAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of securities issued by states and local governments.")]
    MUNI,
    
    /// <summary>
    /// Identifies categories of financing instruments.
    /// </summary>
    [EnumMember(Value = "FINA")]
    [IsoId("_g9bYpwOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of financing instruments.")]
    FINA,
    
    /// <summary>
    /// The asset type is property.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_g9bYogOEEeWs3sTa9Sj6Lg")]
    [Description(@"The asset type is property.")]
    PROP,
    
    /// <summary>
    /// The asset type is a swap.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_g9bYpQOEEeWs3sTa9Sj6Lg")]
    [Description(@"The asset type is a swap.")]
    SWAP,
    
    /// <summary>
    /// Other asset type.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_g9bYowOEEeWs3sTa9Sj6Lg")]
    [Description(@"Other asset type.")]
    OTHR,
    
    /// <summary>
    /// Identifies categories of instruments that are interest rates based.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_m3wpAAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments that are interest rates based.")]
    INTR,
    
    /// <summary>
    /// Identifies categories of instruments that are credits.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_uuxBgAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments that are credits.")]
    CRDT,
    
    /// <summary>
    /// Identifies categories of instruments related to Emission Allowance.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_FUiLoGlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies categories of instruments related to Emission Allowance.")]
    EMAL,
    
    /// <summary>
    /// The asset type is bond.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_S7x6kDXvEemdWfjs3tykFQ")]
    [Description(@"The asset type is bond.")]
    BOND,
    
    /// <summary>
    /// The asset type is cash.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_fNm4kDXvEemdWfjs3tykFQ")]
    [Description(@"The asset type is cash.")]
    CASH,
    
    /// <summary>
    /// Asset type is sovereign.
    /// </summary>
    [EnumMember(Value = "SVGN")]
    [IsoId("_qxLCYDXvEemdWfjs3tykFQ")]
    [Description(@"Asset type is sovereign.")]
    SVGN,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProductTypeV2CodeMetadataExtensions
{
    private static readonly ProductTypeV2CodeDropdownSource _dropdownSource = new ProductTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProductTypeV2CodeDropdownRow GetMetadata(this ProductTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


