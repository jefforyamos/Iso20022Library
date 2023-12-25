﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OfferTypeV2Code.  ISO2002 ID# _OzTbUS84EeKNZpaVtgp8Wg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions that apply to the offer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OzTbUS84EeKNZpaVtgp8Wg")]
[Description(@"Specifies the conditions that apply to the offer.")]
public enum OfferTypeV2Code
{
    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_PKP7tS84EeKNZpaVtgp8Wg")]
    [Description(@"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.")]
    DISS,
    
    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_PKP7uS84EeKNZpaVtgp8Wg")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    ERUN,
    
    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("_PKP7vS84EeKNZpaVtgp8Wg")]
    [Description(@"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.")]
    FCFS,
    
    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_PKP7wS84EeKNZpaVtgp8Wg")]
    [Description(@"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.")]
    FINL,
    
    /// <summary>
    /// Sale or purchase of odd lots to/from a third party other than the issuing company.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_PKP7xS84EeKNZpaVtgp8Wg")]
    [Description(@"Sale or purchase of odd lots to/from a third party other than the issuing company.")]
    MINI,
    
    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_PKP7yS84EeKNZpaVtgp8Wg")]
    [Description(@"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.")]
    PART,
    
    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_PKP7zS84EeKNZpaVtgp8Wg")]
    [Description(@"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.")]
    SQUE,
    
    /// <summary>
    /// Dissenter’s rights are not applicable for this option of the offer.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_8_NnEBe0EeyroI8qKgB7Mg")]
    [Description(@"Dissenter’s rights are not applicable for this option of the offer.")]
    NDIS,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OfferTypeV2CodeMetadataExtensions
{
    private static readonly OfferTypeV2CodeDropdownSource _dropdownSource = new OfferTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOfferTypeV2CodeDropdownRow GetMetadata(this OfferTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


