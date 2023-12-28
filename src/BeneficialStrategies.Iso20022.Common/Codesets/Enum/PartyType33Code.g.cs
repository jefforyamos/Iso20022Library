﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType33Code.  ISO2002 ID# _pHKm8Q0wEeqUVL7sB4m7NA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of entity involved in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pHKm8Q0wEeqUVL7sB4m7NA")]
[Description(@"Identification of the type of entity involved in a transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType33Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OriginatingPOI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pTLpsQ0wEeqUVL7sB4m7NA")]
    [Description(@"??")]
    OriginatingPOI,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Merchant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pTLpsw0wEeqUVL7sB4m7NA")]
    [Description(@"??")]
    Merchant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acceptor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pTLptQ0wEeqUVL7sB4m7NA")]
    [Description(@"??")]
    Acceptor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntermediaryAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pTLptw0wEeqUVL7sB4m7NA")]
    [Description(@"??")]
    IntermediaryAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pTLpuQ0wEeqUVL7sB4m7NA")]
    [Description(@"??")]
    Acquirer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pTLpuw0wEeqUVL7sB4m7NA")]
    [Description(@"??")]
    CardIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegateIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pTLpvQ0wEeqUVL7sB4m7NA")]
    [Description(@"??")]
    DelegateIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MasterTerminalManager".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nABSQQ1GEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    MasterTerminalManager,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxAuthority".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pRciUQ1GEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    TaxAuthority,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TerminalManager".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_p-q0sA1GEeqjM-rxn3HuXQ")]
    [Description(@"??")]
    TerminalManager,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType33CodeMetadataExtensions
{
    private static readonly PartyType33CodeDropdownSource _dropdownSource = new PartyType33CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType33CodeDropdownRow GetMetadata(this PartyType33Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


