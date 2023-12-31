﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice6Code.  ISO2002 ID# _YyQd0dp-Ed-ak6NoX_4Aeg_1990390335.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YyQd0dp-Ed-ak6NoX_4Aeg_1990390335")]
[Description(@"Specifies the type of price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice6Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as "Bid".
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_YyQd0tp-Ed-ak6NoX_4Aeg_-1999816017")]
    [Description(@"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.")]
    Bid,
    
    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as "Offer".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_YyQd09p-Ed-ak6NoX_4Aeg_-1999816016")]
    [Description(@"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.")]
    Offer,
    
    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as "NetAssetValue".
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_YyQd1Np-Ed-ak6NoX_4Aeg_-1999815992")]
    [Description(@"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.")]
    NetAssetValue,
    
    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as "Creation".
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_YyQd1dp-Ed-ak6NoX_4Aeg_-1999815975")]
    [Description(@"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.")]
    Creation,
    
    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YyQd1tp-Ed-ak6NoX_4Aeg_-1999815957")]
    [Description(@"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.")]
    Cancellation,
    
    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_YyQd19p-Ed-ak6NoX_4Aeg_-1999815956")]
    [Description(@"Price is the non-official interim price given to an investor before the executed price.")]
    Interim,
    
    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as "Swing".
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_YyQd2Np-Ed-ak6NoX_4Aeg_-1999815940")]
    [Description(@"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.")]
    Swing,
    
    /// <summary>
    /// Price is another type of price, which is not explicitly defined.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YyQd2dp-Ed-ak6NoX_4Aeg_-1999815802")]
    [Description(@"Price is another type of price, which is not explicitly defined.")]
    Other,
    
    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as "Mid".
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_YyZnwNp-Ed-ak6NoX_4Aeg_-1999815801")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid,
    
    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as "Reinvestment".
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_YyZnwdp-Ed-ak6NoX_4Aeg_-1999815785")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment,
    
    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as "Switch".
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_YyZnwtp-Ed-ak6NoX_4Aeg_-1999815525")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch,
    
    /// <summary>
    /// Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
    /// Encoded/decoded by serializers as "DailyDividendRate".
    /// </summary>
    [EnumMember(Value = "DDVR")]
    [IsoId("_YyZnw9p-Ed-ak6NoX_4Aeg_-1999815508")]
    [Description(@"Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.")]
    DailyDividendRate,
    
    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as "Actual".
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_YyZnxNp-Ed-ak6NoX_4Aeg_-1949944923")]
    [Description(@"True offer price.")]
    Actual,
    
    /// <summary>
    /// The original NAV before the price of the investment fund was swung.
    /// Encoded/decoded by serializers as "NonAdjustedUnpublished".
    /// </summary>
    [EnumMember(Value = "NAUP")]
    [IsoId("_YyZnxdp-Ed-ak6NoX_4Aeg_-1914849915")]
    [Description(@"The original NAV before the price of the investment fund was swung.")]
    NonAdjustedUnpublished,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice6CodeMetadataExtensions
{
    private static readonly TypeOfPrice6CodeDropdownSource _dropdownSource = new TypeOfPrice6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice6CodeDropdownRow GetMetadata(this TypeOfPrice6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


