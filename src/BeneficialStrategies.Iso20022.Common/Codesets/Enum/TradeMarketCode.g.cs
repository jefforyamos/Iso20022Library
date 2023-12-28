﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeMarketCode.  ISO2002 ID# _tVVDYKcAEeSyQqZ4APDtOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a code for a trade market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tVVDYKcAEeSyQqZ4APDtOA")]
[Description(@"Specifies a code for a trade market.")]
public enum TradeMarketCode
{
    /// <summary>
    /// Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.
    /// Encoded/decoded by serializers as "NFTA".
    /// </summary>
    [EnumMember(Value = "NFTA")]
    [IsoId("_G-kucKcBEeSyQqZ4APDtOA")]
    [Description(@"Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.")]
    NAFTA,
    
    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as "INTL".
    /// </summary>
    [EnumMember(Value = "INTL")]
    [IsoId("_9ABlMKcBEeSyQqZ4APDtOA")]
    [Description(@"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    International,
    
    /// <summary>
    /// Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).
    /// Encoded/decoded by serializers as "FRDT".
    /// </summary>
    [EnumMember(Value = "FRDT")]
    [IsoId("_UnHLQKcCEeSyQqZ4APDtOA")]
    [Description(@"Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).")]
    FrenchDomTom,
    
    /// <summary>
    /// Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as "EUDM".
    /// </summary>
    [EnumMember(Value = "EUDM")]
    [IsoId("_hB8UQKcCEeSyQqZ4APDtOA")]
    [Description(@"Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.")]
    EuroDomestic,
    
    /// <summary>
    /// Transaction has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as "DMST".
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_l1fi0KcCEeSyQqZ4APDtOA")]
    [Description(@"Transaction has an origin and a destination in the same country and is made in the currency of that country.")]
    Domestic,
    
    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as "FRGN".
    /// </summary>
    [EnumMember(Value = "FRGN")]
    [IsoId("_nbNsAJhxEeumhIk_Pv20Lg")]
    [Description(@"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    Foreign,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeMarketCodeMetadataExtensions
{
    private static readonly TradeMarketCodeDropdownSource _dropdownSource = new TradeMarketCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeMarketCodeDropdownRow GetMetadata(this TradeMarketCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


