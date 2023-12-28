﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OfferType2Code.  ISO2002 ID# _sHEQUC84EeKNZpaVtgp8Wg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions that apply to the offer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sHEQUC84EeKNZpaVtgp8Wg")]
[Description(@"Specifies the conditions that apply to the offer.")]
[DerivedFrom(typeof(OfferTypeV2Code))]
public enum OfferType2Code
{
    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as "DissenterRights".
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_y2wbcS84EeKNZpaVtgp8Wg")]
    [Description(@"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.")]
    DissenterRights,
    
    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as "FinalOffer".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_zAvd4S84EeKNZpaVtgp8Wg")]
    [Description(@"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.")]
    FinalOffer,
    
    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// Encoded/decoded by serializers as "FirstComeFirstServed".
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("_zKR0YS84EeKNZpaVtgp8Wg")]
    [Description(@"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.")]
    FirstComeFirstServed,
    
    /// <summary>
    /// Sale or purchase of odd lots to/from a third party other than the issuing company.
    /// Encoded/decoded by serializers as "MiniOddLotOffer".
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_zNaA4S84EeKNZpaVtgp8Wg")]
    [Description(@"Sale or purchase of odd lots to/from a third party other than the issuing company.")]
    MiniOddLotOffer,
    
    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as "PartialOffer".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_zWzNcS84EeKNZpaVtgp8Wg")]
    [Description(@"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.")]
    PartialOffer,
    
    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as "RestrictionExchange".
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_zZxo8S84EeKNZpaVtgp8Wg")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange,
    
    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as "SqueezeOutBid".
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_zjT_cS84EeKNZpaVtgp8Wg")]
    [Description(@"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.")]
    SqueezeOutBid,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OfferType2CodeMetadataExtensions
{
    private static readonly OfferType2CodeDropdownSource _dropdownSource = new OfferType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOfferType2CodeDropdownRow GetMetadata(this OfferType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


