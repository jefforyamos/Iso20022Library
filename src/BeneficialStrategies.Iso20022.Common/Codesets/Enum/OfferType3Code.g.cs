﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OfferType3Code.  ISO2002 ID# _is2QYCHiEeOQ7qT4JUI53A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions that apply to the offer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_is2QYCHiEeOQ7qT4JUI53A")]
[Description(@"Specifies the conditions that apply to the offer.")]
[DerivedFrom(typeof(OfferTypeV2Code))]
public enum OfferType3Code
{
    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as "SqueezeOutBid".
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_y1XMESHiEeOQ7qT4JUI53A")]
    [Description(@"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.")]
    SqueezeOutBid,
    
    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as "RestrictionExchange".
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_y-lZgSHiEeOQ7qT4JUI53A")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange,
    
    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as "PartialOffer".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_zEYfgSHiEeOQ7qT4JUI53A")]
    [Description(@"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.")]
    PartialOffer,
    
    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// Encoded/decoded by serializers as "FirstComeFirstServed".
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("_zSqzISHiEeOQ7qT4JUI53A")]
    [Description(@"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.")]
    FirstComeFirstServed,
    
    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as "FinalOffer".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_zZEWESHiEeOQ7qT4JUI53A")]
    [Description(@"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.")]
    FinalOffer,
    
    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as "DissenterRights".
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_zdrJQSHiEeOQ7qT4JUI53A")]
    [Description(@"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.")]
    DissenterRights,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OfferType3CodeMetadataExtensions
{
    private static readonly OfferType3CodeDropdownSource _dropdownSource = new OfferType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOfferType3CodeDropdownRow GetMetadata(this OfferType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


