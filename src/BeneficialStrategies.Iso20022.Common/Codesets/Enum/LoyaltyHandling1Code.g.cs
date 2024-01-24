﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LoyaltyHandling1Code.  ISO2002 ID# _UGjkENt4EeiXqq0XHEoNUA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Possible types of Loyalty processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UGjkENt4EeiXqq0XHEoNUA")]
[Description(@"Possible types of Loyalty processing.")]
[DerivedFrom(typeof(LoyaltyHandlingCode))]
public enum LoyaltyHandling1Code
{
    /// <summary>
    /// The loyalty is accepted, but the POI has not to require or ask a loyalty card. The loyalty is involved by the payment card (e.g. an hybrid or linked card). 
    /// Encoded/decoded by serializers as "ALLO".
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_WKvCUdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is accepted, but the POI has not to require or ask a loyalty card. The loyalty is involved by the payment card (e.g. an hybrid or linked card). ")]
    Allowed = LoyaltyHandlingCode.Allowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No loyalty card to read and loyalty transaction to process. 	Any attempt to enter a pure loyalty card is rejected.
    /// Encoded/decoded by serializers as "DENY".
    /// </summary>
    [EnumMember(Value = "DENY")]
    [IsoId("_WO5Jkdt4EeiXqq0XHEoNUA")]
    [Description(@"No loyalty card to read and loyalty transaction to process. 	Any attempt to enter a pure loyalty card is rejected.")]
    Forbidden = LoyaltyHandlingCode.Forbidden, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The loyalty transaction is already processed, no loyalty card or loyalty transaction to process.
    /// Encoded/decoded by serializers as "PRCS".
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_WS0nUdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty transaction is already processed, no loyalty card or loyalty transaction to process.")]
    Processed = LoyaltyHandlingCode.Processed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The loyalty is accepted, and the POI has to ask a loyalty card. If the Customer does not enter a loyalty card, no loyalty transaction is realised.
    /// Encoded/decoded by serializers as "PROP".
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_WW-Hgdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is accepted, and the POI has to ask a loyalty card. If the Customer does not enter a loyalty card, no loyalty transaction is realised.")]
    Proposed = LoyaltyHandlingCode.Proposed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The loyalty is required, and the POI refuses the processing 	of the message request if the cardholder does not enter a loyalty card.
    /// Encoded/decoded by serializers as "REQU".
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_WbW4Qdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is required, and the POI refuses the processing 	of the message request if the cardholder does not enter a loyalty card.")]
    Required = LoyaltyHandlingCode.Required, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LoyaltyHandling1CodeMetadataExtensions
{
    private static readonly LoyaltyHandling1CodeDropdownSource _dropdownSource = new LoyaltyHandling1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILoyaltyHandling1CodeDropdownRow GetMetadata(this LoyaltyHandling1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


