﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType9Code.  ISO2002 ID# _2fUvkHrTEeSfJf8ETXpBxg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2fUvkHrTEeSfJf8ETXpBxg")]
[Description(@"Type of entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType9Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-H_xIXrTEeSfJf8ETXpBxg")]
    [Description(@"??")]
    Acquirer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcquirerProcessor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-SnFsXrTEeSfJf8ETXpBxg")]
    [Description(@"??")]
    AcquirerProcessor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-mj8cXrTEeSfJf8ETXpBxg")]
    [Description(@"??")]
    CardIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardIssuerProcessor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-v1NMXrTEeSfJf8ETXpBxg")]
    [Description(@"??")]
    CardIssuerProcessor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardScheme".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-5uJAXrTEeSfJf8ETXpBxg")]
    [Description(@"??")]
    CardScheme,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardSchemeProcessor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AAaEQXrUEeSfJf8ETXpBxg")]
    [Description(@"??")]
    CardSchemeProcessor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType9CodeMetadataExtensions
{
    private static readonly PartyType9CodeDropdownSource _dropdownSource = new PartyType9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType9CodeDropdownRow GetMetadata(this PartyType9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


