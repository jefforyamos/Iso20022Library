﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType32Code.  ISO2002 ID# _jjdWAENhEeiut6dbx3wnBg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jjdWAENhEeiut6dbx3wnBg")]
[Description(@"Type of party.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType32Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_6Pgn8X0lEemfrNOe0zHQyg")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer,
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as "Agent".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_6Pgn830lEemfrNOe0zHQyg")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.")]
    Agent,
    
    /// <summary>
    /// Issuer is the entitled party.
    /// Encoded/decoded by serializers as "Issuer".
    /// </summary>
    [EnumMember(Value = "ISUR")]
    [IsoId("_6Pgn9X0lEemfrNOe0zHQyg")]
    [Description(@"Issuer is the entitled party.")]
    Issuer,
    
    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6Pgn930lEemfrNOe0zHQyg")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6Pgn-X0lEemfrNOe0zHQyg")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType32CodeMetadataExtensions
{
    private static readonly PartyType32CodeDropdownSource _dropdownSource = new PartyType32CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType32CodeDropdownRow GetMetadata(this PartyType32Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


