﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TriggerPriceType1Code.  ISO2002 ID# _Yv34Ntp-Ed-ak6NoX_4Aeg_-1635338287.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price that the trigger is compared to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yv34Ntp-Ed-ak6NoX_4Aeg_-1635338287")]
[Description(@"Specifies the type of price that the trigger is compared to.")]
[DerivedFrom(typeof(TriggerPriceTypeCode))]
public enum TriggerPriceType1Code
{
    /// <summary>
    /// Trigger is compared to best offer.
    /// Encoded/decoded by serializers as "BestOffer".
    /// </summary>
    [EnumMember(Value = "BEOF")]
    [IsoId("_Yv34N9p-Ed-ak6NoX_4Aeg_-319323277")]
    [Description(@"Trigger is compared to best offer.")]
    BestOffer,
    
    /// <summary>
    /// Trigger is compared to last trade.
    /// Encoded/decoded by serializers as "LastTrade".
    /// </summary>
    [EnumMember(Value = "LATR")]
    [IsoId("_YwBCINp-Ed-ak6NoX_4Aeg_-319323259")]
    [Description(@"Trigger is compared to last trade.")]
    LastTrade,
    
    /// <summary>
    /// Trigger is compared to best bid.
    /// Encoded/decoded by serializers as "BestBid".
    /// </summary>
    [EnumMember(Value = "BEBI")]
    [IsoId("_YwBCIdp-Ed-ak6NoX_4Aeg_-319323258")]
    [Description(@"Trigger is compared to best bid.")]
    BestBid,
    
    /// <summary>
    /// Trigger is compared to best bid or last trade.
    /// Encoded/decoded by serializers as "BestBidOrLastTrade".
    /// </summary>
    [EnumMember(Value = "BBLT")]
    [IsoId("_YwBCItp-Ed-ak6NoX_4Aeg_-319323234")]
    [Description(@"Trigger is compared to best bid or last trade.")]
    BestBidOrLastTrade,
    
    /// <summary>
    /// Trigger is compared to best offer or last trade.
    /// Encoded/decoded by serializers as "BestOfferOrLastTrade".
    /// </summary>
    [EnumMember(Value = "BOLT")]
    [IsoId("_YwBCI9p-Ed-ak6NoX_4Aeg_-319323217")]
    [Description(@"Trigger is compared to best offer or last trade.")]
    BestOfferOrLastTrade,
    
    /// <summary>
    /// Trigger is compared to best mid.
    /// Encoded/decoded by serializers as "BestMid".
    /// </summary>
    [EnumMember(Value = "BEMI")]
    [IsoId("_YwBCJNp-Ed-ak6NoX_4Aeg_-319323199")]
    [Description(@"Trigger is compared to best mid.")]
    BestMid,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TriggerPriceType1CodeMetadataExtensions
{
    private static readonly TriggerPriceType1CodeDropdownSource _dropdownSource = new TriggerPriceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITriggerPriceType1CodeDropdownRow GetMetadata(this TriggerPriceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


