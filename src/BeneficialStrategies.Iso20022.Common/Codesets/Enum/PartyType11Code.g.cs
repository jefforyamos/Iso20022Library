﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType11Code.  ISO2002 ID# _3WUpkHtCEeSTS7uHCe8FPQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3WUpkHtCEeSTS7uHCe8FPQ")]
[Description(@"Type of entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType11Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acceptor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-QbU8XtCEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    Acceptor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-ZApM3tCEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    Acquirer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__OPoE3tCEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    CardIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegateIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__deW43tCEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    DelegateIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntermediaryAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AgFDY3tDEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    IntermediaryAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OriginatingTerminal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BBjYw3tDEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    OriginatingTerminal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardApplication".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_X79fgS6vEeWc7f-D6ByqMg")]
    [Description(@"??")]
    CardApplication,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType11CodeMetadataExtensions
{
    private static readonly PartyType11CodeDropdownSource _dropdownSource = new PartyType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType11CodeDropdownRow GetMetadata(this PartyType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


