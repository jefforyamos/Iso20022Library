﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType18Code.  ISO2002 ID# _ewumAEqLEeenp6hmNprBHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of role assigned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ewumAEqLEeenp6hmNprBHg")]
[Description(@"Type of role assigned.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType18Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_kWWKsUqLEeenp6hmNprBHg")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer,
    
    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as "CardIssuer".
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_lyQIAUqLEeenp6hmNprBHg")]
    [Description(@"Party that issues cards.")]
    CardIssuer,
    
    /// <summary>
    /// Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as "CardScheme".
    /// </summary>
    [EnumMember(Value = "CSCH")]
    [IsoId("_l_O0EUqLEeenp6hmNprBHg")]
    [Description(@"Entity defining rules and procedures for card payment transactions acting as an intermediary between an acquirer and an issuer.")]
    CardScheme,
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as "Agent".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_pSO14UqLEeenp6hmNprBHg")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.")]
    Agent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType18CodeMetadataExtensions
{
    private static readonly PartyType18CodeDropdownSource _dropdownSource = new PartyType18CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType18CodeDropdownRow GetMetadata(this PartyType18Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


