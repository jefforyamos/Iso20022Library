﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice12Code.  ISO2002 ID# _Yxg28Np-Ed-ak6NoX_4Aeg_-254159336.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yxg28Np-Ed-ak6NoX_4Aeg_-254159336")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice12Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as "BIDE".
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_Yxg28dp-Ed-ak6NoX_4Aeg_-254158922")]
    [Description(@"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.")]
    Bid = TypeOfPriceCode.Bid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as "OFFR".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_Yxg28tp-Ed-ak6NoX_4Aeg_-253238795")]
    [Description(@"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.")]
    Offer = TypeOfPriceCode.Offer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as "NAVL".
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_Yxg289p-Ed-ak6NoX_4Aeg_-253238735")]
    [Description(@"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.")]
    NetAssetValue = TypeOfPriceCode.NetAssetValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as "CREA".
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_Yxg29Np-Ed-ak6NoX_4Aeg_-253238699")]
    [Description(@"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.")]
    Creation = TypeOfPriceCode.Creation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_Yxg29dp-Ed-ak6NoX_4Aeg_-253238674")]
    [Description(@"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.")]
    Cancellation = TypeOfPriceCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as "INTE".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Yxg29tp-Ed-ak6NoX_4Aeg_-253238673")]
    [Description(@"Price is the non-official interim price given to an investor before the executed price.")]
    Interim = TypeOfPriceCode.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as "SWNG".
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_Yxg299p-Ed-ak6NoX_4Aeg_-253238657")]
    [Description(@"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.")]
    Swing = TypeOfPriceCode.Swing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as "MIDD".
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_Yxg2-Np-Ed-ak6NoX_4Aeg_-253238638")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid = TypeOfPriceCode.Mid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as "RINV".
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_YxqA4Np-Ed-ak6NoX_4Aeg_-253238362")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment = TypeOfPriceCode.Reinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as "SWIC".
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_YxqA4dp-Ed-ak6NoX_4Aeg_-253238207")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch = TypeOfPriceCode.Switch, // same ordinal as derivation source for type conversions
    
}
