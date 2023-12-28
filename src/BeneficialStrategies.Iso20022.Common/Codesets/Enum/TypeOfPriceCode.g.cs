﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPriceCode.  ISO2002 ID# _YytJwtp-Ed-ak6NoX_4Aeg_850953552.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YytJwtp-Ed-ak6NoX_4Aeg_850953552")]
[Description(@"Specifies the type of price and information about the price.")]
public enum TypeOfPriceCode
{
    /// <summary>
    /// Price is an average execution price.
    /// Encoded/decoded by serializers as "AVER".
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_YytJw9p-Ed-ak6NoX_4Aeg_890525492")]
    [Description(@"Price is an average execution price.")]
    Average,
    
    /// <summary>
    /// Price is an override of the average price.
    /// Encoded/decoded by serializers as "AVOV".
    /// </summary>
    [EnumMember(Value = "AVOV")]
    [IsoId("_YytJxNp-Ed-ak6NoX_4Aeg_906224920")]
    [Description(@"Price is an override of the average price.")]
    AverageOverride,
    
    /// <summary>
    /// Price is composed of the combined expenses (used in the UK market).
    /// Encoded/decoded by serializers as "COMB".
    /// </summary>
    [EnumMember(Value = "COMB")]
    [IsoId("_YytJxdp-Ed-ak6NoX_4Aeg_-1612945199")]
    [Description(@"Price is composed of the combined expenses (used in the UK market).")]
    Combined,
    
    /// <summary>
    /// Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes.
    /// Encoded/decoded by serializers as "GREX".
    /// </summary>
    [EnumMember(Value = "GREX")]
    [IsoId("_YytJxtp-Ed-ak6NoX_4Aeg_-1600013269")]
    [Description(@"Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes.")]
    GrossOfAll,
    
    /// <summary>
    /// Price is the limit price of a limit order, eg, a customer might put in a limit order to sell financial instruments at 67 or to buy at 60.
    /// Encoded/decoded by serializers as "LIMI".
    /// </summary>
    [EnumMember(Value = "LIMI")]
    [IsoId("_Yy2TsNp-Ed-ak6NoX_4Aeg_1767739160")]
    [Description(@"Price is the limit price of a limit order, eg, a customer might put in a limit order to sell financial instruments at 67 or to buy at 60.")]
    Limit,
    
    /// <summary>
    /// Price is a net price, ie, net only of local broker's commission, local fees and local taxes.
    /// Encoded/decoded by serializers as "NET2".
    /// </summary>
    [EnumMember(Value = "NET2")]
    [IsoId("_Yy2Tsdp-Ed-ak6NoX_4Aeg_1165873531")]
    [Description(@"Price is a net price, ie, net only of local broker's commission, local fees and local taxes.")]
    Net,
    
    /// <summary>
    /// Price is net to the disclosed client.
    /// Encoded/decoded by serializers as "NDIS".
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_Yy2Tstp-Ed-ak6NoX_4Aeg_-1568616348")]
    [Description(@"Price is net to the disclosed client.")]
    NetDisclosed,
    
    /// <summary>
    /// Price is a net price, ie, net of all charges, fees and taxes.
    /// Encoded/decoded by serializers as "NET1".
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("_Yy2Ts9p-Ed-ak6NoX_4Aeg_1149253390")]
    [Description(@"Price is a net price, ie, net of all charges, fees and taxes.")]
    NetOfAll,
    
    /// <summary>
    /// Price is net to the client undisclosed (used in the UK market).
    /// Encoded/decoded by serializers as "NUND".
    /// </summary>
    [EnumMember(Value = "NUND")]
    [IsoId("_Yy2TtNp-Ed-ak6NoX_4Aeg_-1299869706")]
    [Description(@"Price is net to the client undisclosed (used in the UK market).")]
    NetUndisclosed,
    
    /// <summary>
    /// Price is notional gross (used in the UK market).
    /// Encoded/decoded by serializers as "NOGR".
    /// </summary>
    [EnumMember(Value = "NOGR")]
    [IsoId("_Yy2Ttdp-Ed-ak6NoX_4Aeg_-1225064554")]
    [Description(@"Price is notional gross (used in the UK market).")]
    NotionalGross,
    
    /// <summary>
    /// Price is equal to the nominal or face value of the instrument.
    /// Encoded/decoded by serializers as "PARV".
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_Yy2Tttp-Ed-ak6NoX_4Aeg_1168645374")]
    [Description(@"Price is equal to the nominal or face value of the instrument.")]
    ParValue,
    
    /// <summary>
    /// Price is a rounded average price.
    /// Encoded/decoded by serializers as "RDAV".
    /// </summary>
    [EnumMember(Value = "RDAV")]
    [IsoId("_Yy2Tt9p-Ed-ak6NoX_4Aeg_908994954")]
    [Description(@"Price is a rounded average price.")]
    RoundedAverage,
    
    /// <summary>
    /// Price is a stop price used in an order to buy. The order becomes a market order when the financial instrument trades at or above the stop price after the order is submitted. In an order to sell the order becomes a market order when the financial instrument trades at or below the stop price.
    /// Encoded/decoded by serializers as "STOP".
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_Yy2TuNp-Ed-ak6NoX_4Aeg_1763120990")]
    [Description(@"Price is a stop price used in an order to buy. The order becomes a market order when the financial instrument trades at or above the stop price after the order is submitted. In an order to sell the order becomes a market order when the financial instrument trades at or below the stop price.")]
    Stop,
    
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as "BIDE".
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_Yy2Tudp-Ed-ak6NoX_4Aeg_-887589986")]
    [Description(@"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.")]
    Bid,
    
    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as "OFFR".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_Yy2Tutp-Ed-ak6NoX_4Aeg_-887589925")]
    [Description(@"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.")]
    Offer,
    
    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as "NAVL".
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_YzAEsNp-Ed-ak6NoX_4Aeg_-887589833")]
    [Description(@"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.")]
    NetAssetValue,
    
    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as "CREA".
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_YzAEsdp-Ed-ak6NoX_4Aeg_-887589524")]
    [Description(@"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.")]
    Creation,
    
    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YzAEstp-Ed-ak6NoX_4Aeg_-887588970")]
    [Description(@"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.")]
    Cancellation,
    
    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as "INTE".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_YzAEs9p-Ed-ak6NoX_4Aeg_-887588909")]
    [Description(@"Price is the non-official interim price given to an investor before the executed price.")]
    Interim,
    
    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as "SWNG".
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_YzAEtNp-Ed-ak6NoX_4Aeg_-850801695")]
    [Description(@"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.")]
    Swing,
    
    /// <summary>
    /// Price is another type of price, which is not explicitly defined.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YzAEtdp-Ed-ak6NoX_4Aeg_-850801694")]
    [Description(@"Price is another type of price, which is not explicitly defined.")]
    Other,
    
    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as "MIDD".
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_YzAEttp-Ed-ak6NoX_4Aeg_-850801693")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid,
    
    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as "RINV".
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_YzAEt9p-Ed-ak6NoX_4Aeg_-850801692")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment,
    
    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as "SWIC".
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_YzAEuNp-Ed-ak6NoX_4Aeg_-850801691")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch,
    
    /// <summary>
    /// Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
    /// Encoded/decoded by serializers as "DDVR".
    /// </summary>
    [EnumMember(Value = "DDVR")]
    [IsoId("_YzAEudp-Ed-ak6NoX_4Aeg_140331494")]
    [Description(@"Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.")]
    DailyDividendRate,
    
    /// <summary>
    /// Price is the current market price.
    /// Encoded/decoded by serializers as "MRKT".
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_YzJ1sNp-Ed-ak6NoX_4Aeg_-784767678")]
    [Description(@"Price is the current market price.")]
    Market,
    
    /// <summary>
    /// Price is the estimated indicative price.
    /// Encoded/decoded by serializers as "INDC".
    /// </summary>
    [EnumMember(Value = "INDC")]
    [IsoId("_YzJ1sdp-Ed-ak6NoX_4Aeg_-784767643")]
    [Description(@"Price is the estimated indicative price.")]
    Indicative,
    
    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as "ACTU".
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_YzJ1stp-Ed-ak6NoX_4Aeg_1165998528")]
    [Description(@"True offer price.")]
    Actual,
    
    /// <summary>
    /// The original NAV before the price of the investment fund was swung.
    /// Encoded/decoded by serializers as "NAUP".
    /// </summary>
    [EnumMember(Value = "NAUP")]
    [IsoId("_YzJ1s9p-Ed-ak6NoX_4Aeg_1165998950")]
    [Description(@"The original NAV before the price of the investment fund was swung.")]
    NonAdjustedUnpublished,
    
    /// <summary>
    /// Price is a guaranteed price.
    /// Encoded/decoded by serializers as "GUAR".
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_YzJ1tNp-Ed-ak6NoX_4Aeg_-108514267")]
    [Description(@"Price is a guaranteed price.")]
    Guaranteed,
    
    /// <summary>
    /// Price is an estimated net asset value per unit.
    /// Encoded/decoded by serializers as "ENAV".
    /// </summary>
    [EnumMember(Value = "ENAV")]
    [IsoId("_YzJ1tdp-Ed-ak6NoX_4Aeg_-108514034")]
    [Description(@"Price is an estimated net asset value per unit.")]
    EstimatedNAV,
    
    /// <summary>
    /// Price is the gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.
    /// Encoded/decoded by serializers as "GAVL".
    /// </summary>
    [EnumMember(Value = "GAVL")]
    [IsoId("_YzJ1ttp-Ed-ak6NoX_4Aeg_941454158")]
    [Description(@"Price is the gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.")]
    GrossAssetValue,
    
    /// <summary>
    /// Price is the estimated gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.
    /// Encoded/decoded by serializers as "EGAV".
    /// </summary>
    [EnumMember(Value = "EGAV")]
    [IsoId("_YzJ1t9p-Ed-ak6NoX_4Aeg_941455545")]
    [Description(@"Price is the estimated gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.")]
    EstimatedGAV,
    
    /// <summary>
    /// Price is the estimated net asset value for the side pocket.
    /// Encoded/decoded by serializers as "NAVS".
    /// </summary>
    [EnumMember(Value = "NAVS")]
    [IsoId("_YzJ1uNp-Ed-ak6NoX_4Aeg_941456889")]
    [Description(@"Price is the estimated net asset value for the side pocket.")]
    SidePocketNAV,
    
    /// <summary>
    /// Offer. Price for which seller is willing to sell item.
    /// Encoded/decoded by serializers as "ASKK".
    /// </summary>
    [EnumMember(Value = "ASKK")]
    [IsoId("_YzJ1udp-Ed-ak6NoX_4Aeg_-605595275")]
    [Description(@"Offer. Price for which seller is willing to sell item.")]
    Ask,
    
    /// <summary>
    /// Price selected as a crossing of an auction.
    /// Encoded/decoded by serializers as "AUCT".
    /// </summary>
    [EnumMember(Value = "AUCT")]
    [IsoId("_YzJ1utp-Ed-ak6NoX_4Aeg_-605594813")]
    [Description(@"Price selected as a crossing of an auction.")]
    Auction,
    
    /// <summary>
    /// Price is calculated.
    /// Encoded/decoded by serializers as "CALC".
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_YzS_oNp-Ed-ak6NoX_4Aeg_-605594412")]
    [Description(@"Price is calculated.")]
    Calculated,
    
    /// <summary>
    /// Paid without accumulated interest.
    /// Encoded/decoded by serializers as "CLEN".
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_YzS_odp-Ed-ak6NoX_4Aeg_-605594259")]
    [Description(@"Paid without accumulated interest.")]
    Clean,
    
    /// <summary>
    /// Paid with accumulated interest.
    /// Encoded/decoded by serializers as "DIRT".
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_YzS_otp-Ed-ak6NoX_4Aeg_-605593897")]
    [Description(@"Paid with accumulated interest.")]
    Dirty,
    
    /// <summary>
    /// Price selected as a result of a lottery/tiebreaker.
    /// Encoded/decoded by serializers as "DRAW".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_YzS_o9p-Ed-ak6NoX_4Aeg_-604673772")]
    [Description(@"Price selected as a result of a lottery/tiebreaker.")]
    Draw,
    
    /// <summary>
    /// Estimate of the potential market price.
    /// Encoded/decoded by serializers as "FAVA".
    /// </summary>
    [EnumMember(Value = "FAVA")]
    [IsoId("_YzS_pNp-Ed-ak6NoX_4Aeg_-604673619")]
    [Description(@"Estimate of the potential market price.")]
    FairValue,
    
    /// <summary>
    /// Reduced and partial execution based on high bids and ask orders.
    /// Encoded/decoded by serializers as "INPA".
    /// </summary>
    [EnumMember(Value = "INPA")]
    [IsoId("_YzS_pdp-Ed-ak6NoX_4Aeg_-604673249")]
    [Description(@"Reduced and partial execution based on high bids and ask orders.")]
    IndicativePaid,
    
    /// <summary>
    /// Official declared price.
    /// Encoded/decoded by serializers as "KASA".
    /// </summary>
    [EnumMember(Value = "KASA")]
    [IsoId("_YzS_ptp-Ed-ak6NoX_4Aeg_-604672794")]
    [Description(@"Official declared price.")]
    Kassa,
    
    /// <summary>
    /// Price at which the trade was done.
    /// Encoded/decoded by serializers as "PAID".
    /// </summary>
    [EnumMember(Value = "PAID")]
    [IsoId("_YzS_p9p-Ed-ak6NoX_4Aeg_-604672641")]
    [Description(@"Price at which the trade was done.")]
    Paid,
    
    /// <summary>
    /// Net Asset Value (NAV) applicable to redemptions.
    /// Encoded/decoded by serializers as "REDN".
    /// </summary>
    [EnumMember(Value = "REDN")]
    [IsoId("_YzS_qNp-Ed-ak6NoX_4Aeg_-604672271")]
    [Description(@"Net Asset Value (NAV) applicable to redemptions.")]
    RedemptionNAV,
    
    /// <summary>
    /// Price used for the settlement of futures and options.
    /// Encoded/decoded by serializers as "SETM".
    /// </summary>
    [EnumMember(Value = "SETM")]
    [IsoId("_YzS_qdp-Ed-ak6NoX_4Aeg_-604671846")]
    [Description(@"Price used for the settlement of futures and options.")]
    Settlement,
    
    /// <summary>
    /// The difference between bid and ask.
    /// Encoded/decoded by serializers as "SPRE".
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_YzcwoNp-Ed-ak6NoX_4Aeg_-604671693")]
    [Description(@"The difference between bid and ask.")]
    Spread,
    
    /// <summary>
    /// Net Asset Value (NAV) applicable to subscriptions.
    /// Encoded/decoded by serializers as "SUBN".
    /// </summary>
    [EnumMember(Value = "SUBN")]
    [IsoId("_Yzcwodp-Ed-ak6NoX_4Aeg_-604671292")]
    [Description(@"Net Asset Value (NAV) applicable to subscriptions.")]
    SubscriptionNAV,
    
    /// <summary>
    /// Price for tax declaration purpose.
    /// Encoded/decoded by serializers as "TAXE".
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_Yzcwotp-Ed-ak6NoX_4Aeg_-604670769")]
    [Description(@"Price for tax declaration purpose.")]
    Tax,
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// Encoded/decoded by serializers as "TISC".
    /// </summary>
    [EnumMember(Value = "TISC")]
    [IsoId("_Yzcwo9p-Ed-ak6NoX_4Aeg_-604670376")]
    [Description(@"Specifies whether the fund calculates a taxable interest per share (TIS).")]
    TaxableIncomePerShareCalculated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPriceCodeMetadataExtensions
{
    private static readonly TypeOfPriceCodeDropdownSource _dropdownSource = new TypeOfPriceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPriceCodeDropdownRow GetMetadata(this TypeOfPriceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

