﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BasisPriceType1Code.  ISO2002 ID# _bdBa-dp-Ed-ak6NoX_4Aeg_1633141222.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Basis price type in a bid order. Used for list trading.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bdBa-dp-Ed-ak6NoX_4Aeg_1633141222")]
[Description(@"Basis price type in a bid order. Used for list trading.")]
[DerivedFrom(typeof(BasisPriceTypeCode))]
public enum BasisPriceType1Code
{
    /// <summary>
    /// Closing price at morning session.
    /// Encoded/decoded by serializers as "MSCP".
    /// </summary>
    [EnumMember(Value = "MSCP")]
    [IsoId("_bdLL8Np-Ed-ak6NoX_4Aeg_1888032571")]
    [Description(@"Closing price at morning session.")]
    MorningSessionClosePrice = BasisPriceTypeCode.MorningSessionClosePrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Closing price.
    /// Encoded/decoded by serializers as "CLOS".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_bdLL8dp-Ed-ak6NoX_4Aeg_1888032985")]
    [Description(@"Closing price.")]
    ClosingPrice = BasisPriceTypeCode.ClosingPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Current price.
    /// Encoded/decoded by serializers as "CURR".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bdLL8tp-Ed-ak6NoX_4Aeg_1888953052")]
    [Description(@"Current price.")]
    CurrentPrice = BasisPriceTypeCode.CurrentPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price computed after a trading halt.
    /// Encoded/decoded by serializers as "SPQO".
    /// </summary>
    [EnumMember(Value = "SPQO")]
    [IsoId("_bdLL89p-Ed-ak6NoX_4Aeg_1888953112")]
    [Description(@"Price computed after a trading halt.")]
    SpecialQuotation = BasisPriceTypeCode.SpecialQuotation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value weighted average price through the day.
    /// Encoded/decoded by serializers as "VWPD".
    /// </summary>
    [EnumMember(Value = "VWPD")]
    [IsoId("_bdLL9Np-Ed-ak6NoX_4Aeg_1888953147")]
    [Description(@"Value weighted average price through the day.")]
    VWAPDay = BasisPriceTypeCode.VWAPDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value weighted average price through a morning session.
    /// Encoded/decoded by serializers as "VWPM".
    /// </summary>
    [EnumMember(Value = "VWPM")]
    [IsoId("_bdLL9dp-Ed-ak6NoX_4Aeg_1888953189")]
    [Description(@"Value weighted average price through a morning session.")]
    VWAPMorning = BasisPriceTypeCode.VWAPMorning, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value weighted average price through an afternoon session.
    /// Encoded/decoded by serializers as "VWPA".
    /// </summary>
    [EnumMember(Value = "VWPA")]
    [IsoId("_bdLL9tp-Ed-ak6NoX_4Aeg_1888953284")]
    [Description(@"Value weighted average price through an afternoon session.")]
    VWAPAfternoon = BasisPriceTypeCode.VWAPAfternoon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exercise price defined on a derivative product.
    /// Encoded/decoded by serializers as "STIK".
    /// </summary>
    [EnumMember(Value = "STIK")]
    [IsoId("_bdLL99p-Ed-ak6NoX_4Aeg_1888953561")]
    [Description(@"Exercise price defined on a derivative product.")]
    StrikePrice = BasisPriceTypeCode.StrikePrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price of a trade opening session.
    /// Encoded/decoded by serializers as "OPEN".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_bdLL-Np-Ed-ak6NoX_4Aeg_1888953640")]
    [Description(@"Price of a trade opening session.")]
    OpenPrice = BasisPriceTypeCode.OpenPrice, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BasisPriceType1CodeMetadataExtensions
{
    private static readonly BasisPriceType1CodeDropdownSource _dropdownSource = new BasisPriceType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBasisPriceType1CodeDropdownRow GetMetadata(this BasisPriceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


