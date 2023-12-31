﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice1Code.  ISO2002 ID# _Yx9i5dp-Ed-ak6NoX_4Aeg_-1302250885.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yx9i5dp-Ed-ak6NoX_4Aeg_-1302250885")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice1Code
{
    /// <summary>
    /// Price is an average execution price.
    /// Encoded/decoded by serializers as "Average".
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_Yx9i5tp-Ed-ak6NoX_4Aeg_-960547282")]
    [Description(@"Price is an average execution price.")]
    Average,
    
    /// <summary>
    /// Price is an override of the average price.
    /// Encoded/decoded by serializers as "AverageOverride".
    /// </summary>
    [EnumMember(Value = "AVOV")]
    [IsoId("_Yx9i59p-Ed-ak6NoX_4Aeg_-960547190")]
    [Description(@"Price is an override of the average price.")]
    AverageOverride,
    
    /// <summary>
    /// Price is composed of the combined expenses (used in the UK market).
    /// Encoded/decoded by serializers as "Combined".
    /// </summary>
    [EnumMember(Value = "COMB")]
    [IsoId("_Yx9i6Np-Ed-ak6NoX_4Aeg_-960547129")]
    [Description(@"Price is composed of the combined expenses (used in the UK market).")]
    Combined,
    
    /// <summary>
    /// Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes.
    /// Encoded/decoded by serializers as "GrossOfAll".
    /// </summary>
    [EnumMember(Value = "GREX")]
    [IsoId("_YyGs0Np-Ed-ak6NoX_4Aeg_-960547015")]
    [Description(@"Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes.")]
    GrossOfAll,
    
    /// <summary>
    /// Price is the limit price of a limit order, eg, a customer might put in a limit order to sell financial instruments at 67 or to buy at 60.
    /// Encoded/decoded by serializers as "Limit".
    /// </summary>
    [EnumMember(Value = "LIMI")]
    [IsoId("_YyGs0dp-Ed-ak6NoX_4Aeg_-960546706")]
    [Description(@"Price is the limit price of a limit order, eg, a customer might put in a limit order to sell financial instruments at 67 or to buy at 60.")]
    Limit,
    
    /// <summary>
    /// Price is a net price, ie, net only of local broker's commission, local fees and local taxes.
    /// Encoded/decoded by serializers as "Net".
    /// </summary>
    [EnumMember(Value = "NET2")]
    [IsoId("_YyGs0tp-Ed-ak6NoX_4Aeg_-960546614")]
    [Description(@"Price is a net price, ie, net only of local broker's commission, local fees and local taxes.")]
    Net,
    
    /// <summary>
    /// Price is net to the disclosed client.
    /// Encoded/decoded by serializers as "NetDisclosed".
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_YyGs09p-Ed-ak6NoX_4Aeg_-960546274")]
    [Description(@"Price is net to the disclosed client.")]
    NetDisclosed,
    
    /// <summary>
    /// Price is a net price, ie, net of all charges, fees and taxes.
    /// Encoded/decoded by serializers as "NetOfAll".
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("_YyGs1Np-Ed-ak6NoX_4Aeg_-960546182")]
    [Description(@"Price is a net price, ie, net of all charges, fees and taxes.")]
    NetOfAll,
    
    /// <summary>
    /// Price is net to the client undisclosed (used in the UK market).
    /// Encoded/decoded by serializers as "NetUndisclosed".
    /// </summary>
    [EnumMember(Value = "NUND")]
    [IsoId("_YyGs1dp-Ed-ak6NoX_4Aeg_-960546090")]
    [Description(@"Price is net to the client undisclosed (used in the UK market).")]
    NetUndisclosed,
    
    /// <summary>
    /// Price is notional gross (used in the UK market).
    /// Encoded/decoded by serializers as "NotionalGross".
    /// </summary>
    [EnumMember(Value = "NOGR")]
    [IsoId("_YyGs1tp-Ed-ak6NoX_4Aeg_-960545758")]
    [Description(@"Price is notional gross (used in the UK market).")]
    NotionalGross,
    
    /// <summary>
    /// Price is equal to the nominal or face value of the instrument.
    /// Encoded/decoded by serializers as "ParValue".
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_YyGs19p-Ed-ak6NoX_4Aeg_-959625664")]
    [Description(@"Price is equal to the nominal or face value of the instrument.")]
    ParValue,
    
    /// <summary>
    /// Price is a rounded average price.
    /// Encoded/decoded by serializers as "RoundedAverage".
    /// </summary>
    [EnumMember(Value = "RDAV")]
    [IsoId("_YyGs2Np-Ed-ak6NoX_4Aeg_-959625572")]
    [Description(@"Price is a rounded average price.")]
    RoundedAverage,
    
    /// <summary>
    /// Price is a stop price used in an order to buy. The order becomes a market order when the financial instrument trades at or above the stop price after the order is submitted. In an order to sell the order becomes a market order when the financial instrument trades at or below the stop price.
    /// Encoded/decoded by serializers as "Stop".
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_YyQd0Np-Ed-ak6NoX_4Aeg_-959625450")]
    [Description(@"Price is a stop price used in an order to buy. The order becomes a market order when the financial instrument trades at or above the stop price after the order is submitted. In an order to sell the order becomes a market order when the financial instrument trades at or below the stop price.")]
    Stop,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice1CodeMetadataExtensions
{
    private static readonly TypeOfPrice1CodeDropdownSource _dropdownSource = new TypeOfPrice1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice1CodeDropdownRow GetMetadata(this TypeOfPrice1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


