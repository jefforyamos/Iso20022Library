﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeMarket1Code.  ISO2002 ID# _2jl30KcCEeSyQqZ4APDtOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a code for a trade market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2jl30KcCEeSyQqZ4APDtOA")]
[Description(@"Specifies a code for a trade market.")]
[DerivedFrom(typeof(TradeMarketCode))]
public enum TradeMarket1Code
{
    /// <summary>
    /// Transaction has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as "Domestic".
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_6oIEQKcCEeSyQqZ4APDtOA")]
    [Description(@"Transaction has an origin and a destination in the same country and is made in the currency of that country.")]
    Domestic,
    
    /// <summary>
    /// Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as "EuroDomestic".
    /// </summary>
    [EnumMember(Value = "EUDM")]
    [IsoId("_6uJzw6cCEeSyQqZ4APDtOA")]
    [Description(@"Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.")]
    EuroDomestic,
    
    /// <summary>
    /// Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).
    /// Encoded/decoded by serializers as "FrenchDomTom".
    /// </summary>
    [EnumMember(Value = "FRDT")]
    [IsoId("_6zg046cCEeSyQqZ4APDtOA")]
    [Description(@"Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).")]
    FrenchDomTom,
    
    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as "International".
    /// </summary>
    [EnumMember(Value = "INTL")]
    [IsoId("_6432A6cCEeSyQqZ4APDtOA")]
    [Description(@"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    International,
    
    /// <summary>
    /// Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.
    /// Encoded/decoded by serializers as "NAFTA".
    /// </summary>
    [EnumMember(Value = "NFTA")]
    [IsoId("_6-hyE6cCEeSyQqZ4APDtOA")]
    [Description(@"Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.")]
    NAFTA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeMarket1CodeMetadataExtensions
{
    private static readonly TradeMarket1CodeDropdownSource _dropdownSource = new TradeMarket1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeMarket1CodeDropdownRow GetMetadata(this TradeMarket1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


