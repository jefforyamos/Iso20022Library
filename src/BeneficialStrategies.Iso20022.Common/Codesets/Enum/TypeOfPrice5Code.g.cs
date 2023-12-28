﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice5Code.  ISO2002 ID# _Vep_Ftp-Ed-ak6NoX_4Aeg_-979325573.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vep_Ftp-Ed-ak6NoX_4Aeg_-979325573")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice5Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as "Bid".
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_Vep_F9p-Ed-ak6NoX_4Aeg_-580364550")]
    [Description(@"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.")]
    Bid,
    
    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as "Offer".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_Vep_GNp-Ed-ak6NoX_4Aeg_-579443476")]
    [Description(@"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.")]
    Offer,
    
    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as "NetAssetValue".
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_VezwENp-Ed-ak6NoX_4Aeg_-579443416")]
    [Description(@"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.")]
    NetAssetValue,
    
    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as "Creation".
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_VezwEdp-Ed-ak6NoX_4Aeg_-579443304")]
    [Description(@"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.")]
    Creation,
    
    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_VezwEtp-Ed-ak6NoX_4Aeg_-579442932")]
    [Description(@"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.")]
    Cancellation,
    
    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_VezwE9p-Ed-ak6NoX_4Aeg_-579442871")]
    [Description(@"Price is the non-official interim price given to an investor before the executed price.")]
    Interim,
    
    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as "Swing".
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_VezwFNp-Ed-ak6NoX_4Aeg_-579442793")]
    [Description(@"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.")]
    Swing,
    
    /// <summary>
    /// Price is another type of price, which is not explicitly defined.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VezwFdp-Ed-ak6NoX_4Aeg_-579442485")]
    [Description(@"Price is another type of price, which is not explicitly defined.")]
    Other,
    
    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as "Mid".
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_VezwFtp-Ed-ak6NoX_4Aeg_-579442218")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid,
    
    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as "Reinvestment".
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_VezwF9p-Ed-ak6NoX_4Aeg_-579441941")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment,
    
    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as "Switch".
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_VezwGNp-Ed-ak6NoX_4Aeg_-579441828")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch,
    
    /// <summary>
    /// Price is the current market price.
    /// Encoded/decoded by serializers as "Market".
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_VezwGdp-Ed-ak6NoX_4Aeg_-576670885")]
    [Description(@"Price is the current market price.")]
    Market,
    
    /// <summary>
    /// Price is the estimated indicative price.
    /// Encoded/decoded by serializers as "Indicative".
    /// </summary>
    [EnumMember(Value = "INDC")]
    [IsoId("_VezwGtp-Ed-ak6NoX_4Aeg_-564664012")]
    [Description(@"Price is the estimated indicative price.")]
    Indicative,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice5CodeMetadataExtensions
{
    private static readonly TypeOfPrice5CodeDropdownSource _dropdownSource = new TypeOfPrice5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice5CodeDropdownRow GetMetadata(this TypeOfPrice5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


