﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType10Code.  ISO2002 ID# _be1R0HrgEeSlsoBd7x4P6A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of identified entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_be1R0HrgEeSlsoBd7x4P6A")]
[Description(@"Type of identified entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType10Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acceptor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dnNTkXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    Acceptor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dtndkXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    Acquirer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ATMManager".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_e5urYXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    ATMManager,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ftit8XrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    CardIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegateIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_f-YmUXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    DelegateIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HostingEntity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hm2Y8XrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    HostingEntity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntermediaryAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_h05cAXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    IntermediaryAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Merchant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_i5CZkXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    Merchant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OriginatingATM".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jRkOUXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    OriginatingATM,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OriginatingPOI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jYxCgXrgEeSlsoBd7x4P6A")]
    [Description(@"??")]
    OriginatingPOI,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType10CodeMetadataExtensions
{
    private static readonly PartyType10CodeDropdownSource _dropdownSource = new PartyType10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType10CodeDropdownRow GetMetadata(this PartyType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


