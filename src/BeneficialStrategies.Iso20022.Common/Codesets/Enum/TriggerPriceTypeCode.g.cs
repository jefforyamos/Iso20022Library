﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TriggerPriceTypeCode.  ISO2002 ID# _YwBCJdp-Ed-ak6NoX_4Aeg_781187809.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price that the trigger is compared to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwBCJdp-Ed-ak6NoX_4Aeg_781187809")]
[Description(@"Specifies the type of price that the trigger is compared to.")]
[Derivations(typeof(TriggerPriceType1Code))]
public enum TriggerPriceTypeCode
{
    /// <summary>
    /// Trigger is compared to best offer.
    /// Encoded/decoded by serializers as "BEOF".
    /// </summary>
    [EnumMember(Value = "BEOF")]
    [IsoId("_YwBCJtp-Ed-ak6NoX_4Aeg_-1305643677")]
    [Description(@"Trigger is compared to best offer.")]
    BestOffer,
    
    /// <summary>
    /// Trigger is compared to last trade.
    /// Encoded/decoded by serializers as "LATR".
    /// </summary>
    [EnumMember(Value = "LATR")]
    [IsoId("_YwKzINp-Ed-ak6NoX_4Aeg_-1291788982")]
    [Description(@"Trigger is compared to last trade.")]
    LastTrade,
    
    /// <summary>
    /// Trigger is compared to best bid.
    /// Encoded/decoded by serializers as "BEBI".
    /// </summary>
    [EnumMember(Value = "BEBI")]
    [IsoId("_YwKzIdp-Ed-ak6NoX_4Aeg_-1262237349")]
    [Description(@"Trigger is compared to best bid.")]
    BestBid,
    
    /// <summary>
    /// Trigger is compared to best bid or last trade.
    /// Encoded/decoded by serializers as "BBLT".
    /// </summary>
    [EnumMember(Value = "BBLT")]
    [IsoId("_YwKzItp-Ed-ak6NoX_4Aeg_-1250231999")]
    [Description(@"Trigger is compared to best bid or last trade.")]
    BestBidOrLastTrade,
    
    /// <summary>
    /// Trigger is compared to best offer or last trade.
    /// Encoded/decoded by serializers as "BOLT".
    /// </summary>
    [EnumMember(Value = "BOLT")]
    [IsoId("_YwKzI9p-Ed-ak6NoX_4Aeg_-1231759300")]
    [Description(@"Trigger is compared to best offer or last trade.")]
    BestOfferOrLastTrade,
    
    /// <summary>
    /// Trigger is compared to best mid.
    /// Encoded/decoded by serializers as "BEMI".
    /// </summary>
    [EnumMember(Value = "BEMI")]
    [IsoId("_YwKzJNp-Ed-ak6NoX_4Aeg_-1203129635")]
    [Description(@"Trigger is compared to best mid.")]
    BestMid,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TriggerPriceTypeCodeMetadataExtensions
{
    private static readonly TriggerPriceTypeCodeDropdownSource _dropdownSource = new TriggerPriceTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITriggerPriceTypeCodeDropdownRow GetMetadata(this TriggerPriceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


