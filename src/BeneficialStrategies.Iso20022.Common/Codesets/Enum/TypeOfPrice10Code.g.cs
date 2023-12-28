﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice10Code.  ISO2002 ID# _Yw6aBNp-Ed-ak6NoX_4Aeg_1125062082.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yw6aBNp-Ed-ak6NoX_4Aeg_1125062082")]
[Description(@"Specifies the type of price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice10Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as "Bid".
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_Yw6aBdp-Ed-ak6NoX_4Aeg_1125062318")]
    [Description(@"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.")]
    Bid,
    
    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as "Offer".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_Yw6aBtp-Ed-ak6NoX_4Aeg_1125062342")]
    [Description(@"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.")]
    Offer,
    
    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as "NetAssetValue".
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_YxELANp-Ed-ak6NoX_4Aeg_1125062359")]
    [Description(@"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.")]
    NetAssetValue,
    
    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as "Creation".
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_YxELAdp-Ed-ak6NoX_4Aeg_1125062377")]
    [Description(@"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.")]
    Creation,
    
    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YxELAtp-Ed-ak6NoX_4Aeg_1125062378")]
    [Description(@"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.")]
    Cancellation,
    
    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_YxELA9p-Ed-ak6NoX_4Aeg_1125062402")]
    [Description(@"Price is the non-official interim price given to an investor before the executed price.")]
    Interim,
    
    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as "Swing".
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_YxELBNp-Ed-ak6NoX_4Aeg_1125062419")]
    [Description(@"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.")]
    Swing,
    
    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as "Mid".
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_YxELBdp-Ed-ak6NoX_4Aeg_1125062437")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid,
    
    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as "Reinvestment".
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_YxELBtp-Ed-ak6NoX_4Aeg_1125062454")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment,
    
    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as "Switch".
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_YxELB9p-Ed-ak6NoX_4Aeg_1125062472")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch,
    
    /// <summary>
    /// Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
    /// Encoded/decoded by serializers as "DailyDividendRate".
    /// </summary>
    [EnumMember(Value = "DDVR")]
    [IsoId("_YxELCNp-Ed-ak6NoX_4Aeg_1125062473")]
    [Description(@"Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.")]
    DailyDividendRate,
    
    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as "Actual".
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_YxELCdp-Ed-ak6NoX_4Aeg_1125062745")]
    [Description(@"True offer price.")]
    Actual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice10CodeMetadataExtensions
{
    private static readonly TypeOfPrice10CodeDropdownSource _dropdownSource = new TypeOfPrice10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice10CodeDropdownRow GetMetadata(this TypeOfPrice10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


